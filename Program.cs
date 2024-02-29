using System;
using System.Linq;
namespace test
{
    public delegate void ShowLog(string message);   
    internal class Program
    { 
        static void Info(string s)

        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Warning(string s)
        {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static int Total(int a, int b)
        {
            return a + b;
        }
        static void ReverseString(string a,string b, ShowLog show)

        {
            string c = a + b;
            char[] arr = c.ToCharArray();
            Array.Reverse(arr);
            string d = new string(arr);
            show?.Invoke(d);

        }
        static void Main(string[] args)
        {

            //ShowLog log = null;
            //log += Info;
            //log += Info;
            //log += Info;
            //log += Warning;
            //log += Warning;
            //log += Info;
            //log?.Invoke("Hello World");
            // Action:
            Action action; // ~delegate  void valuestype ();
            Action<int, string> action1; // ~delegate valuestype (int i, string s);
            //example:
            Action<string> action2;
            action2 = Info;
            action2 += Warning;
            action2?.Invoke("Hello friend");
            // Func: // kiểu trả về được liệt kê ở cuôi cùng.
            Func<int> ex1; //~ delegate int valuesType(int);
            Func<string, int, bool> ex2;//~ delegate bool valueType(string s, int i); 
            Func<int, int, int> tong;
            tong = Total;
            Console.WriteLine($" Tong la:{tong(1,2)}");
            Func<string, string, string> daoChuoi;
            //daoChuoi = ReverseString;
            //Console.WriteLine($"Ket qua la: {daoChuoi("Hello","Xin chao")}");
            ReverseString("Hello", "Xin chao", Warning);


            Console.Read();
        }
        
    }
}

