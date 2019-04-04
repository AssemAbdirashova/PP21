using System;
using System.IO;

namespace _1

{
    class FarManager
    {
        public int cursor;
        //public int k;
        public int z;
        public string path;
        public int sz;
        //   public bool ok;
        DirectoryInfo directory = null;
        FileSystemInfo currentFs = null;

        public FarManager()
        {
            cursor = 0;
        }

        public FarManager(string path)
        {
            this.path = path;
            cursor = 0;
            directory = new DirectoryInfo(path);
            sz = directory.GetFileSystemInfos().Length;
            //k = true;
        }

        public void Color(FileSystemInfo fs, int index)
        {
            if (cursor == index)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                currentFs = fs;
            }
            else if (fs.GetType() == typeof(DirectoryInfo))
            {

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }
        /*
        public void TheBest()
        {
            directory = new DirectoryInfo(path);
            foreach (var x in directory.GetDirectories())
            {
                int cnt = x.GetFiles("*.txt").Length;
                Console.WriteLine(x.Name + " " + cnt);
            }

            foreach( var  x in directory.GetFiles())
            {
                Console.WriteLine(x.Name);
            }
                


        }*/

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            for (int i = 0, k = 0; i < fs.Length; i++)
            {
                Color(fs[i], k);

                Console.WriteLine((i+1) + "."+fs[i].Name );
                //TheBest();
                k++;

            }
        }

        public void Up()
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;
        }
        public void Down()
        {
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }
        /*    public void Delete()
              {
                  File.Delete(path);

              }
              /*public void CalcSz()
              {
                  directory = new DirectoryInfo(path);
                  FileSystemInfo[] fs = directory.GetFileSystemInfos();
                  sz = fs.Length;
                  if (ok == false)
                      for (int i = 0; i < fs.Length; i++)
                          if (fs[i].Name[0] == '.')
                              sz--;
              }*/

        public void Start()
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            while (consoleKey.Key != ConsoleKey.Escape)
            {
                //CalcSz();
                Show();
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.UpArrow)
                    Up();
                if (consoleKey.Key == ConsoleKey.DownArrow)
                    Down();
                if (consoleKey.Key == ConsoleKey.Enter)
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        path = currentFs.FullName;

                    }
                    else
                    {
                        FileStream fs = new FileStream(currentFs.FullName, FileMode.Open, FileAccess.Read);
                        StreamReader sr = new StreamReader(fs);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine(sr.ReadToEnd());
                        Console.ReadKey();


                    }

                }
                if (consoleKey.Key == ConsoleKey.Delete)
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        Directory.Delete(currentFs.FullName, true);
                    }
                    else
                    {
                        File.Delete(currentFs.FullName);


                    }

                }
                if (consoleKey.Key == ConsoleKey.RightWindows)
                {
                    File.Move(currentFs.FullName, Console.ReadLine());
                }
                if (consoleKey.Key == ConsoleKey.Backspace)
                {
                    cursor = 0;
                    path = directory.Parent.FullName;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Дакотти\Desktop\aaa";
            FarManager farManager = new FarManager(path);
            farManager.Start();
        }
    }
}

