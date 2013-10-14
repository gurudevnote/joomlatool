using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
public class DirectoryUtils
{
    public void CreateFolder(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            return;
        }
        string[] folders = path.Split("/\\".ToCharArray());
        string currentPath = string.Empty;
        foreach (string folder in folders)
        {
            if (string.IsNullOrEmpty(folder))
            {
                continue;
            }
            if (!string.IsNullOrEmpty(currentPath))
            {
                currentPath += "\\" + folder;
            }
            else
            {
                currentPath += folder;
            }

            if (!Directory.Exists(currentPath))
            {
                //output.writeln(currentPath);
                Directory.CreateDirectory(currentPath);                
            }
            CreateIndexHtmlFile(currentPath);
        }
    }

    private void CreateIndexHtmlFile(string currentPath)
    {
        //throw new NotImplementedException();
        string indexPath = currentPath+"\\index.html";
        if (!File.Exists(indexPath))
        {
            StreamWriter writer = File.CreateText(indexPath);
            writer.Write("<!DOCTYPE html><title></title>");
            writer.Close();
        }
    }

    public void GetAllFileInDirectory(string path, string prefixPath, ref List<string> files)
    {
        //output.writeln(path);
        if (files == null)
        {
            files = new List<string>();
        }

        if (!Directory.Exists(path))
        {
            //output.writeln(path + ", is not exited");
            return;
        }

        if (string.IsNullOrEmpty(prefixPath))
        {
            prefixPath = string.Empty;
        }
        //correct prefixPath
        prefixPath = Regex.Replace(prefixPath, "\\+", "\\");
        prefixPath = Regex.Replace(prefixPath, "/+", "\\");
        if (!prefixPath.EndsWith("\\"))
        {
            prefixPath = prefixPath + "\\";
        }

        DirectoryInfo directory = new DirectoryInfo(path);
        foreach (FileInfo file in directory.GetFiles())
        {
            string fileName = file.FullName.Replace(prefixPath, string.Empty);
            fileName = Regex.Replace(fileName, "\\+", "/");
            //output.writeln(fileName);
            files.Add(fileName);
        }

        foreach (DirectoryInfo dir in directory.GetDirectories())
        {
            GetAllFileInDirectory(dir.FullName, prefixPath, ref files);
        }
    }

    private List<string> GetAllSubDirectory(string path, string prefixPath)
    {
        //output.writeln(path);
        List<string> directories = new List<string>();

        if (!Directory.Exists(path))
        {
            //output.writeln(path + ", is not exited");
            return directories;
        }

        if (string.IsNullOrEmpty(prefixPath))
        {
            prefixPath = string.Empty;
        }
        //correct prefixPath
        prefixPath = Regex.Replace(prefixPath, "\\+", "\\");
        prefixPath = Regex.Replace(prefixPath, "/+", "\\");
        if (!prefixPath.EndsWith("\\"))
        {
            prefixPath = prefixPath + "\\";
        }

        DirectoryInfo directory = new DirectoryInfo(path);
        foreach (DirectoryInfo dir in directory.GetDirectories())
        {
            //GetAllFileInDirectory(dir.FullName, prefixPath, ref files);
            string dirName = dir.FullName.Replace(prefixPath, string.Empty);
            directories.Add(dirName);
        }

        return directories;
    }


        // Copy directory structure recursively

    public static void CopyDirectory(string Src,string Dst)
    {
        String[] Files;

        if(Dst[Dst.Length-1]!=Path.DirectorySeparatorChar) 
        {
            Dst+=Path.DirectorySeparatorChar;
        }
        if(!Directory.Exists(Dst))
        {
            Directory.CreateDirectory(Dst);
        }

        Files=Directory.GetFileSystemEntries(Src);
        foreach(string Element in Files)
        {
            // Sub directories
            if(Directory.Exists(Element))
            {
                CopyDirectory(Element,Dst+Path.GetFileName(Element));
            }
            // Files in directory
            else 
            {
                File.Copy(Element,Dst+Path.GetFileName(Element),true);
            }
        }

    }
}
