using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Var19
{
    class Oper
    {
        public int ID;
        public string Style;
    }

    class Opers
    {
        List<Oper> allOpers;
        public Opers()
        {
            allOpers = new List<Oper>();
            allOpers = readOpers();
        }
        public List<Oper> readOpers()
        {
            List<Oper> catalog = new List<Oper>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../OperBase.xml");
            XmlElement xRoot = xDoc.DocumentElement;// получим корневой элемент

            foreach (XmlNode xnode in xRoot)// обход всех узлов в корневом элементе
            {
                Oper temp = new Oper();
                XmlNode attr = xnode.Attributes.GetNamedItem("ID");
                temp.ID = Convert.ToInt32(attr.Value);
                // обходим все дочерние узлы 
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "style")
                    {
                        temp.Style = childnode.InnerText;
                    }
                }
                catalog.Add(temp);
            }
            return catalog;
        }
        public List<Oper> getList()
        {
            return allOpers;
        }
        public Oper findByID(int ID)
        {
            return allOpers.Find(x => x.ID == ID);
        }
        public Oper findByStyle(string Style)
        {
            return allOpers.Find(x => x.Style == Style);
        }
    
    }


}
