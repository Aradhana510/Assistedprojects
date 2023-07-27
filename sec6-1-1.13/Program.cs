using System;
using System.IO;

namespace TextFileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        static void doApp()
        {
            string filePath = "demo.txt";

            // Step 1: Creating a text file and writing data into it.
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Hello, this is a text file!");
                    writer.WriteLine("Writing multiple lines.");
                    writer.WriteLine("Adding more text.");
                }

                Console.WriteLine("Text file created and data written successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while writing to the file: " + ex.Message);
            }

            // Step 2: Reading data from the text file.
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    Console.WriteLine("\nData read from the file:");
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading the file: " + ex.Message);
            }
        }
    }
}
