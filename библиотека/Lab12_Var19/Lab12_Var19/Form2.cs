using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12_Var19
{
    public partial class Form2 : Form
    {
        Form main;
        int tek ;
        Zayavki zayavki;
        Opers opers;
        Clients clients;


        public Form2(Form main)
        {
            this.main = main;
            InitializeComponent();
            opers = new Opers();
            clients = new Clients(); 
            zayavki = new Zayavki(clients, opers);
            tek = zayavki.getMax();
            Zayavka Z = zayavki.findByID(tek);
            FillComboBoxes();
            this.ShowData(Z);
            this.Check();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            main.Show();
            Close();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            tek = zayavki.getMax() + 1;
            groupBox1.Text = "Заявка №"+tek;
            ClientBox.Text = "";
            CostBox.Text = "";
            TimeBox.Text = "";
            DateTimeBox.Value = DateTime.Today;
            DelButton.Enabled = true;
            Check();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (tek >= zayavki.getMax())
            {
                Client a = clients.findByFIO(ClientBox.Text);
                if (a == null)
                {
                    Client C = new Client();
                    C.FIO = ClientBox.Text;
                    C.ID = clients.getMax() + 1;
                    clients.AddClient(C);
                    clients.SaveClients();
                }
            }
            int O;
            if (HimButton.Checked == true)
            {
                O = 1;
            }
            else
            {
                O = 2;
            }
            Zayavka Z = new Zayavka(tek, ClientBox.Text, O, CostBox.Text, TimeBox.Text, Convert.ToString(DateTimeBox.Value), clients, opers);
            if (Z.ID <= zayavki.getMax())
            {
                zayavki.findByID(Z.ID).client = Z.client;
                zayavki.findByID(Z.ID).oper = Z.oper;
                zayavki.findByID(Z.ID).cost = Z.cost;
                zayavki.findByID(Z.ID).time = Z.time;
                zayavki.findByID(Z.ID).date = Z.date;
            }
            else
            {
                zayavki.AddZayavka(Z);
            }
            zayavki.SaveZayavki();
            FillComboBoxes();
            Check();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Zayavka Z = zayavki.Prev(tek);
            this.ShowData(Z);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Zayavka Z = zayavki.Next(tek);
            ShowData(Z);
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            bool a = true;
            Zayavka Z = zayavki.findByID(tek);
            Zayavka next = zayavki.Next(tek);
            if (next.ID == tek) // Он последний
            {
                next = zayavki.Prev(tek);
                if (next.ID == tek) // Он был вообще один
                {
                    tek = 1;
                    groupBox1.Text = "Заявка №" + 1;
                    ClientBox.Text = "";
                    CostBox.Text = "";
                    TimeBox.Text = "";
                    DateTimeBox.Value = DateTime.Today;
                    Check();
                    a = false;
                    DelButton.Enabled = false;
                }
            }
            zayavki.DelZayavka(Z);
            zayavki.SaveZayavki();
            if (a)
                ShowData(next);
        }

        private void ShowData(Zayavka Z)
        {
            tek = Z.ID;
            groupBox1.Text = "Заявка №" + Z.ID;
            ClientBox.Text = Z.client.FIO;
            if (Z.oper.ID == 1)
            {
                HimButton.Checked = true;
                ObStButton.Checked = false;
            }
            else
            {
                HimButton.Checked = false;
                ObStButton.Checked = true;
            }
            CostBox.Text = Convert.ToString(Z.cost);
            TimeBox.Text = Z.time;
            DateTimeBox.Value = Convert.ToDateTime(Z.date);
            Check();
        }

        private void Check()
        {
            if (tek >= zayavki.getMax())
            {
                NextButton.Enabled = false;
            }
            else
            {
                NextButton.Enabled = true;
            }
            if (tek == zayavki.getMin())
            {
                BackButton.Enabled = false;
            }
            else
            {
                BackButton.Enabled = true;
            }
        }

        private void FillComboBoxes()
        {
            ClientBox.Items.Clear();
            foreach (Client C in clients.getList()) //заполнение комбобокса
            {
                ClientBox.Items.Add(C.FIO);
            }
        }

        private void CostBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(CostBox.Text);
                errorProvider1.Clear();
                
            }
            catch (FormatException)
            {
                errorProvider1.SetError(CostBox, "введите число");
            }
        }

        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://troll-face.ru/static/a/f/3b/zdorovopravda-B6gPaM.jpg");
        }
    }
}


    
