using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StringDemo
{
    class SomeClass
    {
        public override string ToString()
        {
            return "bla bla bla";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("uk-ua");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-ua");
            Console.OutputEncoding = Encoding.UTF8;


            String str = new String('a', 5);
            String s = "Hello world";
            String s1 = null;// better don't use
            String s11 = String.Empty;
            //don't do like that
            s += "!!!";
            s += ". ";
            s += "My name is Alexey";


            s = String.Concat(s, "!!!", " ", "My name is Alexey, x=", 5); //5.ToString(); - boxing
            //boxing not hapend
            Console.WriteLine(s);
            Console.WriteLine(5);


            Object o1 = new Object();
            Object o2 = new Object();
            Object o3 = o1;
            if (Object.ReferenceEquals(o1, o2))
            {
                Console.WriteLine("o1 reference equals o3");
            }

            String str1 = "Vasya";
            String str2 = "Vasya";
            if (Object.ReferenceEquals(str1, str2))
            {
                Console.WriteLine("str1 reference equals str2");
            }


            SomeClass o = new SomeClass();
            Console.WriteLine(o.ToString());


            Console.WriteLine(s);


            //sravnenie lokalizovanih peremennih
            String strA = "Strasse";
            String strB = "Strasse"; // napisat' na nemeckom
            if (strA == strB)//strA.Equals(strB);   strA.CompareTo(strB)-> Uchitivaet lokalizaciu
            {
                Console.WriteLine("strA same strB ", strA, strB);
            }
            else
            {
                Console.WriteLine("strA a not same strB ", strA, strB);
            }

            String Ls = "i";//or String Ls = Console.ReadLine();          
            if ("i".ToUpper().CompareTo(Ls.ToLower()) == 0) ;//uchitivaet lokalizaciu
            {

            }

            string fs = String.Format("x={0}, y={1}, z={3}", 10, 2, 0, 0);
            Console.WriteLine(fs);

            int x = 2, y = 10;
            fs = $"X={x}, X={y}";

            Console.WriteLine(@"fydhijguyf"" \ jbkhllkj
hkfyfug kh");


            Console.ReadKey();
        }
    }
}
