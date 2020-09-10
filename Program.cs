using System;

namespace chuyendoitiente
{
    class Program
    { 
   public static void doitien(){
            int vnd,usd=1;
            vnd = usd * 23000;
           Console.WriteLine("{0} USD = {1} VND ", usd, vnd);
            Console.Read();

        }
        static void Main(string[] args)
        {
             int usd;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Nhập số tiền USD muốn chuyển:");
            usd = Convert.ToInt32(Console.ReadLine());
           doitien();
        
        }
    }
}