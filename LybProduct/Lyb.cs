using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace LibProduct
{
    public abstract class SumProducts
    {
        public string SumProduct;
        public string SumFood;
        public string SumEquipment;
        public string SumFurniture;
        protected string Name { get; set; }
        protected double Price { get; set; }
        readonly Dictionary<string, int> numStrFile = new Dictionary<string, int>
        {
            ["Food"] = 1,
            ["Equipment"] = 2,
            ["Furniture"] = 3
        };
        protected void Sum(string nameSum)
        {
            var massSum = File.ReadAllLines("sum.txt").Select(x => x.Split().ToArray()).ToArray();
            StreamWriter writeFile = new StreamWriter(@"sum.txt", false);
            massSum[0][2] = (Convert.ToDouble(massSum[0][2]) + Price).ToString();
            massSum[numStrFile[nameSum]][2] = (Convert.ToDouble(massSum[numStrFile[nameSum]][2]) + Price).ToString();
            SumProduct = massSum[0][2];
            SumFood = massSum[1][2];
            SumEquipment = massSum[2][2];
            SumFurniture = massSum[3][2];
            writeFile.Write($"Sum = {massSum[0][2]}\nFood = {massSum[1][2]}\nEquipment = {massSum[2][2]}\nFurniture = {massSum[3][2]}");
            writeFile.Close();
        }
    }
    public class Food : SumProducts
    {
        public string TimeLeft;
        private string ShelfLife;
        public Food(string Name, double Price, string ShelfLife)
        {
            this.Name = Name;
            this.Price = Price;
            this.ShelfLife = ShelfLife;
        }
        public void Info()
        {
            DataCheck();
            Sum("Food");
        }
        private void DataCheck()
        {
            string day = "";
            int[] date = ShelfLife.Split('.').Select(x => int.Parse(x)).ToArray();
            DateTime dateSL = new DateTime(date[2], date[1], date[0]);
            TimeLeft = (dateSL.Subtract(DateTime.Now)).ToString();
            if (TimeLeft.IndexOf('.') != -1)
            {
                if (TimeLeft[0] == '1' || TimeLeft.Substring(0, 2) == "-1")
                {
                    day += " day ";
                }
                else
                {
                    day += " days ";
                }
            }
            TimeLeft = TimeLeft.Substring(0, TimeLeft.Length - 8).Replace(".", day);
        }
    }
    public class Equipment : SumProducts
    {
        protected string Company { get; set; }
        public Equipment(string Name, double Price, string Company)
        {
            this.Name = Name;
            this.Price = Price;
            this.Company = Company;
        }
        public string Info()
        {
            Sum("Equipment");
            FavoriteCompany FC = new FavoriteCompany("EquipCompany.txt", Company);
            return FC.ResultString;
        }
    }
    public class Furniture : Equipment
    {
        public Furniture(string Name, double Price, string Company) : base(Name, Price, Company) {}
        public new string Info()
        {
            Sum("Furniture");
            FavoriteCompany FC = new FavoriteCompany("FurnitureCompany.txt", Company);
            return FC.ResultString;
        }
    }
    class FavoriteCompany
    {
        public string ResultString;
        private string path { get; set; }
        private string Company { get; set; }
        private List<string> LinesFromFile;
        private int NumLinesText;
        private string[] ZeroLine; // line with your favorite companies
        private string ZeroCompany; // favorite companies ZeroLine
        private int LenZL;
        private string NumProd; // number of company products
        Dictionary<string, string> ConsoleOut;
        private void FillingDictionary()
        {
            ConsoleOut = new Dictionary<string, string>
            {
                ["new top"] = $"В вашем топе оказалась компания {Company}. Текущее количество покупок равно '{NumProd}'",
                ["const&add"] = $"Вашей любимой компанией осталась {Company} c '{NumProd}' покупками",
                ["const only"] = $"Вашей любимой компанией осталась {ZeroLine[0]} c '{ZeroLine[2]}' покупками",
                ["const lot"] = $"Вашими любимыми компаниями остались {ZeroCompany} с '{ZeroLine[LenZL - 1]}' покупками",
                ["add only"] = $"К вашей любимой компании {ZeroCompany}добавилась {Company}. Текущее количество покупок равно '{NumProd}'",
                ["add lot"] = $"К вашим любимым компаниям {ZeroCompany}добавилась {Company}. Текущее количество покупок равно '{NumProd}'"
            };
        }
        internal FavoriteCompany(string path, string Company)
        {
            this.path = path;
            this.Company = Company;
            NumProd = "1";
            WorkFromFile();
        }
        private void WorkFromFile()
        {
            if (File.Exists(path))
            {
                LinesFromFile = new List<string>(File.ReadAllLines(path));
                NumLinesText = LinesFromFile.Count;
                ZeroLine = LinesFromFile[0].Split(' ');
                LenZL = ZeroLine.Length;
                ZeroCompany = LinesFromFile[0].Substring(0, LinesFromFile[0].IndexOf('='));
                NoFirstFile();
            }
            else
            {
                FirstFile();
            }
        }
        private void FirstFile()
        {
            StreamWriter NewFile = new StreamWriter(path);
            NewFile.WriteLine($"{Company} = 1\n{Company} = 1");
            ResultString = $"Ваша первая покупка товара компании {Company}";
            NewFile.Close();
        }
        private void NoFirstFile()
        {
            bool NoStop = true;
            for (int numStr = 1; numStr < NumLinesText && NoStop; numStr++)
            {
                if (LinesFromFile[numStr].IndexOf(Company) != -1)
                {
                    ProcessingString(numStr);
                    RefreshFile();
                    NoStop = false;
                    break;
                }
            }
            if (NoStop)
            {
                FillingDictionary();
                GeneralTerms(LenZL == 3);
                LinesFromFile.Add($"{Company} = 1");
                RefreshFile();
            }
        }
        private void ProcessingString(int index)
        {
            int IdxNumProd = 2; // сompany product number index
            string[] ArrayWords = LinesFromFile[index].Split(' ');
            NumProd = (int.Parse(ArrayWords[IdxNumProd]) + 1).ToString();
            LinesFromFile[index] = LinesFromFile[index].Replace(ArrayWords[IdxNumProd], NumProd);
            FillingDictionary();
            OutputSelection();
        }
        private void RefreshFile()
        {
            StreamWriter Refresh = new StreamWriter(path);
            Refresh.WriteLine("{0}", string.Join("\n", LinesFromFile));
            Refresh.Close();
        }
        private void OutputSelection()
        {
            bool ThreeElem = LenZL == 3;
            if (ZeroLine[0] == Company && ThreeElem)
            {
                LinesFromFile[0] = $"{Company} = {NumProd}";
                ResultString = ConsoleOut["const&add"];
            }
            else if (int.Parse(ZeroLine[LenZL - 1]) < int.Parse(NumProd))
            {
                LinesFromFile[0] = $"{Company} = {NumProd}";
                ResultString = ConsoleOut["new top"];
            }
            else
            {
                GeneralTerms(ThreeElem);
            }
        }
        private void GeneralTerms(bool ThreeElem)
        {
            if (ZeroLine[LenZL - 1] == NumProd)
            {
                LinesFromFile[0] = LinesFromFile[0].Replace(ZeroCompany, ZeroCompany + Company + ' ');
                if (ThreeElem)
                {
                    ResultString = ConsoleOut["add only"];
                }
                else
                {
                    ResultString = ConsoleOut["add lot"];
                }
            }
            else
            {
                if (ThreeElem)
                {
                    ResultString = ConsoleOut["const only"];
                }
                else
                {
                    ResultString = ConsoleOut["const lot"];
                }
            }
        }
    }
}