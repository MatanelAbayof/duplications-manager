using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DuplicationsManager.Duplications.MediaFileInfo;

namespace DuplicationsManager.Media.Duplications
{
    public class DupRequestInfo
    {
        public string CheckedDir { get; set; }
        public MediaType MediaType { get; set; }
        public MediaSortType MediaSortType { get; set; }
    }
}
