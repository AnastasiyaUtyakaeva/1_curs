namespace Lab12_Var19
{
    partial class Form2
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
            this.DateTimeBox = new System.Windows.Forms.DateTimePicker();
            this.NextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ObStButton = new System.Windows.Forms.RadioButton();
            this.HimButton = new System.Windows.Forms.RadioButton();
            this.ClientBox = new System.Windows.Forms.ComboBox();
            this.DelButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Link = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimeBox
            // 
            this.DateTimeBox.Location = new System.Drawing.Point(14, 167);
            this.DateTimeBox.Name = "DateTimeBox";
            this.DateTimeBox.Size = new System.Drawing.Size(200, 20);
            this.DateTimeBox.TabIndex = 0;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(345, 234);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(86, 30);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Вперёд";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип операции";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Время операции";
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(136, 89);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(100, 20);
            this.CostBox.TabIndex = 9;
            this.CostBox.TextChanged += new System.EventHandler(this.CostBox_TextChanged);
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(136, 115);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(100, 20);
            this.TimeBox.TabIndex = 10;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 234);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(86, 30);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Link);
            this.groupBox1.Controls.Add(this.ObStButton);
            this.groupBox1.Controls.Add(this.HimButton);
            this.groupBox1.Controls.Add(this.ClientBox);
            this.groupBox1.Controls.Add(this.TimeBox);
            this.groupBox1.Controls.Add(this.CostBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DateTimeBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 216);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заявка № 1";
            // 
            // ObStButton
            // 
            this.ObStButton.AutoSize = true;
            this.ObStButton.Location = new System.Drawing.Point(227, 63);
            this.ObStButton.Name = "ObStButton";
            this.ObStButton.Size = new System.Drawing.Size(108, 17);
            this.ObStButton.TabIndex = 13;
            this.ObStButton.TabStop = true;
            this.ObStButton.Text = "Обычная стирка";
            this.ObStButton.UseVisualStyleBackColor = true;
            // 
            // HimButton
            // 
            this.HimButton.AutoSize = true;
            this.HimButton.Location = new System.Drawing.Point(136, 63);
            this.HimButton.Name = "HimButton";
            this.HimButton.Size = new System.Drawing.Size(80, 17);
            this.HimButton.TabIndex = 12;
            this.HimButton.TabStop = true;
            this.HimButton.Text = "Химчистка";
            this.HimButton.UseVisualStyleBackColor = true;
            // 
            // ClientBox
            // 
            this.ClientBox.FormattingEnabled = true;
            this.ClientBox.Location = new System.Drawing.Point(136, 37);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(245, 21);
            this.ClientBox.TabIndex = 11;
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(3, 56);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(90, 42);
            this.DelButton.TabIndex = 14;
            this.DelButton.Text = "Удалить заявку";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(3, 127);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(90, 40);
            this.EditButton.TabIndex = 15;
            this.EditButton.Text = "Принять именения";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(3, 7);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(90, 43);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Добавить заявку";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(3, 209);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(90, 43);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.Text = "Выход";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.DelButton);
            this.panel1.Location = new System.Drawing.Point(437, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 261);
            this.panel1.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Location = new System.Drawing.Point(368, 191);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(31, 13);
            this.Link.TabIndex = 13;
            this.Link.TabStop = true;
            this.Link.Text = "Тык!";
            this.Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 285);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Новая заяквка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimeBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ClientBox;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ObStButton;
        private System.Windows.Forms.RadioButton HimButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel Link;
    }
}