using System;
using System.IO;

class PathHelper
{
    /*
    
    */
    public static void replaceAllfileName(string path, string oldPattern, string newPattern, bool recurse)
    {
        if (!Directory.Exists(path))
        {
            throw new Exception("Folder is not exist!");
        }
        var filepaths = Directory.GetFiles(path);
        foreach (var item in filepaths)
        {
            if (item.EndsWith(oldPattern))
            {
                var newpath = item.Replace(oldPattern, newPattern);
                new FileInfo(item).MoveTo(newpath);
                Console.WriteLine(newpath);
            }
            
        }
        if (recurse)
        {
            var paths = Directory.GetDirectories(path);
            foreach (var item in paths)
            {
                replaceAllfileName(item, oldPattern, newPattern, recurse);
            }
        }


    }

}