using System;
using System.Collections.Generic;
using System.IO;

namespace FileCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\OneDrive\OneDrive - EDITORA E DISTRIBUIDORA EDUCACIONAL S A\repos\csharp-estudos\Aula13\file1.txt";

            Console.WriteLine("GetRoot: " + Path.GetPathRoot(sourcePath));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(sourcePath));
            Console.WriteLine("GetExtension: " + Path.GetExtension(sourcePath));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(sourcePath));
            Console.WriteLine("GetFileName: " + Path.GetFileName(sourcePath));
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("AltDirectorySeparatorChar: " + Path.AltDirectorySeparatorChar);
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(sourcePath));
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(@"~/"));

        }

        private static void DirectoryList()
        {
            string sourcePath = @"C:\OneDrive\OneDrive - EDITORA E DISTRIBUIDORA EDUCACIONAL S A\repos\csharp-estudos\Aula13\MyFolder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach (string item in folders)
                {
                    Console.WriteLine(item);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                Directory.CreateDirectory(sourcePath + @"\newFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An errir occurred");
                Console.WriteLine(e.Message);
            }
        }

        private static void StreamWriteFile()
        {
            string sourcePath = @"C:\OneDrive\OneDrive - EDITORA E DISTRIBUIDORA EDUCACIONAL S A\repos\csharp-estudos\Aula13\file1.txt";
            string targetPath = @"C:\OneDrive\OneDrive - EDITORA E DISTRIBUIDORA EDUCACIONAL S A\repos\csharp-estudos\Aula13\file3.txt";


            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }

                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An errir occurred");
                Console.WriteLine(e.Message);
            }
        }

        private static void UsingStreamRead()
        {
            string sourcePath = @"C:\OneDrive\OneDrive - EDITORA E DISTRIBUIDORA EDUCACIONAL S A\repos\csharp-estudos\Aula13\file1.txt";

            try
            {
                using (StreamReader streamReader = File.OpenText(sourcePath))
                {
                    string line;
                    while (!streamReader.EndOfStream)
                    {
                        line = streamReader.ReadLine();
                        Console.WriteLine(line);
                    }
                }



                //using (FileStream fs = new FileStream(sourcePath, FileMode.Open))
                //{
                //    using (StreamReader streamReader = new StreamReader(fs))
                //    {
                //        while (!streamReader.EndOfStream)
                //        {
                //            string line = streamReader.ReadLine();
                //            Console.WriteLine(line);

                //        }
                //    }
                //}
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }

        private static void FileStreamReader()
        {
            string sourcePath = @"C:\OneDrive\OneDrive - EDITORA E DISTRIBUIDORA EDUCACIONAL S A\repos\csharp-estudos\Aula13\file1.txt";

            FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                //fileStream = new FileStream(sourcePath, FileMode.Open);
                //streamReader = new StreamReader(fileStream);

                streamReader = File.OpenText(sourcePath);
                string line = streamReader.ReadLine();

                while (!streamReader.EndOfStream)
                {
                    line = streamReader.ReadLine();
                    Console.WriteLine(line);

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
                //if (fileStream != null) fileStream.Close();
            }
        }

        private static void CopyReadFileFileInfo()
        {
            string sourcePath = @"C:\OneDrive\OneDrive - EDITORA E DISTRIBUIDORA EDUCACIONAL S A\repos\csharp-estudos\Aula13\file1.txt";
            string targetPath = @"C:\OneDrive\OneDrive - EDITORA E DISTRIBUIDORA EDUCACIONAL S A\repos\csharp-estudos\Aula13\file2.txt";

            try
            {

                FileInfo fileInfo = new FileInfo(sourcePath);

                if (File.Exists(targetPath))
                {
                    File.Delete(targetPath);
                }


                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}