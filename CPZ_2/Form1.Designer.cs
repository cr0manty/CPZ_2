namespace CPZ_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EmployeeList = new System.Windows.Forms.ListBox();
            this.ShowCreateShop = new System.Windows.Forms.Button();
            this.ShopName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ShopHide = new System.Windows.Forms.Button();
            this.ShopCreateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ShopAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShopList = new System.Windows.Forms.ComboBox();
            this.EmployeeShow = new System.Windows.Forms.Button();
            this.ShopCreatePanel = new System.Windows.Forms.Panel();
            this.ShopAmountItems = new System.Windows.Forms.NumericUpDown();
            this.ShopDepAmount = new System.Windows.Forms.NumericUpDown();
            this.EmployeePanel = new System.Windows.Forms.Panel();
            this.EmployeeSalary = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.EmployeeHide = new System.Windows.Forms.Button();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.EmployeeCreate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.YearProfit = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.MonthProfit = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CurrentShop = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ShopCreatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShopAmountItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDepAmount)).BeginInit();
            this.EmployeePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeList
            // 
            this.EmployeeList.FormattingEnabled = true;
            this.EmployeeList.Location = new System.Drawing.Point(9, 103);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.Size = new System.Drawing.Size(152, 173);
            this.EmployeeList.TabIndex = 0;
            // 
            // ShowCreateShop
            // 
            this.ShowCreateShop.Location = new System.Drawing.Point(167, 61);
            this.ShowCreateShop.Name = "ShowCreateShop";
            this.ShowCreateShop.Size = new System.Drawing.Size(113, 32);
            this.ShowCreateShop.TabIndex = 1;
            this.ShowCreateShop.Text = "Создать магазин";
            this.ShowCreateShop.UseVisualStyleBackColor = true;
            this.ShowCreateShop.Click += new System.EventHandler(this.ShowCreateShop_Click);
            // 
            // ShopName
            // 
            this.ShopName.Location = new System.Drawing.Point(44, 52);
            this.ShopName.Name = "ShopName";
            this.ShopName.Size = new System.Drawing.Size(127, 20);
            this.ShopName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список магазинов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Список  работников";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Создать магазин";
            // 
            // ShopHide
            // 
            this.ShopHide.Location = new System.Drawing.Point(115, 216);
            this.ShopHide.Name = "ShopHide";
            this.ShopHide.Size = new System.Drawing.Size(56, 23);
            this.ShopHide.TabIndex = 17;
            this.ShopHide.Text = "Отмена";
            this.ShopHide.UseVisualStyleBackColor = true;
            this.ShopHide.Click += new System.EventHandler(this.ShopHide_Click);
            // 
            // ShopCreateButton
            // 
            this.ShopCreateButton.Location = new System.Drawing.Point(44, 216);
            this.ShopCreateButton.Name = "ShopCreateButton";
            this.ShopCreateButton.Size = new System.Drawing.Size(65, 23);
            this.ShopCreateButton.TabIndex = 16;
            this.ShopCreateButton.Text = "Создать";
            this.ShopCreateButton.UseVisualStyleBackColor = true;
            this.ShopCreateButton.Click += new System.EventHandler(this.ShopCreateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Количество отделов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Адрес";
            // 
            // ShopAddress
            // 
            this.ShopAddress.Location = new System.Drawing.Point(44, 97);
            this.ShopAddress.Name = "ShopAddress";
            this.ShopAddress.Size = new System.Drawing.Size(127, 20);
            this.ShopAddress.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Количество наименований";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя магазина";
            // 
            // ShopList
            // 
            this.ShopList.FormattingEnabled = true;
            this.ShopList.Location = new System.Drawing.Point(12, 61);
            this.ShopList.Name = "ShopList";
            this.ShopList.Size = new System.Drawing.Size(149, 21);
            this.ShopList.TabIndex = 7;
            this.ShopList.SelectedIndexChanged += new System.EventHandler(this.ShopList_SelectedIndexChanged);
            // 
            // EmployeeShow
            // 
            this.EmployeeShow.Enabled = false;
            this.EmployeeShow.Location = new System.Drawing.Point(167, 102);
            this.EmployeeShow.Name = "EmployeeShow";
            this.EmployeeShow.Size = new System.Drawing.Size(113, 31);
            this.EmployeeShow.TabIndex = 8;
            this.EmployeeShow.Text = "Создать работника";
            this.EmployeeShow.UseVisualStyleBackColor = true;
            this.EmployeeShow.Click += new System.EventHandler(this.EmployeeShow_Click);
            // 
            // ShopCreatePanel
            // 
            this.ShopCreatePanel.Controls.Add(this.ShopAmountItems);
            this.ShopCreatePanel.Controls.Add(this.ShopDepAmount);
            this.ShopCreatePanel.Controls.Add(this.label5);
            this.ShopCreatePanel.Controls.Add(this.ShopHide);
            this.ShopCreatePanel.Controls.Add(this.ShopName);
            this.ShopCreatePanel.Controls.Add(this.ShopCreateButton);
            this.ShopCreatePanel.Controls.Add(this.label3);
            this.ShopCreatePanel.Controls.Add(this.label7);
            this.ShopCreatePanel.Controls.Add(this.label4);
            this.ShopCreatePanel.Controls.Add(this.label6);
            this.ShopCreatePanel.Controls.Add(this.ShopAddress);
            this.ShopCreatePanel.Location = new System.Drawing.Point(340, 309);
            this.ShopCreatePanel.Name = "ShopCreatePanel";
            this.ShopCreatePanel.Size = new System.Drawing.Size(209, 255);
            this.ShopCreatePanel.TabIndex = 9;
            this.ShopCreatePanel.Visible = false;
            // 
            // ShopAmountItems
            // 
            this.ShopAmountItems.Location = new System.Drawing.Point(44, 180);
            this.ShopAmountItems.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.ShopAmountItems.Name = "ShopAmountItems";
            this.ShopAmountItems.Size = new System.Drawing.Size(127, 20);
            this.ShopAmountItems.TabIndex = 19;
            // 
            // ShopDepAmount
            // 
            this.ShopDepAmount.Location = new System.Drawing.Point(44, 141);
            this.ShopDepAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.ShopDepAmount.Name = "ShopDepAmount";
            this.ShopDepAmount.Size = new System.Drawing.Size(127, 20);
            this.ShopDepAmount.TabIndex = 18;
            // 
            // EmployeePanel
            // 
            this.EmployeePanel.Controls.Add(this.EmployeeSalary);
            this.EmployeePanel.Controls.Add(this.label8);
            this.EmployeePanel.Controls.Add(this.EmployeeHide);
            this.EmployeePanel.Controls.Add(this.EmployeeName);
            this.EmployeePanel.Controls.Add(this.EmployeeCreate);
            this.EmployeePanel.Controls.Add(this.label9);
            this.EmployeePanel.Controls.Add(this.label10);
            this.EmployeePanel.Location = new System.Drawing.Point(286, 61);
            this.EmployeePanel.Name = "EmployeePanel";
            this.EmployeePanel.Size = new System.Drawing.Size(209, 161);
            this.EmployeePanel.TabIndex = 20;
            this.EmployeePanel.Visible = false;
            // 
            // EmployeeSalary
            // 
            this.EmployeeSalary.Location = new System.Drawing.Point(44, 91);
            this.EmployeeSalary.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.EmployeeSalary.Name = "EmployeeSalary";
            this.EmployeeSalary.Size = new System.Drawing.Size(127, 20);
            this.EmployeeSalary.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Создать работника";
            // 
            // EmployeeHide
            // 
            this.EmployeeHide.Location = new System.Drawing.Point(115, 127);
            this.EmployeeHide.Name = "EmployeeHide";
            this.EmployeeHide.Size = new System.Drawing.Size(56, 23);
            this.EmployeeHide.TabIndex = 17;
            this.EmployeeHide.Text = "Отмена";
            this.EmployeeHide.UseVisualStyleBackColor = true;
            this.EmployeeHide.Click += new System.EventHandler(this.EmployeeHide_Click);
            // 
            // EmployeeName
            // 
            this.EmployeeName.Location = new System.Drawing.Point(44, 52);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(127, 20);
            this.EmployeeName.TabIndex = 2;
            // 
            // EmployeeCreate
            // 
            this.EmployeeCreate.Location = new System.Drawing.Point(44, 127);
            this.EmployeeCreate.Name = "EmployeeCreate";
            this.EmployeeCreate.Size = new System.Drawing.Size(65, 23);
            this.EmployeeCreate.TabIndex = 16;
            this.EmployeeCreate.Text = "Создать";
            this.EmployeeCreate.UseVisualStyleBackColor = true;
            this.EmployeeCreate.Click += new System.EventHandler(this.EmployeeCreate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Имя работника";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Зарплата";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(164, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Годовой налог (17%):";
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Location = new System.Drawing.Point(164, 165);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(0, 13);
            this.Tax.TabIndex = 22;
            // 
            // YearProfit
            // 
            this.YearProfit.AutoSize = true;
            this.YearProfit.Location = new System.Drawing.Point(164, 201);
            this.YearProfit.Name = "YearProfit";
            this.YearProfit.Size = new System.Drawing.Size(0, 13);
            this.YearProfit.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(164, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Годовая прибыль:";
            // 
            // MonthProfit
            // 
            this.MonthProfit.AutoSize = true;
            this.MonthProfit.Location = new System.Drawing.Point(164, 232);
            this.MonthProfit.Name = "MonthProfit";
            this.MonthProfit.Size = new System.Drawing.Size(0, 13);
            this.MonthProfit.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(164, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Прибыль за месяц:";
            // 
            // CurrentShop
            // 
            this.CurrentShop.AutoSize = true;
            this.CurrentShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentShop.Location = new System.Drawing.Point(143, 9);
            this.CurrentShop.Name = "CurrentShop";
            this.CurrentShop.Size = new System.Drawing.Size(0, 18);
            this.CurrentShop.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(9, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 18);
            this.label15.TabIndex = 21;
            this.label15.Text = "Текущий магазин: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 567);
            this.Controls.Add(this.CurrentShop);
            this.Controls.Add(this.MonthProfit);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.YearProfit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.EmployeePanel);
            this.Controls.Add(this.ShopCreatePanel);
            this.Controls.Add(this.EmployeeShow);
            this.Controls.Add(this.ShopList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowCreateShop);
            this.Controls.Add(this.EmployeeList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СПЗ лаба 2";
            this.ShopCreatePanel.ResumeLayout(false);
            this.ShopCreatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShopAmountItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDepAmount)).EndInit();
            this.EmployeePanel.ResumeLayout(false);
            this.EmployeePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeeList;
        private System.Windows.Forms.Button ShowCreateShop;
        private System.Windows.Forms.TextBox ShopName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ShopHide;
        private System.Windows.Forms.Button ShopCreateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ShopAddress;
        private System.Windows.Forms.ComboBox ShopList;
        private System.Windows.Forms.Button EmployeeShow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel ShopCreatePanel;
        private System.Windows.Forms.NumericUpDown ShopAmountItems;
        private System.Windows.Forms.NumericUpDown ShopDepAmount;
        private System.Windows.Forms.Panel EmployeePanel;
        private System.Windows.Forms.NumericUpDown EmployeeSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button EmployeeHide;
        private System.Windows.Forms.TextBox EmployeeName;
        private System.Windows.Forms.Button EmployeeCreate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label YearProfit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label MonthProfit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label CurrentShop;
        private System.Windows.Forms.Label label15;
    }
}

