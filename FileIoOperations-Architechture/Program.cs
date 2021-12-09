using System;
using System.IO;

namespace FileIoOperations_Architechture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO operations\n");
            //FileExists();
            //ReadAllLines();
            //FIleCopy();
            //FileDelete();
            StreamReader ReadFromStreamReader = new StreamReader();
            StreamReader.ReadFromStreamReader();
            StreamReader.WriteFromStreamWriter();

        }
        public static void FileExists()
        {
            string path = @"E:\File IO\FileIO-Operations\FileIoOperations-Architechture\Sample.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            Console.ReadKey();
        }
        public static void ReadAllLines()
        {
            string path = @"E:\File IO\FileIO-Operations\FileIoOperations-Architechture\Sample.txt";
            string[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        public static void FIleCopy()
        {
            string path = @"E:\File IO\FileIO-Operations\FileIoOperations-Architechture\Sample.txt";
            string copyPath = @"E:\File IO\FileIO-Operations\FileIoOperations-Architechture\Samplenew.txt";
            File.Copy(path, copyPath);
            Console.ReadKey();
        }
        public static void FileDelete()
        {
            string path = @"E:\File IO\FileIO-Operations\FileIoOperations-Architechture\Sample.txt";
            File.Delete(path);
            Console.ReadKey();
        }
    }
}
