using System;
using System.Drawing;
using System.Windows.Forms;
using LibProduct;

namespace Product
{
    public partial class FurnitureForm : Form
    {
        public string NameProduct;
        public double Price;
        public string Company;
        public FurnitureForm()
        {
            InitializeComponent();
            PlayButton.FlatAppearance.BorderSize = 0;
            PlayButton.FlatStyle = FlatStyle.Flat;
            NameLabel.Parent = BackgroundPicture;
            PriceLabel.Parent = BackgroundPicture;
            CompanyLabel.Parent = BackgroundPicture;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            NameProduct = NameInputBox.Text;
            Price = Convert.ToDouble(PriceInputBox.Text);
            Company = CompanyInputBox.Text;
            CompanyInputBox.AutoCompleteCustomSource.Add(Company);

            Furniture furniture = new Furniture(NameProduct, Price, Company);
            FavoriteCompanyBox.Text = furniture.Info();
            SumLabel.Text = furniture.SumProduct + " RUB";
            FoodLabel.Text = furniture.SumFood + " RUB";
            EquipmentLabel.Text = furniture.SumEquipment + " RUB";
            FurnitureLabel.Text = furniture.SumFurniture + " RUB";
        }

        private void BackBox_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseLabel_MouseEnter(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.Red;
        }

        private void CloseLabel_MouseLeave(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.Black;
        }

        private void CollapseLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CollapseLabel_MouseEnter(object sender, EventArgs e)
        {
            CollapseLabel.ForeColor = Color.Red;
        }

        private void CollapseLabel_MouseLeave(object sender, EventArgs e)
        {
            CollapseLabel.ForeColor = Color.Black;
        }

        private void BackBox_MouseEnter(object sender, EventArgs e)
        {
            BackBox.BackColor = Color.FromArgb(198, 198, 198);
        }

        private void BackBox_MouseLeave(object sender, EventArgs e)
        {
            BackBox.BackColor = Color.FromArgb(129, 158, 189);
        }

        Point lastPoint;
        private void EquipmentMainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void EquipmentMainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
