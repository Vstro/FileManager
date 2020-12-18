using FileManager.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace FileManager.DAO
{
    public static class DAO
    {
        public static String[] GetLogicalDrivesNames()
        {
            return Environment.GetLogicalDrives();
        }

        public static Folder[] GetFolders(String directoryName)
        {
            List<Folder> folders = new List<Folder>();
            foreach (String folderName in Directory.GetDirectories(@directoryName))
            {
                FileInfo info = new FileInfo(@folderName);
                folders.Add(new Folder(folderName, info.LastWriteTime));
            }
            return folders.ToArray();
        }

        public static Entities.File[] GetFiles(String directoryName)
        {
            List<Entities.File> files = new List<Entities.File>();
            foreach (String fileName in Directory.GetFiles(@directoryName))
            {
                FileInfo info = new FileInfo(@fileName);
                files.Add(new Entities.File(fileName, info.LastWriteTime, info.Length));
            }
            return files.ToArray();
        }

        public static void Execute(String fileName)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = fileName;
            process.Start();
        }

        public static void CopyFolder(String source, String destination)
        {
            var stack = new Stack<AdressVector>();
            stack.Push(new AdressVector(source, destination));

            while (stack.Count > 0)
            {
                var folders = stack.Pop();
                Directory.CreateDirectory(folders.Destination);
                foreach (var file in Directory.GetFiles(folders.Source, "*.*"))
                {
                    System.IO.File.Copy(file, Path.Combine(folders.Destination, Path.GetFileName(file)), true);
                }

                foreach (var folder in Directory.GetDirectories(folders.Source))
                {
                    stack.Push(new AdressVector(folder, Path.Combine(folders.Destination, Path.GetFileName(folder))));
                }
            }
        }

        public static bool MoveFolder(String source, String destination)
        {
            try
            {
                Directory.Move(source, destination);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public static bool CopyFile(String source, String destination)
        {
            try
            {
                System.IO.File.Copy(source, destination, true);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public static void MoveFile(String source, String destination)
        {
            System.IO.File.Move(source, destination);
        }

        public static void DeleteFile(String source)
        {
            System.IO.File.Delete(source);
        }

        public static void DeleteFolder(String source)
        {
            Directory.Delete(source, true);
        }

        public static void RenameFile(String oldName, String newName)
        {
            System.IO.File.Move(oldName, newName);
        }

        public static void RenameFolder(String oldName, String newName)
        {
            Directory.Move(oldName, newName);
        }

        public static void CreateFile(String fileName)
        {
            using (System.IO.File.Create(fileName)) { }
        }

        public static void CreateFolder(String folderName)
        {
            Directory.CreateDirectory(folderName);
        }

        public static String ReadWholeFile(String fileName)
        {
            using (StreamReader file = new StreamReader(fileName, Encoding.UTF8))
            {
                return file.ReadToEnd();
            }
        }

        public static void WriteFile(String fileName, String content)
        {
            using (StreamWriter file = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                file.Write(content);
            }
        }
    }
}
