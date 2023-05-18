using System.IO;
using System.Text;

namespace Learn
{
    public class FileHandlings
    {
        string Source = @"D:\Vinoth\GITHUB\CSharp_Basic_Concepts\SampleTextFile.txt";
        string Destination = @"D:\Vinoth\GITHUB\CSharp_Basic_Concepts\SampleTextFileCopy.txt";
        public void CreateFile()
        {
            FileStream fs = new FileStream(Destination, FileMode.Create);
            Console.WriteLine($"File successfully created at {Source}");
        }

        public void AppendTxtInFile()
        {
            FileStream fs = new FileStream(Source, FileMode.Append);
            byte[] bytedata = Encoding.Default.GetBytes(" C# Is an Object Oriented Programming Language");
            fs.Write(bytedata, 0, bytedata.Length);
            Console.WriteLine("File successfully updated");
            fs.Close();
        }

        public void ReadFile()
        {
            FileStream fs = new FileStream(Source, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string data = sr.ReadToEnd();
            Console.WriteLine(data);
            fs.Close();
        }

        public void WriteFile()
        {
            string Data = "New line Created";
            StreamWriter sw = new StreamWriter(Source);
            sw.Write(Data);
            sw.Flush();
            Console.WriteLine($"Text added successfully {Data}");
            sw.Close();
        }

        public void CopyFile()
        {
            if (File.Exists(Source))
            {
                File.Copy(Source, Destination, true);
                Console.WriteLine($"File copied successfully from {Source} to {Destination}");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }

        public static void FileHandling()
        {
            FileHandlings FileHandling = new FileHandlings();
            // FileHandling.CreateFile();
            // FileHandling.AppendTxtInFile();
            // FileHandling.ReadFile();
            // FileHandling.WriteFile();
            FileHandling.CopyFile();
            // Console.ReadKey();
        }
    }
}