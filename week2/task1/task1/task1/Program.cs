﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = File.ReadAllText(@"C:\Users\User\Desktop\ddd\ddd\eroha.txt");
            //В определенном файле находим txt файл и его присваеваем в path
            string newpath = new string(path.ToCharArray().Reverse().ToArray());
            //стринг path делаем реверс и его присваеваем в newpath
            string text = "Yes";
            string text2 = "No";
            if (path == newpath)  //сравниваем оба массива
            {
                File.WriteAllText(@"C:\Users\User\Desktop\ddd\Output.txt", text);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Yes");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                File.WriteAllText(@"C:\Users\User\Desktop\ddd\Output.txt", text2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
