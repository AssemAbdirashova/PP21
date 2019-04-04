using System;
using System.Threading;

namespace Yeap
{
    class MyThread
    {
        Thread threadField;

        public string name;
        public MyThread(String name)
        {
            this.name = name;
        }
        public void StartThread()
        {
            threadField = new Thread(startThread);
            threadField.Start();
        }
        public void startThread()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine(name + " выводит " + i);
            }
            Console.WriteLine(name + " завершился");
        }
        static void Main(string[] args)
        {
            MyThread t1 = new MyThread("Thread 1");
            MyThread t2 = new MyThread("Thread 2");
            t1.StartThread();

            t2.StartThread();
            //       Console.Read();
        }
    }
}
    /*public class Mythread
    {
        //public string s ;
        public Mytread(string s)
        {
            ThreadStart potok = new ThreadStart(Dothis);
            Thread thread = new Thread(potok);
            thread.Start();
            thread.Name = s;
        }
    

        public void Dothis()
        {
            for (int i = 1; i <= 4; i++)
            {
                
                Console.WriteLine(Thread.CurrentThread.Name+ "  " + $"{i}");
                
            }
            Console.WriteLine(Thread.CurrentThread.Name+ "end");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Mytread t1 = new Mytread("Thread 1");
            Mytread t2 = new Mytread("Thread 2");
            Mytread t3 = new Mytread("Thread 3");

        /*    t1.Dothis();
            t2.Dothis();
            t3.Dothis();
            

            Console.Read();

        }
    }
}
*/
