using System;
using System.Drawing;
using System.Windows.Forms;
using LibProduct;

namespace Product
{
    public partial class EquipmentForm : Form
    {
        public string NameProduct;
        public double Price;
        public string Company;
        public EquipmentForm()
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

            Equipment equipment = new Equipment(NameProduct, Price, Company);
            FavoriteCompanyBox.Text = equipment.Info();
            SumLabel.Text = equipment.SumProduct + " RUB";
            FoodLabel.Text = equipment.SumFood + " RUB";
            EquipmentLabel.Text = equipment.SumEquipment + " RUB";
            FurnitureLabel.Text = equipment.SumFurniture + " RUB";
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
            BackBox.BackColor = Color.FromArgb(26, 0, 182);
        }

        private void BackBox_MouseLeave(object sender, EventArgs e)
        {
            BackBox.BackColor = Color.FromArgb(0, 90, 255);
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
