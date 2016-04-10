using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeHacker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Random rnd = new Random();

            while (true)
            {
                Console.WriteLine("Hacking IP:" + rnd.Next(0,255) + "."+ rnd.Next(0, 255) + "." + rnd.Next(0, 255) + "." + rnd.Next(0, 255));
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Username:Admin");
                Console.WriteLine("Password:"+RandomString(rnd.Next(0,64))+"\n");
                System.Threading.Thread.Sleep(1000);
            }
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
