using System;
using System.IO;

namespace All_In_One.src.Utilities.SourceFile
{
    public class FileExtention
    {
        public void SourcFile()
        {
            Console.Write("Enter the source folder path: ");
            string sourcePath = Console.ReadLine();
            Console.Write("Enter the destination folder path: ");
            string destinationPath = Console.ReadLine();

            if (!Directory.Exists(sourcePath))
            {
                Console.WriteLine("Source folder does not exist.");
                return;
            }

            string[] files = Directory.GetFiles(sourcePath);

            if (files.Length == 0)
            {
                Console.WriteLine("No file found in the source folder.");
                return;
            }

            foreach (string file in files)
            {
                string extension = Path.GetExtension(file);
                string extensionFolder = Path.Combine(destinationPath, extension.TrimStart('.')); 

                if (!Directory.Exists(extensionFolder))
                {
                    Directory.CreateDirectory(extensionFolder);
                }
                string fileName = Path.GetFileName(file);
                string fileDestinationPath = Path.Combine(extensionFolder, fileName);

                try
                {
                    File.Move(file, fileDestinationPath);
                    Console.WriteLine($"Moved: {fileName} -> {extensionFolder}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error moving {fileName}: {ex.Message}");
                }
            }

            Console.WriteLine("File organization complete!");
        }
    }
}
