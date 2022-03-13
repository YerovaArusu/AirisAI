using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Airis {
    class Methods {
        public Dictionary<string, string> programmList() {
            Dictionary<string, string> programStarts = new Dictionary<string, string>();
            /*
             * First value is the Name
             * 
             * Second value is the directory, where the to the executable file 
             * 
            */
            foreach (string line in File.ReadAllLines(Environment.CurrentDirectory + "/resources/Programms.txt")) {
                string [] tmp = line.Split('|');
                programStarts.Add(tmp[0], tmp[1]);
            }
            return programStarts;
        }
    }
}
