using System;
using System.IO;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {
            string path = @"c:\lixo\myfolder";

            try {
                //IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                foreach (string s in folders) {
                    Console.WriteLine("FOLDER:");
                    Console.WriteLine(s);

                    var files = Directory.EnumerateFiles(s, "*.*", SearchOption.AllDirectories);
                    //Console.WriteLine("FILES:");
                    foreach (string f in files) {
                        Console.WriteLine(f);
                    }
                }
                //Directory.CreateDirectory(path + @"\newfolder");
            } catch (IOException e) {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
