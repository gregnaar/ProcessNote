using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessNoteHelper
{
    
    public class ProcessTask
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string RamUsage { get; set; }
        public string Comment { get; set; }

        public ProcessTask(string name, int id, string ramUsage)
        {
            this.Name = name;
            this.ID = id;
            this.RamUsage = ramUsage;
            this.Comment = "";

        }
        public override string ToString()
        {
            return string.Format(" {0} \t {1} MB \t {2} {3}", this.ID, this.RamUsage, this.Name, this.Comment);
        }

    }
}
