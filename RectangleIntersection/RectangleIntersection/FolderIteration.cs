using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Geometry
{
    public class FolderIteration
    {

        public void PrintFileName()
        {
            //input folder
            string Folder = Console.ReadLine();

            //Iterate through the parent folder
            if (Directory.Exists(Folder))
            {
                Print(Folder);

                var subDir = Directory.GetDirectories(Folder);

                foreach(var dir in subDir)
                {
                    Print(dir);
                }
            }        
        }

        private void Print(string fileShare)
        {
            var subfolder = Directory.GetFiles(fileShare.ToString());

            for(int i=0; i < subfolder.Length; i++)
            {
                Console.WriteLine(subfolder[i]);
            }
        }

    }
}
