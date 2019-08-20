using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Var19
{
    class Zayavka
    {
        public int ID;
        public Client client;
        public Oper oper;
        public int cost;
        public string time;
        public string nomen;
        public string date;
        public Zayavka()
        {

        }

        public Zayavka(int tek,string C, int O, string Cost, string Time,string date,Clients clients, Opers opers )
        {
            this.ID = tek;
            this.client = clients.findByFIO(C);
            this.oper = opers.findByID(O);
            this.cost = Convert.ToInt32(Cost);
            this.time = Time;
            this.date = date;
        }
    }

    class Zayavki
    {
        List<Zayavka> AllZayavki;

        public Zayavki(Clients clients, Opers opers)
        {
            AllZayavki = new List<Zayavka>();
            AllZayavki = readZayavki(clients, opers);
        }

        public List<Zayavka> readZayavki(Clients clients, Opers opers)
        {
            List<Zayavka> catalog = new List<Zayavka>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../DataBase.xml");
            XmlElement xRoot = xDoc.DocumentElement;// получим корневой элемент

            foreach (XmlNode xnode in xRoot)// обход всех узлов в корневом элементе
            {
                Zayavka temp = new Zayavka();
                XmlNode attr = xnode.Attributes.GetNamedItem("ID");
                temp.ID = Convert.ToInt32(attr.Value);
                // обходим все дочерние узлы 
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "Client")
                    {
                        temp.client = clients.findByID(Convert.ToInt32(childnode.InnerText));
                    }
                    if (childnode.Name == "OperrationType")
                    {
                        temp.oper= opers.findByID(Convert.ToInt32(childnode.InnerText));
                    }
                    if (childnode.Name == "Cost")
                    {
                        temp.cost = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "During")
                    {
                        temp.time = childnode.InnerText;
                    }
                    if (childnode.Name == "Nomenklatura")
                    {
                        temp.nomen = childnode.InnerText;
                    }
                    if (childnode.Name == "Date")
                    {
                        temp.date = childnode.InnerText;
                    }
                }
                catalog.Add(temp);
            }
            return catalog;
        }

        public Zayavka Next(int ID)
        {
            int index = AllZayavki.FindIndex(x => x.ID == ID);
            if (index < AllZayavki.Count - 1)
            {
                return AllZayavki[index + 1];
            }
            return AllZayavki[index];
        }

        public Zayavka Prev(int ID)
        {
            int index = AllZayavki.FindIndex(x => x.ID == ID);
            if (index > 0)
            {
                return AllZayavki[index - 1];
            }
            if (index < 0)
            {
               int index1 = AllZayavki.FindIndex(x => x.ID  == ID-1);
               return AllZayavki[index1];
            }
            return AllZayavki[0];

        }

        public int getMax()
        {
            int max = 0;
            foreach (Zayavka Z in AllZayavki)
            {
                if (max < Z.ID) max = Z.ID;
            }
            return max;
        }

        public int getMin()
        {
            int min = 0;
            if (AllZayavki.Count > 0)
            {
                min = AllZayavki[0].ID;
                foreach (Zayavka Z in AllZayavki)
                {
                    if (min > Z.ID) min = Z.ID;
                }
            }
            return min;
        }

        public Zayavka findByID(int ID)
        {
            return AllZayavki.Find(x => x.ID == ID);
        }

        public void AddZayavka(Zayavka Z)
        {
            AllZayavki.Add(Z);
        }

        public void DelZayavka(Zayavka Z)
        {
            AllZayavki.Remove(Z);
        }

        public void SaveZayavki()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../DataBase.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            xRoot.RemoveAll();
            foreach (Zayavka Z in AllZayavki)
            {
                XmlNode Zayavka = xDoc.CreateElement("Zayavka");
                xDoc.DocumentElement.AppendChild(Zayavka);//указываем родителя
                XmlAttribute ID = xDoc.CreateAttribute("ID");//созд атрибут
                ID.Value = Convert.ToString(Z.ID);//уст значение
                Zayavka.Attributes.Append(ID);//присваиваем

                XmlNode Client = xDoc.CreateElement("Client"); // даём имя
                Client.InnerText = Convert.ToString(Z.client.ID); // и значение
                Zayavka.AppendChild(Client); // и указываем кому принадлежит

                XmlNode OperrationType = xDoc.CreateElement("OperrationType");
                OperrationType.InnerText = Convert.ToString(Z.oper.ID);
                Zayavka.AppendChild(OperrationType);

                XmlNode Cost = xDoc.CreateElement("Cost");
                Cost.InnerText = Convert.ToString(Z.cost);
                Zayavka.AppendChild(Cost);

                XmlNode During = xDoc.CreateElement("During");
                During.InnerText = Z.time;
                Zayavka.AppendChild(During);

                XmlNode Date = xDoc.CreateElement("Date");
                Date.InnerText = Z.date;
                Zayavka.AppendChild(Date);
            }
            xDoc.Save("../../DataBase.xml");
        }
    }
}
