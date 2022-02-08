using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lowtoupper
{
    using System;
    using System.IO;
    namespace FileLowerCaseToUpperCase
    {
        class lowtoupper
        {
            static void Main()
            {
                Console.Write("Enter name file: ");
                string fileName = Console.ReadLine();

                if (File.Exists(fileName))
                {
                    StreamReader fileRw = File.OpenText(fileName);
                    StreamWriter fileWr = File.CreateText(fileName + ".dat");
                    string line;
                    do
                    {
                        line = fileRw.ReadLine();
                        if (line != null)
                            fileWr.WriteLine(line.ToUpper());
                    }
                    while (line != null);
                    fileRw.Close();
                    fileWr.Close();
                }
                Console.ReadLine();
            }
        }
    }
}