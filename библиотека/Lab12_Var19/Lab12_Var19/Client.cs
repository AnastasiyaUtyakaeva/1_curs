using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Var19
{
    class Client
    {
        public int ID;
        public string FIO;
        public Client()
        {
        }
    }

    class Clients
    {
        List<Client> allClients;

        public Clients()
        {
            allClients = new List<Client>();
            allClients = readClients();
        }
        public List<Client> readClients()
        {
            List<Client> catalog = new List<Client>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../ClientBase.xml");
            XmlElement xRoot = xDoc.DocumentElement;// получим корневой элемент

            foreach (XmlNode xnode in xRoot)// обход всех узлов в корневом элементе
            {
                Client temp = new Client();
                XmlNode attr = xnode.Attributes.GetNamedItem("ID");
                temp.ID = Convert.ToInt32(attr.Value);
                // обходим все дочерние узлы 
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "FIO")
                    {
                        temp.FIO = childnode.InnerText;
                    }
                }
                catalog.Add(temp);
            }
            return catalog;
        }
        public List<Client> getList()
        {
            return allClients;
        }
        
        public Client findByID(int ID)
        {
            return allClients.Find(x => x.ID == ID);
        }
        public Client findByFIO(string FIO)
        {
            return allClients.Find(x => x.FIO == FIO);
        }
        public void AddClient(Client C)
        {
            allClients.Add(C);
        }
        public void SaveClients()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../ClientBase.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            xRoot.RemoveAll();
            foreach (Client C in allClients)
            {
                XmlNode Client = xDoc.CreateElement("Client");
                xDoc.DocumentElement.AppendChild(Client);//указываем родителя
                XmlAttribute ID = xDoc.CreateAttribute("ID");//созд атрибут
                ID.Value = Convert.ToString(C.ID);//уст значение
                Client.Attributes.Append(ID);//присваиваем

                XmlNode FIO = xDoc.CreateElement("FIO"); // даём имя
                FIO.InnerText = C.FIO; // и значение
                Client.AppendChild(FIO); // и указываем кому принадлежит
            }
            xDoc.Save("../../ClientBase.xml");
        }

        public int getMax()
        {
            int max = 0;
            foreach (Client C in allClients)
            {
                if (max < C.ID) max = C.ID;
            }
            return max;
        }


        
    }

}
