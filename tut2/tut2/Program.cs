using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace tut2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter streamWriter = null;
            try
            {
                string csvPath = @"C:\Users\Ego\Desktop\tut2\tut2\tut2\data.csv";
                string result = @"C:\Users\Ego\Desktop\tut2\tut2\tut2\result.xml";
                streamWriter = File.AppendText(result);
               

                List<Student> students = new List<Student>();
                List<string> csvStudents = new List<string>();
                var lines = File.ReadAllLines(csvPath).ToArray();
                var formatedLines = new List<string>();
                foreach (var line in lines)
                {
                    var formatedLine = line.TrimEnd(',');
                    formatedLines.Add(formatedLine);
                }
                csvStudents = formatedLines;
            }
            catch (ArgumentException)
            {
                streamWriter.WriteLine("The path is incorrect");
            }
            catch (FileNotFoundException)
            {
                streamWriter.WriteLine("File does not exist");
            }
            finally
            {
                streamWriter.Close();
            }
        }
    }

}
