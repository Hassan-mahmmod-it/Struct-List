using System;
using System.IO;
using System.Collections.Generic;

class Program
{     public struct lib
    {
        public string book_name;
        public int publish_date;
        public string authore_name;

        public string print()
        {
            return "Book Nmae : "+ book_name+ "    Authore_name :" + authore_name + "    Publish_Date : " + publish_date;
		}
    }
 
    static void Main()
    { 
        List<lib> item = new List<lib>();
        lib ob1 = new lib();
        ob1.book_name = "C#";
        ob1.authore_name = "Hassan Mahmmod";
        ob1.publish_date = 2023;
         
        if (ob1.publish_date > 2019)
        {
            item.Add(ob1);
        }

        foreach (lib it in item)
        {
            Console.WriteLine(it.print());
        }
        Console.ReadKey();
    }
}

