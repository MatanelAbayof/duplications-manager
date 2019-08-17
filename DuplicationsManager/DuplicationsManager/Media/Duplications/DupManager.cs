using DuplicationsManager.Media.Duplications;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DupMap = System.Collections.Generic.SortedDictionary<long, System.Collections.Generic.LinkedList<string>>;

namespace DuplicationsManager.Duplications
{
    abstract class DupManager
    {
        // check duplication of files at folder
        public static List<DupFiles> CheckDup(DupRequestInfo dupRequestInfo)
        {
            string filesPattern = MediaFileInfo.GetFilesPattern(dupRequestInfo.MediaType);
            var sortFunc = MediaFileInfo.GetSortFunc(dupRequestInfo.MediaSortType);
            DupMap dupMap = BuildDupMap(dupRequestInfo.CheckedDir, filesPattern, sortFunc);
            List<DupFiles> dupsFiles = BuildDupList(dupMap);
            return dupsFiles;
        }

        // build list of dup files
        private static List<DupFiles> BuildDupList(DupMap dupMap)
        {
            List<DupFiles> dupsFiles = new List<DupFiles>();
            foreach (long key in dupMap.Keys)
            {
                LinkedList<string> linkedList = dupMap[key];
                if(linkedList.Count > 1)
                {
                    DupFiles dupFiles = new DupFiles();
                    foreach (string entry in linkedList)
                        dupFiles.DuplicationsFiles.Add(entry);
                    dupsFiles.Add(dupFiles);
                }
            }
            return dupsFiles;
        }

        // build map of duplications
        private static DupMap BuildDupMap(string folderPath, string filesPattern, Func<string, long> sortByFunc)
        {
            // read files
            string[] entries = Directory.GetFileSystemEntries(folderPath, filesPattern, SearchOption.AllDirectories);

            // build map
            DupMap dupMap = new DupMap();
            foreach (string entry in entries)
            {
                long key = sortByFunc(entry);

                if (dupMap.ContainsKey(key))
                {
                    dupMap[key].AddFirst(entry);
                }
                else
                {
                    LinkedList<string> linkedList = new LinkedList<string>();
                    linkedList.AddFirst(entry);
                    dupMap[key] = linkedList;
                }
            }

            return dupMap;
        }
    }
}
