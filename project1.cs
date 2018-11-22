using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structMass
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string sname;
            string lname;
            
            inFIO(out name, out sname, out lname);
            Console.WriteLine("Ваше ФИО полностью");
            Console.WriteLine(name + " " + sname + " " + " " + lname);

            //Console.WriteLine(sname);
            //Console.WriteLine(lname);

            IOF(name, sname, lname);

            Console.ReadKey();
        }

        static void inFIO(out string name, out string sname, out string lname)
        {
            Console.WriteLine("Введите полностью ваше ФИО.");
            name = FIO("Введите ваше Имя");
           
            sname = FIO("Введите ваше Фамилию");

            lname = FIO("Введите ваше Отчество");
           

        }

        static string FIO(string a) {
            Console.WriteLine(a);
            string name = Console.ReadLine();
            return name;
        }

        static void IOF(string name, string sname, string lname) {

            char a =  name[0];
            char b = sname[0];

            
        
        }
        //static void IOF(string sname, string name, string lname)
        //{
            

        //}



        //static void FIO(string name, char sname, char lname) 
        //{ 

        //} 

        //static void IOF(char sname, char name, string lname) 
        //{ 

        //} 

        //static void FIO_FULL(string name, string lname, string sname)
        //{

        //}
    }
}
