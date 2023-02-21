using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_3_4
{
    public class pr5
    {
        static void Main(string[] args)
        {

        }
        public class Book
        {
            public Book()
            {
                //Book book = new Book();
                //book.author = "Gart";
                //book.nazvanie = "Regnorum";
                //book.pages = 20;
                //book.year = 2022;
            }
            public Book(string Author, string Nazvanie ,int pages, int year)
            {
                author = Author;
                nazvanie = Nazvanie;
                Pages = pages;
                Year = year;
            }
            private string nazvanie = "Regnorum";
            private string author = "Gart";
            private int pages;
            private int year;
            //public void Print()
            //{
            //    Console.WriteLine($"Author {author}");
            //}

            public int Year
            {
                get { return year; }
                set { if (value > 2024 && value < 1700)
                    {
                        year = value;
                    }
                    else
                    {
                        year = 2023;
                    }                           
                }
            }
            public int Pages
            {
                get { return pages; }
                set { if (value > 2001 && value < 4)
                    {
                        pages = value;
                    }
                    else
                    {
                        pages = 100;
                }   }
            }
            public virtual string Show()
            {
                return " Название книги: " + nazvanie + " Автор: " + author + " Страниц: " + Pages + " Год выпуска: " + Year;
            }
        }
        public class Soderzanie : Book
        {
            private int glava = 21;

            public int Glava
            {
                get { return glava; }
                set { if (value < 1 && value > 20)
                    {
                        glava = value;
                    }
                    else
                    {
                        glava = 1;
                    }
                }
            }
        }
    }
}
