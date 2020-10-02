using System;
using System.IO;

namespace Course {
    class Program {
        static void Main(string[] args) {
            string sourcePath = @"c:\lixo\file1.txt";
            string targetPath = @"c:\lixo\file2.txt";

            try {
                string[] lines = File.ReadAllLines(sourcePath);

                using(StreamWriter sw = File.AppendText(targetPath)) {
                    foreach (string line in lines) {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            } catch (IOException e) {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
