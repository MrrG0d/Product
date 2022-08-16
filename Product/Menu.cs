using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Product
{
    partial class Menu : Form
    {
        public Menu()
        {
            if(!File.Exists("sum.txt"))
            {
                CreateSumFile();
            }
            InitializeComponent();
        }
        private void CreateSumFile()
        {
            StreamWriter FileSum = new StreamWriter("sum.txt");
            FileSum.Write("Sum = 0\nFood = 0\nEquipment = 0\nFurniture = 0");
            FileSum.Close();
        }

        private void FoodButton_Click(object sender, EventArgs e)
        {
            FoodForm food = new FoodForm();
            this.Hide();
            food.ShowDialog();
            this.Close();
        }

        private void EquipmentButton_Click(object sender, EventArgs e)
        {
            EquipmentForm equipment = new EquipmentForm();
            this.Hide();
            equipment.ShowDialog();
            this.Close();22
        }

        private void FurnitureButton_Click(object sender, EventArgs e)
        {
            FurnitureForm furniture = new FurnitureForm();
            this.Hide();
            furniture.ShowDialog();
            this.Close();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.Red;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.Black;
        }

        Point lastPoint;
        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
