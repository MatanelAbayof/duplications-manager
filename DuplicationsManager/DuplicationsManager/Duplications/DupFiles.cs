using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicationsManager.Duplications
{
    public class DupFiles
    {
        private List<string> duplicationsFiles = new List<string>();
        public List<string> DuplicationsFiles
        {
            get
            {
                return duplicationsFiles;
            }
            set
            {
                duplicationsFiles = value;
            }
        }
    }
}
