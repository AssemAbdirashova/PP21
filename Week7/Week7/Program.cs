using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(DoIt);
            Thread thread = new Thread(threadStart);
            thread.Start();
            
            
        }

        private static void DoIt()
        {
            
            for (int i = 0; i < 10; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                
                Thread.Sleep(500);
                Console.Write(i);
                
            }
            
        }
    }
}
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Week7
{
    class Program
    {
        static Timer timer = new Timer(100);

        static void Main(string[] args)
        {

            Console.CursorSize = 100;
            timer.Elapsed += Doit;
     //       timer.Elapsed += Doit2;

            timer.Start();
            timer.Stop();
           
            while (timer.Enabled)
            {

            }

        }
        public void Stop()
        {
            timer.Stop();
            Console.Clear();
        }


        private static void Doit(object sender, ElapsedEventArgs e)
        {
           
            Console.Write("0");//+ DateTime.Now.ToLongTimeString());
        }

       /* private static void Doit2(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Hi!");
        }*/
