namespace WindowsFormsApplication2
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbReaders = new System.Windows.Forms.ComboBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btGiveBook = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btPrev = new System.Windows.Forms.Button();
            this.grdBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.btAddBook = new System.Windows.Forms.Button();
            this.rbtGuarateeed1 = new System.Windows.Forms.RadioButton();
            this.rbtGuarateeed2 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbLibrarians = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGuaranteeSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbIsFinished = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAbout = new System.Windows.Forms.Button();
            this.btOptions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Читатель";
            // 
            // cmbReaders
            // 
            this.cmbReaders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReaders.FormattingEnabled = true;
            this.cmbReaders.Location = new System.Drawing.Point(105, 60);
            this.cmbReaders.Name = "cmbReaders";
            this.cmbReaders.Size = new System.Drawing.Size(305, 21);
            this.cmbReaders.TabIndex = 3;
            this.cmbReaders.SelectedValueChanged += new System.EventHandler(this.cmbReaders_SelectedValueChanged);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(332, 410);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btGiveBook
            // 
            this.btGiveBook.Location = new System.Drawing.Point(483, 343);
            this.btGiveBook.Name = "btGiveBook";
            this.btGiveBook.Size = new System.Drawing.Size(80, 23);
            this.btGiveBook.TabIndex = 8;
            this.btGiveBook.Text = "Сдать книгу";
            this.btGiveBook.UseVisualStyleBackColor = true;
            this.btGiveBook.Click += new System.EventHandler(this.btGiveBook_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(100, 410);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(103, 23);
            this.btNew.TabIndex = 9;
            this.btNew.Text = "Новый прокат";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(419, 410);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(58, 23);
            this.btDelete.TabIndex = 10;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(488, 410);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 11;
            this.btNext.Text = "Вперед";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btPrev
            // 
            this.btPrev.Location = new System.Drawing.Point(11, 410);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(75, 23);
            this.btPrev.TabIndex = 12;
            this.btPrev.Text = "Назад";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // grdBooks
            // 
            this.grdBooks.AllowUserToAddRows = false;
            this.grdBooks.AllowUserToDeleteRows = false;
            this.grdBooks.AllowUserToResizeRows = false;
            this.grdBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdBooks.CausesValidation = false;
            this.grdBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grdBooks.Location = new System.Drawing.Point(13, 149);
            this.grdBooks.MultiSelect = false;
            this.grdBooks.Name = "grdBooks";
            this.grdBooks.ReadOnly = true;
            this.grdBooks.Size = new System.Drawing.Size(550, 147);
            this.grdBooks.TabIndex = 14;
            this.grdBooks.VirtualMode = true;
            this.grdBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBooks_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IndividualNumber";
            this.Column1.HeaderText = "Номер книги";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Название книги";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Author";
            this.Column3.HeaderText = "Автор книги";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Pages";
            this.Column4.HeaderText = "Длительность";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Удалить";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Тип проката";
            // 
            // cmbBooks
            // 
            this.cmbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(15, 122);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(440, 21);
            this.cmbBooks.TabIndex = 17;
            this.cmbBooks.SelectedIndexChanged += new System.EventHandler(this.cmbBooks_SelectedIndexChanged);
            // 
            // btAddBook
            // 
            this.btAddBook.Location = new System.Drawing.Point(461, 122);
            this.btAddBook.Name = "btAddBook";
            this.btAddBook.Size = new System.Drawing.Size(102, 23);
            this.btAddBook.TabIndex = 18;
            this.btAddBook.Text = "Добавить книгу";
            this.btAddBook.UseVisualStyleBackColor = true;
            this.btAddBook.Click += new System.EventHandler(this.btAddBook_Click);
            // 
            // rbtGuarateeed1
            // 
            this.rbtGuarateeed1.AutoSize = true;
            this.rbtGuarateeed1.Location = new System.Drawing.Point(105, 303);
            this.rbtGuarateeed1.Name = "rbtGuarateeed1";
            this.rbtGuarateeed1.Size = new System.Drawing.Size(77, 17);
            this.rbtGuarateeed1.TabIndex = 19;
            this.rbtGuarateeed1.TabStop = true;
            this.rbtGuarateeed1.Text = "с залогом";
            this.rbtGuarateeed1.UseVisualStyleBackColor = true;
            this.rbtGuarateeed1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtGuarateeed2
            // 
            this.rbtGuarateeed2.AutoSize = true;
            this.rbtGuarateeed2.Location = new System.Drawing.Point(105, 327);
            this.rbtGuarateeed2.Name = "rbtGuarateeed2";
            this.rbtGuarateeed2.Size = new System.Drawing.Size(81, 17);
            this.rbtGuarateeed2.TabIndex = 20;
            this.rbtGuarateeed2.TabStop = true;
            this.rbtGuarateeed2.Text = "без залога";
            this.rbtGuarateeed2.UseVisualStyleBackColor = true;
            this.rbtGuarateeed2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(483, 305);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmbLibrarians
            // 
            this.cmbLibrarians.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibrarians.FormattingEnabled = true;
            this.cmbLibrarians.Location = new System.Drawing.Point(105, 93);
            this.cmbLibrarians.Name = "cmbLibrarians";
            this.cmbLibrarians.Size = new System.Drawing.Size(305, 21);
            this.cmbLibrarians.TabIndex = 24;
            this.cmbLibrarians.SelectedValueChanged += new System.EventHandler(this.cmbLibrarians_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Библиотекарь";
            // 
            // tbGuaranteeSum
            // 
            this.tbGuaranteeSum.Location = new System.Drawing.Point(310, 305);
            this.tbGuaranteeSum.Name = "tbGuaranteeSum";
            this.tbGuaranteeSum.Size = new System.Drawing.Size(100, 20);
            this.tbGuaranteeSum.TabIndex = 25;
            this.tbGuaranteeSum.TextChanged += new System.EventHandler(this.btGuaranteeSum_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Залог";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Дата начала";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(220, 353);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(245, 41);
            this.tbComment.TabIndex = 29;
            this.tbComment.TextChanged += new System.EventHandler(this.tbComment_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Комментарий";
            // 
            // cbIsFinished
            // 
            this.cbIsFinished.AutoCheck = false;
            this.cbIsFinished.AutoSize = true;
            this.cbIsFinished.Location = new System.Drawing.Point(544, 305);
            this.cbIsFinished.Name = "cbIsFinished";
            this.cbIsFinished.Size = new System.Drawing.Size(15, 14);
            this.cbIsFinished.TabIndex = 21;
            this.cbIsFinished.UseVisualStyleBackColor = true;
            this.cbIsFinished.CheckedChanged += new System.EventHandler(this.cbIsFinished_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Прокат сдан";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Дата возврата";
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCreateDate.Location = new System.Drawing.Point(105, 350);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(100, 20);
            this.dtpCreateDate.TabIndex = 33;
            this.dtpCreateDate.ValueChanged += new System.EventHandler(this.dtpCreateDate_ValueChanged);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Enabled = false;
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(105, 379);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(100, 20);
            this.dtpReturnDate.TabIndex = 34;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(214, 410);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(104, 23);
            this.btEdit.TabIndex = 35;
            this.btEdit.Text = "Редактировать";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAbout
            // 
            this.btAbout.Location = new System.Drawing.Point(467, 9);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(102, 23);
            this.btAbout.TabIndex = 36;
            this.btAbout.Text = "О приложении";
            this.btAbout.UseVisualStyleBackColor = true;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // btOptions
            // 
            this.btOptions.Location = new System.Drawing.Point(353, 9);
            this.btOptions.Name = "btOptions";
            this.btOptions.Size = new System.Drawing.Size(102, 23);
            this.btOptions.TabIndex = 37;
            this.btOptions.Text = "Настройки";
            this.btOptions.UseVisualStyleBackColor = true;
            this.btOptions.Click += new System.EventHandler(this.btOptions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 447);
            this.Controls.Add(this.btOptions);
            this.Controls.Add(this.btAbout);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.dtpCreateDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbGuaranteeSum);
            this.Controls.Add(this.cmbLibrarians);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbIsFinished);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.rbtGuarateeed2);
            this.Controls.Add(this.rbtGuarateeed1);
            this.Controls.Add(this.btAddBook);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdBooks);
            this.Controls.Add(this.btPrev);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btGiveBook);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.cmbReaders);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = " Прокат №";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbReaders;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btGiveBook;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.DataGridView grdBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Button btAddBook;
        private System.Windows.Forms.RadioButton rbtGuarateeed1;
        private System.Windows.Forms.RadioButton rbtGuarateeed2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmbLibrarians;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbGuaranteeSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbIsFinished;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAbout;
        private System.Windows.Forms.Button btOptions;
    }
}

