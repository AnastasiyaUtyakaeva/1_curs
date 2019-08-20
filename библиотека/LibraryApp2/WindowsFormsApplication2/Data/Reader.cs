using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Data
{
    public class Reader
    {
        static List<Reader> readers = null;
        public static List<Reader> Readers
        {
            get
            {
                //При первом обращении к списку читателей загружаем его из файла
                if (readers == null)
                {
                    readers = new List<Reader>();
                    //считываем из файла по одной строчке
                    foreach (string s in File.ReadAllLines("lll.txt"))
                    {
                        var ts = s.Split(',');
                        //создаем новый экземпляр читателя
                        readers.Add(new Reader() { Id = ts[0].Trim(), FullName = ts[1].Trim() });
                    }
                }
                return readers;
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
