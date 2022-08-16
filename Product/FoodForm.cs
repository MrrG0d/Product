using System;
using System.Drawing;
using System.Windows.Forms;
using LibProduct;

namespace Product
{
    public partial class FoodForm : Form
    {
        public string NameProduct;
        public double Price;
        public string shelfLife;
        public FoodForm()
        {
            InitializeComponent();
            NameLabel.Parent = BackGroundPicture;
            PriceLabel.Parent = BackGroundPicture;
            DateLabel.Parent = BackGroundPicture;
        }

        private void DateInputBox_Enter(object sender, EventArgs e)
        {
            if (DateInputBox.Text == "01.01.2000")
            {
                DateInputBox.Clear();
                DateInputBox.ForeColor = Color.Black;
            }
        }

        private void DateInputBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DateInputBox.Text))
            {
                DateInputBox.Text = "01.01.2000";
                DateInputBox.ForeColor = Color.Silver;
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            NameProduct = NameInputBox.Text;
            Price = Convert.ToDouble(PriceInputBox.Text);
            shelfLife = DateInputBox.Text;
            
            Food food = new Food(NameProduct, Price, shelfLife);
            food.Info();
            
            ShelfLifeLabel.Text = food.TimeLeft;
            SumLabel.Text = food.SumProduct + " RUB";
            FoodLabel.Text = food.SumFood + " RUB";
            EquipmentLabel.Text = food.SumEquipment + " RUB";
            FurnitureLabel.Text = food.SumFurniture + " RUB";
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
            BackBox.BackColor = Color.FromArgb(255, 215, 0);
        }

        private void BackBox_MouseLeave(object sender, EventArgs e)
        {
            BackBox.BackColor = Color.FromArgb(62, 255, 61);
        }

        private void DateInputBox_MouseHover(object sender, EventArgs e)
        {
            DateToolTip.Show("Дата окончания срока годности", DateInputBox);
        }

        Point lastPoint;
        private void FoodMainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void FoodMainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
