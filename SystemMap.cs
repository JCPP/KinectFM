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

            String[] directories = Directory.GetDirectories(path);
            String[] files = Directory.GetFiles(path);
            List<String> content = new List<String>();
            foreach (String directory in directories)
            {
                content.Add(directory);
            }
            foreach (String file in files)
            {
                content.Add(file);
            }

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
