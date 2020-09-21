using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderDetails
{
    public class Obj
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public List<Obj> Children { get; set; }

        public void SubDirectories()
        {
            string[] subdirectoryEntries = { };
            try
            {
                subdirectoryEntries = Directory.GetDirectories(Path, "*.", SearchOption.TopDirectoryOnly);
            }
            catch (Exception)
            {
            }
            foreach (string s in subdirectoryEntries)
            {
                string[] pathSplit = s.Split('\\');
                Children.Add(new Obj(pathSplit[pathSplit.Length - 1], s));
                Children[Children.Count - 1].SubDirectories();
            }
        }

        public Obj(string name, string path)
        {
            Name = name;
            Path = path;
            Children = new List<Obj>();
        }
    }
}
