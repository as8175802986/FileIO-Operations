using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIoOperations_Architechture
{
    class StreamReader
    {
        public static void WriteFromStreamWriter()
        {
            string path = @"E:\File IO\FileIO-Operations\FileIoOperations-Architechture\Sample.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello my name is Arunesh");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }

        public static void ReadFromStreamReader()
        {
            string path = @"E:\File IO\FileIO-Operations\FileIoOperations-Architechture\Sample.txt";
            using (System.IO.StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}
