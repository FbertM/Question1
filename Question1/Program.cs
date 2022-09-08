using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public class listMobil
        {
            public int IDRegistrasi
            {
                get;
                set;
            }
            public string Tipe
            {
                get;
                set;
            }
            public string Merk
            {
                get;
                set;
            }
            public string Varian
            {
                get;
                set;
            }
        }

        static void Main()
        {
            IEnumerable<listMobil> ListMobil = new listMobil[] {
                new listMobil {
                    IDRegistrasi = 0001, Tipe = "Sedan", Merk = "Toyota", Varian= "FT86"
                },
                new listMobil {
                    IDRegistrasi = 0002, Tipe = "SUV", Merk = "Toyota", Varian ="RAV4"
                },
                new listMobil {
                    IDRegistrasi = 0003, Tipe = "Sedan", Merk = "Honda", Varian= "Accord"
                },
                new listMobil {
                    IDRegistrasi = 0004, Tipe = "SUV", Merk = "Honda", Varian ="CRV"
                },
                new listMobil {
                    IDRegistrasi = 0005, Tipe = "Sedan", Merk = "Honda", Varian = "City"
                },
            };
            Console.WriteLine("Question 1");
            //question db 
            var question1 = ListMobil.Where(o => o.Merk == "Honda").OrderByDescending(o => o.IDRegistrasi)
                            .Select(o => new
                            {
                                IDRegistrasi = o.IDRegistrasi,
                                Merk = o.Merk,
                                Varian = o.Varian
                            }).FirstOrDefault();
            /* var question1 = (from db in ListMobil where db.Merk == "Honda" orderby db.IDRegistrasi ascending 
                         select new { IDRegistrasi= db.IDRegistrasi , Merk = db.Merk, Varian = db.Varian }).FirstOrDefault();*/
            if (question1 != null)
                Console.WriteLine(question1.IDRegistrasi + " " + question1.Merk + " " + question1.Varian);
            Console.WriteLine("Question 2");
            //question 2
            var question2 = ListMobil.Where(o => o.Merk == "Honda" && o.Tipe == "Sedan").OrderByDescending(o => o.IDRegistrasi)
                            .Select(o => new
                            {
                                IDRegistrasi = o.IDRegistrasi,
                                Merk = o.Merk,
                                Varian = o.Varian
                            }).FirstOrDefault();
            /*var question2 = (from db in ListMobil where db.Merk == "Honda" && db.Tipe == "Sedan" orderby db.IDRegistrasi descending
                             select new { IDRegistrasi = db.IDRegistrasi, Merk = db.Merk, Varian = db.Varian }).FirstOrDefault();*/
            if (question2 != null)
                Console.WriteLine(question2.IDRegistrasi + " " + question2.Merk + " " + question2.Varian);
            Console.WriteLine("Question 3");
            //question 3 
            var question3 = ListMobil.Where(o => o.Merk == "Honda" && o.Varian == "City").OrderBy(o => o.IDRegistrasi)
                           .Select(o => new
                           {
                               IDRegistrasi = o.IDRegistrasi,
                               Merk = o.Merk,
                               Varian = o.Varian
                           }).FirstOrDefault();
            /*var question3 = (from db in ListMobil
                             where db.Merk == "Honda" && db.Varian == "City"
                             orderby db.IDRegistrasi descending
                             select new { IDRegistrasi = db.IDRegistrasi, Merk = db.Merk, Varian = db.Varian }).FirstOrDefault();*/
            if (question3 != null)
                Console.WriteLine(question3.IDRegistrasi + " " + question3.Merk + " " + question3.Varian);
            Console.WriteLine("Question 4");
            //question 4
            var question4 = ListMobil.Where(o => o.Merk == "Toyota")
                           .Select(o => new
                           {
                               IDRegistrasi = o.IDRegistrasi,
                               Merk = o.Merk,
                               Varian = o.Varian
                           }).ToList();
            /*var question4 = (from db in ListMobil
                             where db.Merk == "Toyota"
                             select new { IDRegistrasi = db.IDRegistrasi, Merk = db.Merk, Varian = db.Varian }).ToList();*/
            foreach (var quest in question4)
            {
                Console.WriteLine(quest.IDRegistrasi + " " + quest.Merk + " " + quest.Varian);
            }
            Console.WriteLine("Question 5");
            //questin 5 
            var question5 = ListMobil
                           .Select(o => new
                           {
                               IDRegistrasi = o.IDRegistrasi,
                               Merk = o.Merk,
                               Varian = o.Varian
                           }).Take(3);
            /*var question5 = (from db in ListMobil
                            select db).Take(3);*/
            foreach (var quest in question5)
            {
                Console.WriteLine(quest.IDRegistrasi + " " + quest.Merk + " " + quest.Varian);
            }


        }
    }
}
