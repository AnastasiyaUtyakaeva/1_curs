﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Data
{
    public class Rent
    {
        static List<Rent> rents = null;
        public static List<Rent> Rents
        {
            get
            {
                //При первом обращении к списку прокатов загружаем его из файла
                if (rents == null)
                {
                    rents = new List<Rent>();

                    //если файл существует, то прочитаем его, в противном случае вернем пустой список
                    if (File.Exists("rents.txt"))
                        //считываем из файла с книгами по одной строчке
                        foreach (string s in File.ReadAllLines("rents.txt"))
                        {
                            var ts = s.Split(',');

                            //Если при считывании проката произошла какая-то ошибка, то запишем ее в отладочную консоль и пропустим данную строчку
                            try
                            {
                                //создаем новый экземпляр проката
                                var newRent = new Rent()
                                {
                                    Id = int.Parse(ts[0]),
                                    ReaderId = ts[1].Trim(),
                                    LibrarianId = ts[2].Trim(),
                                    Guaranteed = bool.Parse(ts[3]),
                                    GuaranteeSum = ts[4].Trim(),
                                    IsFinished = bool.Parse(ts[5]),
                                    Comment = ts[6].Trim(),
                                    CreateDate = DateTime.Parse(ts[7].Trim()),
                                    BookIds = new List<int>(),
                                    IsDeleted = bool.Parse(ts[9]),
                                };

                                //список книг представлен в виде строки с идентификаторами книг, разделенными точкой с запятой
                                //Мы должны считать из строки все эти числа, преобразовать в int и записать в поле BookIds
                                foreach (var bookId in ts[8].Trim().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
                                {
                                    newRent.BookIds.Add(int.Parse(bookId));
                                }

                                rents.Add(newRent);
                            } catch (Exception ex)
                            {
                                //запишем ошибку в отладочную консоль
                                Debug.WriteLine(ex);
                                MessageBox.Show($"Ошибка загрузки списка прокатов. {ex}");
                            }
                        }
                }
                return rents;
            }
        }

        public static List<Rent> VisibleRents
        {
            get
            {
                return Rents.FindAll(rent => !rent.IsDeleted);
            }
        }

        public Rent()
        {
            Id = GenerateId();
            CreateDate = DateTime.Now;
            BookIds = new List<int>();
        }

        //создаем новый идентификатор проката
        private int GenerateId()
        {
            int maxId = 1;
            //выберем максимальный идентификатор из уже существующих
            foreach (var rent in Rents)
                maxId = Math.Max(maxId, rent.Id);
            //прибавим 1 и вернем полученный номер 
            return ++maxId;
        }

        public int Id { get; set; }
        public string ReaderId { get; set; }
        public string LibrarianId { get; set; }
        public bool Guaranteed { get; set; } //с залогом
        public string GuaranteeSum { get; set; } //залог
        public bool IsFinished { get; set; } //прокат сдан
        public string Comment { get; set; }//комментарий
        public DateTime CreateDate { get; set; } //дата возврата
        public List<int> BookIds { get; set; } //книги
        public bool IsDeleted { get; set; } //удален ли прокат

        //Сохраняем список прокатов в файл
        public static void Save()
        {
            using (var writer = new StreamWriter("rents.txt"))
            {
                foreach (var rent in Rents)
                {
                    string books = string.Join(";", rent.BookIds);
                    var line = $"{rent.Id}, {rent.ReaderId}, {rent.LibrarianId}, {rent.Guaranteed}, {rent.GuaranteeSum}, {rent.IsFinished}, {rent.Comment}, {rent.CreateDate}, {books}, {rent.IsDeleted}";
                    writer.WriteLine(line);
                }
            }
        }
    }
}
