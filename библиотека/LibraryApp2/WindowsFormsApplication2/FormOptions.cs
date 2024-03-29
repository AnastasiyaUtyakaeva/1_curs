﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Data;

namespace WindowsFormsApplication2
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Settings.Instance.ShowNumberInHeader = cbShowNumberInHeader.Checked;
            Settings.Instance.DefaultLibrarianId = (cmbLibrarians.SelectedItem as Librarian)?.Id;
            Settings.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
            cbShowNumberInHeader.Checked = Settings.Instance.ShowNumberInHeader;

            cmbLibrarians.Items.AddRange(Librarian.Librarians.ToArray());
            var selectedLibrarian = Librarian.Librarians.Find(r => r.Id == Settings.Instance.DefaultLibrarianId);
            cmbLibrarians.SelectedItem = selectedLibrarian;
        }
    }
}
