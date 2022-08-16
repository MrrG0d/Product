namespace Product
{
    partial class FoodForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodForm));
            this.NameInputBox = new System.Windows.Forms.TextBox();
            this.PriceInputBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateInputBox = new System.Windows.Forms.TextBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.FoodMainPanel = new System.Windows.Forms.Panel();
            this.FoodTitleLabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.CollapseLabel = new System.Windows.Forms.Label();
            this.BackBox = new System.Windows.Forms.PictureBox();
            this.FoodTable = new System.Windows.Forms.TableLayoutPanel();
            this.ShelfLifeLabel = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.FoodLabel = new System.Windows.Forms.Label();
            this.FurnitureLabel = new System.Windows.Forms.Label();
            this.EquipmentLabel = new System.Windows.Forms.Label();
            this.ShelfLifeTitle = new System.Windows.Forms.Label();
            this.SumTitle = new System.Windows.Forms.Label();
            this.FoodTitle = new System.Windows.Forms.Label();
            this.FurnitureTitle = new System.Windows.Forms.Label();
            this.EquipmentTitle = new System.Windows.Forms.Label();
            this.BackGroundPicture = new System.Windows.Forms.PictureBox();
            this.DateToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FoodMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBox)).BeginInit();
            this.FoodTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // NameInputBox
            // 
            this.NameInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NameInputBox.Location = new System.Drawing.Point(130, 62);
            this.NameInputBox.MaxLength = 30;
            this.NameInputBox.Name = "NameInputBox";
            this.NameInputBox.Size = new System.Drawing.Size(111, 22);
            this.NameInputBox.TabIndex = 1;
            // 
            // PriceInputBox
            // 
            this.PriceInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PriceInputBox.Location = new System.Drawing.Point(130, 104);
            this.PriceInputBox.Name = "PriceInputBox";
            this.PriceInputBox.Size = new System.Drawing.Size(111, 22);
            this.PriceInputBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(25, 62);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(99, 20);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Название";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(25, 104);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(56, 20);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Цена";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(25, 146);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(56, 20);
            this.DateLabel.TabIndex = 5;
            this.DateLabel.Text = "Дата";
            // 
            // DateInputBox
            // 
            this.DateInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DateInputBox.ForeColor = System.Drawing.Color.Silver;
            this.DateInputBox.Location = new System.Drawing.Point(130, 146);
            this.DateInputBox.Name = "DateInputBox";
            this.DateInputBox.Size = new System.Drawing.Size(111, 22);
            this.DateInputBox.TabIndex = 8;
            this.DateInputBox.Text = "01.01.2000";
            this.DateInputBox.Enter += new System.EventHandler(this.DateInputBox_Enter);
            this.DateInputBox.Leave += new System.EventHandler(this.DateInputBox_Leave);
            this.DateInputBox.MouseHover += new System.EventHandler(this.DateInputBox_MouseHover);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayButton.Location = new System.Drawing.Point(141, 191);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(76, 23);
            this.PlayButton.TabIndex = 9;
            this.PlayButton.Text = "ОК";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // FoodMainPanel
            // 
            this.FoodMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(255)))), ((int)(((byte)(61)))));
            this.FoodMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FoodMainPanel.Controls.Add(this.FoodTitleLabel);
            this.FoodMainPanel.Controls.Add(this.CloseLabel);
            this.FoodMainPanel.Controls.Add(this.CollapseLabel);
            this.FoodMainPanel.Controls.Add(this.BackBox);
            this.FoodMainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FoodMainPanel.Location = new System.Drawing.Point(0, 0);
            this.FoodMainPanel.Name = "FoodMainPanel";
            this.FoodMainPanel.Size = new System.Drawing.Size(358, 27);
            this.FoodMainPanel.TabIndex = 11;
            this.FoodMainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FoodMainPanel_MouseDown);
            this.FoodMainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FoodMainPanel_MouseMove);
            // 
            // FoodTitleLabel
            // 
            this.FoodTitleLabel.AutoSize = true;
            this.FoodTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.FoodTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoodTitleLabel.Location = new System.Drawing.Point(149, 1);
            this.FoodTitleLabel.Name = "FoodTitleLabel";
            this.FoodTitleLabel.Size = new System.Drawing.Size(48, 24);
            this.FoodTitleLabel.TabIndex = 15;
            this.FoodTitleLabel.Text = "Еда";
            this.FoodTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(255)))), ((int)(((byte)(61)))));
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseLabel.Location = new System.Drawing.Point(331, 1);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(25, 24);
            this.CloseLabel.TabIndex = 13;
            this.CloseLabel.Text = "X";
            this.CloseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseEnter += new System.EventHandler(this.CloseLabel_MouseEnter);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            // 
            // CollapseLabel
            // 
            this.CollapseLabel.AutoSize = true;
            this.CollapseLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(255)))), ((int)(((byte)(61)))));
            this.CollapseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CollapseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CollapseLabel.Location = new System.Drawing.Point(308, 1);
            this.CollapseLabel.Name = "CollapseLabel";
            this.CollapseLabel.Size = new System.Drawing.Size(17, 24);
            this.CollapseLabel.TabIndex = 13;
            this.CollapseLabel.Text = "-";
            this.CollapseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CollapseLabel.Click += new System.EventHandler(this.CollapseLabel_Click);
            this.CollapseLabel.MouseEnter += new System.EventHandler(this.CollapseLabel_MouseEnter);
            this.CollapseLabel.MouseLeave += new System.EventHandler(this.CollapseLabel_MouseLeave);
            // 
            // BackBox
            // 
            this.BackBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(255)))), ((int)(((byte)(61)))));
            this.BackBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBox.Image = global::Product.Properties.Resources.IconBack;
            this.BackBox.Location = new System.Drawing.Point(0, 0);
            this.BackBox.Name = "BackBox";
            this.BackBox.Size = new System.Drawing.Size(39, 27);
            this.BackBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackBox.TabIndex = 10;
            this.BackBox.TabStop = false;
            this.BackBox.Click += new System.EventHandler(this.BackBox_Click);
            this.BackBox.MouseEnter += new System.EventHandler(this.BackBox_MouseEnter);
            this.BackBox.MouseLeave += new System.EventHandler(this.BackBox_MouseLeave);
            // 
            // FoodTable
            // 
            this.FoodTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FoodTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.FoodTable.ColumnCount = 2;
            this.FoodTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.FoodTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FoodTable.Controls.Add(this.ShelfLifeLabel, 1, 0);
            this.FoodTable.Controls.Add(this.SumLabel, 1, 1);
            this.FoodTable.Controls.Add(this.FoodLabel, 1, 2);
            this.FoodTable.Controls.Add(this.FurnitureLabel, 1, 4);
            this.FoodTable.Controls.Add(this.EquipmentLabel, 1, 3);
            this.FoodTable.Controls.Add(this.ShelfLifeTitle, 0, 0);
            this.FoodTable.Controls.Add(this.SumTitle, 0, 1);
            this.FoodTable.Controls.Add(this.FoodTitle, 0, 2);
            this.FoodTable.Controls.Add(this.FurnitureTitle, 0, 4);
            this.FoodTable.Controls.Add(this.EquipmentTitle, 0, 3);
            this.FoodTable.Location = new System.Drawing.Point(40, 233);
            this.FoodTable.Name = "FoodTable";
            this.FoodTable.RowCount = 5;
            this.FoodTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FoodTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FoodTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FoodTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FoodTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FoodTable.Size = new System.Drawing.Size(274, 189);
            this.FoodTable.TabIndex = 12;
            // 
            // ShelfLifeLabel
            // 
            this.ShelfLifeLabel.AutoSize = true;
            this.ShelfLifeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShelfLifeLabel.Location = new System.Drawing.Point(107, 2);
            this.ShelfLifeLabel.Name = "ShelfLifeLabel";
            this.ShelfLifeLabel.Size = new System.Drawing.Size(162, 35);
            this.ShelfLifeLabel.TabIndex = 14;
            this.ShelfLifeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SumLabel.Location = new System.Drawing.Point(107, 39);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(162, 35);
            this.SumLabel.TabIndex = 13;
            this.SumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FoodLabel
            // 
            this.FoodLabel.AutoSize = true;
            this.FoodLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoodLabel.Location = new System.Drawing.Point(107, 76);
            this.FoodLabel.Name = "FoodLabel";
            this.FoodLabel.Size = new System.Drawing.Size(162, 35);
            this.FoodLabel.TabIndex = 14;
            this.FoodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FurnitureLabel
            // 
            this.FurnitureLabel.AutoSize = true;
            this.FurnitureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FurnitureLabel.Location = new System.Drawing.Point(107, 150);
            this.FurnitureLabel.Name = "FurnitureLabel";
            this.FurnitureLabel.Size = new System.Drawing.Size(162, 37);
            this.FurnitureLabel.TabIndex = 16;
            this.FurnitureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentLabel
            // 
            this.EquipmentLabel.AutoSize = true;
            this.EquipmentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentLabel.Location = new System.Drawing.Point(107, 113);
            this.EquipmentLabel.Name = "EquipmentLabel";
            this.EquipmentLabel.Size = new System.Drawing.Size(162, 35);
            this.EquipmentLabel.TabIndex = 15;
            this.EquipmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShelfLifeTitle
            // 
            this.ShelfLifeTitle.AutoSize = true;
            this.ShelfLifeTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShelfLifeTitle.Location = new System.Drawing.Point(5, 2);
            this.ShelfLifeTitle.Name = "ShelfLifeTitle";
            this.ShelfLifeTitle.Size = new System.Drawing.Size(94, 35);
            this.ShelfLifeTitle.TabIndex = 13;
            this.ShelfLifeTitle.Text = "Срок годности";
            this.ShelfLifeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SumTitle
            // 
            this.SumTitle.AutoSize = true;
            this.SumTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SumTitle.Location = new System.Drawing.Point(5, 39);
            this.SumTitle.Name = "SumTitle";
            this.SumTitle.Size = new System.Drawing.Size(94, 35);
            this.SumTitle.TabIndex = 0;
            this.SumTitle.Text = "Сумма";
            this.SumTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FoodTitle
            // 
            this.FoodTitle.AutoSize = true;
            this.FoodTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoodTitle.Location = new System.Drawing.Point(5, 76);
            this.FoodTitle.Name = "FoodTitle";
            this.FoodTitle.Size = new System.Drawing.Size(94, 35);
            this.FoodTitle.TabIndex = 13;
            this.FoodTitle.Text = "Еда";
            this.FoodTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FurnitureTitle
            // 
            this.FurnitureTitle.AutoSize = true;
            this.FurnitureTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FurnitureTitle.Location = new System.Drawing.Point(5, 150);
            this.FurnitureTitle.Name = "FurnitureTitle";
            this.FurnitureTitle.Size = new System.Drawing.Size(94, 37);
            this.FurnitureTitle.TabIndex = 15;
            this.FurnitureTitle.Text = "Мебель";
            this.FurnitureTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquipmentTitle
            // 
            this.EquipmentTitle.AutoSize = true;
            this.EquipmentTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentTitle.Location = new System.Drawing.Point(5, 113);
            this.EquipmentTitle.Name = "EquipmentTitle";
            this.EquipmentTitle.Size = new System.Drawing.Size(94, 35);
            this.EquipmentTitle.TabIndex = 14;
            this.EquipmentTitle.Text = "Техника";
            this.EquipmentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackGroundPicture
            // 
            this.BackGroundPicture.BackColor = System.Drawing.Color.Transparent;
            this.BackGroundPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackGroundPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGroundPicture.Image = global::Product.Properties.Resources.FoodBackground;
            this.BackGroundPicture.Location = new System.Drawing.Point(0, 0);
            this.BackGroundPicture.Name = "BackGroundPicture";
            this.BackGroundPicture.Size = new System.Drawing.Size(358, 450);
            this.BackGroundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackGroundPicture.TabIndex = 13;
            this.BackGroundPicture.TabStop = false;
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.NameInputBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FoodTable);
            this.Controls.Add(this.FoodMainPanel);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.DateInputBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PriceInputBox);
            this.Controls.Add(this.BackGroundPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FoodMainPanel.ResumeLayout(false);
            this.FoodMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBox)).EndInit();
            this.FoodTable.ResumeLayout(false);
            this.FoodTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameInputBox;
        private System.Windows.Forms.TextBox PriceInputBox;
        private System.Windows.Forms.TextBox DateInputBox;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.PictureBox BackBox;
        private System.Windows.Forms.Panel FoodMainPanel;
        private System.Windows.Forms.TableLayoutPanel FoodTable;
        private System.Windows.Forms.Label FurnitureLabel;
        private System.Windows.Forms.Label EquipmentLabel;
        private System.Windows.Forms.Label FoodLabel;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label ShelfLifeLabel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label CollapseLabel;
        private System.Windows.Forms.PictureBox BackGroundPicture;
        private System.Windows.Forms.Label FoodTitleLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label ShelfLifeTitle;
        private System.Windows.Forms.Label SumTitle;
        private System.Windows.Forms.Label FoodTitle;
        private System.Windows.Forms.Label FurnitureTitle;
        private System.Windows.Forms.Label EquipmentTitle;
        private System.Windows.Forms.ToolTip DateToolTip;
    }
}