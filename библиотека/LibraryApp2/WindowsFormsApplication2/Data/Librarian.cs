using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Data
{
    public class Librarian
    {
        static List<Librarian> librarians = null;
        public static List<Librarian> Librarians
        {
            get
            {
                //При первом обращении к списку библиотекарей загружаем его из файла
                if (librarians == null)
                {
                    librarians = new List<Librarian>();
                    //считываем из файла по одной строчке
                    foreach (string s in File.ReadAllLines("librarians.txt"))
                    {
                        var ts = s.Split(',');
                        //создаем новый экземпляр библиотекаря
                        librarians.Add(new Librarian() { Id = ts[0].Trim(), FullName = ts[1].Trim() });
                    }
                }
                return librarians;
            }
        }

        public string Id { get; set; }
        public string FullName { get; set; }

        //перегрузка стандартной функции, для корректного отображения объекта в выпадающем списке
        public override string ToString()
        {
            return FullName;
        }
    }
}
