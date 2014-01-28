using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Microsoft.Samples.Kinect.ColorBasics
{
    class SystemMap
    {
        private String winDir = System.Environment.GetEnvironmentVariable("windir");
        private List<String> f = new List<String>();

        private void addListItem(String value) {
            this.f.Add(value);
        }

        public List<String> getSubContent(String path){
            String[] directories = null;
            String[] files = null;
            List<String> content = new List<String>();
            if (!path.Contains("."))
            {
                try
                {

                    directories = Directory.GetDirectories(path);
                    files = Directory.GetFiles(path);

                    foreach (String directory in directories)
                    {
                        string[] pathFragments = directory.Split('\\');
                        String name = pathFragments.Last() + '\\';
                        content.Add(name);
                    }
                    foreach (String file in files)
                    {
                        string[] pathFragments = file.Split('\\');
                        String name = pathFragments.Last();
                        content.Add(name);
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                    return content;
                }
                catch (System.UnauthorizedAccessException ex)
                {
                    Console.WriteLine(ex.Message);
                    return content;
                }
            }
            else
            {
                //content.Add("NOT FOUND");
            }
            /*else if (File.Exists(path))
            {
                
                files = Directory.GetFiles(path);
                foreach (String file in files)
                {
                    string[] pathFragments = file.Split('\\');
                    String name = pathFragments.Last();
                    content.Add(name);
                }
                
            }*/

            return content;
 
        }

        public SystemMap(){
            string[] drives = Directory.GetLogicalDrives();
            foreach (String drive in drives)
            {
                addListItem(drive);
            }

        }

        public List<String> getLocals()
        {
            List<String> sss = new List<String>();
            foreach(String fi in f){
                
                sss.Add(fi);

            }
            return sss;
        }
    }
}
