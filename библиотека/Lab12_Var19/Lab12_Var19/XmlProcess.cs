using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Var19
{
    class XmlProcess
    {
        XmlDocument xDoc;
        Clients C;
        Opers O;
        Zayavki Z;
        
        
        public XmlProcess(XmlDocument xdoc)
        {
            this.xDoc = xdoc;
            this.C = new Clients();
            this.O = new Opers();
            this.Z = new Zayavki();

        }
        public XmlProcess(XmlDocument xdoc,Clients clients, Zayavki zayavki, Opers opers)
        {
            this.xDoc = xdoc;
            this.C = clients;
            this.Z = zayavki;
            this.O = opers;
        }
        
        public void ReadData()
        {
            XmlElement Main = xDoc.DocumentElement;// получим корневой элемент
            XmlNode xRootC = Main.SelectSingleNode("clients");

            foreach (XmlNode xnodeC in xRootC)// обход всех узлов в корневом элементе
            {
                Client tempC = new Client();
                XmlNode attr = xnodeC.Attributes.GetNamedItem("ID");
                tempC.ID = Convert.ToInt32(attr.Value);
                // обходим все дочерние узлы 
                foreach (XmlNode childnode in xnodeC.ChildNodes)
                {
                    if (childnode.Name == "FIO")
                    {
                        tempC.FIO = childnode.InnerText;
                    }
                }
                C.AddClient(tempC);
            }

            XmlNode xRootO = Main.SelectSingleNode("opers");
            foreach (XmlNode xnodeO in xRootO)// обход всех узлов в корневом элементе
            {
                Oper temp = new Oper();
                XmlNode attr = xnodeO.Attributes.GetNamedItem("ID");
                temp.ID = Convert.ToInt32(attr.Value);
                // обходим все дочерние узлы 
                foreach (XmlNode childnode in xnodeO.ChildNodes)
                {
                    if (childnode.Name == "style")
                    {
                        temp.Style = childnode.InnerText;
                    }
                }
                O.AddOper(temp);
            }

            XmlNode xRootZ = Main.SelectSingleNode("Zayavki");
            foreach (XmlNode xnodeZ in xRootZ)
            {
                Zayavka temp = new Zayavka();
                XmlNode attr = xnodeZ.Attributes.GetNamedItem("ID");
                temp.ID = Convert.ToInt32(attr.Value);
                // обходим все дочерние узлы 
                foreach (XmlNode childnode in xnodeZ.ChildNodes)
                {
                    if (childnode.Name == "Client")
                    {
                        temp.client = C.findByID(Convert.ToInt32(childnode.InnerText));
                    }
                    if (childnode.Name == "OperrationType")
                    {
                        temp.oper = O.findByID(Convert.ToInt32(childnode.InnerText));
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
                Z.AddZayavka(temp);
            }
        }
    
        public void SaveData()
        {
            
            XmlElement Main = xDoc.DocumentElement;
            XmlNode xRoot = Main.SelectSingleNode("Zayavki");
            xRoot.RemoveAll();
            foreach (Zayavka zi in Z.GetZayavki())
            {
                XmlNode Zayavka = xDoc.CreateElement("Zayavka");
                xRoot.AppendChild(Zayavka);//указываем родителя
                XmlAttribute ID = xDoc.CreateAttribute("ID");//созд атрибут
                ID.Value = Convert.ToString(zi.ID);//уст значение
                Zayavka.Attributes.Append(ID);//присваиваем

                XmlNode Client = xDoc.CreateElement("Client"); // даём имя
                Client.InnerText = Convert.ToString(zi.client.ID); // и значение
                Zayavka.AppendChild(Client); // и указываем кому принадлежит

                XmlNode OperrationType = xDoc.CreateElement("OperrationType");
                OperrationType.InnerText = Convert.ToString(zi.oper.ID);
                Zayavka.AppendChild(OperrationType);

                XmlNode Cost = xDoc.CreateElement("Cost");
                Cost.InnerText = Convert.ToString(zi.cost);
                Zayavka.AppendChild(Cost);

                XmlNode During = xDoc.CreateElement("During");
                During.InnerText = zi.time;
                Zayavka.AppendChild(During);

                XmlNode Nomen = xDoc.CreateElement("Nomenklatura");
                Nomen.InnerText = zi.nomen;
                Zayavka.AppendChild(Nomen);

                XmlNode Date = xDoc.CreateElement("Date");
                Date.InnerText = zi.date;
                Zayavka.AppendChild(Date);
            }
            XmlNode xRootC = Main.SelectSingleNode("clients");
            xRootC.RemoveAll();
            foreach (Client ci in C.getList())
            {
                XmlNode Client = xDoc.CreateElement("Client");
                xRootC.AppendChild(Client);//указываем родителя
                XmlAttribute ID = xDoc.CreateAttribute("ID");//созд атрибут
                ID.Value = Convert.ToString(ci.ID);//уст значение
                Client.Attributes.Append(ID);//присваиваем

                XmlNode FIO = xDoc.CreateElement("FIO"); // даём имя
                FIO.InnerText = ci.FIO; // и значение
                Client.AppendChild(FIO); // и указываем кому принадлежит

            }
            xDoc.Save("../../DataBase.xml");
        }


        public Clients GetClients()
        {
            return C;
        }
        public Opers GetOpers()
        {
            return O;
        }
        public Zayavki GetZayavki()
        {
            return Z;
        }
    
    
    }
}
