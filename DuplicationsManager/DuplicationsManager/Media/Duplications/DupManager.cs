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
            string[] filesPatterns = MediaFileInfo.GetFilesPatterns(dupRequestInfo.MediaType);
            var sortFunc = MediaFileInfo.GetSortFunc(dupRequestInfo.MediaSortType);
            DupMap dupMap = BuildDupMap(dupRequestInfo.CheckedDir, filesPatterns, sortFunc);
            List<DupFiles> dupsFiles = BuildDupList(dupMap);
            return dupsFiles;
        }

        class DupFilesComparer : IComparer<DupFiles>
        {
            public int Compare(DupFiles df1, DupFiles df2)
            {
                var res = df1.DuplicationsFiles.Count.CompareTo(df2.DuplicationsFiles.Count);
                if(res == 0)
                {
                    long dup1Size = new FileInfo(df1.DuplicationsFiles[0]).Length;
                    long dup2Size = new FileInfo(df2.DuplicationsFiles[0]).Length;
                    res = dup1Size.CompareTo(dup2Size);
                }
                return res;   
            }
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

            var dfc = new DupFilesComparer();
            dupsFiles.Sort(dfc);
            dupsFiles.Reverse();

            return dupsFiles;
        }

        // build map of duplications
        private static DupMap BuildDupMap(string folderPath, string[] filesPatterns, Func<string, long> sortByFunc)
        {
            // read files
            string[] allEntries = Directory.GetFileSystemEntries(folderPath, "*.*", SearchOption.AllDirectories);
            List<string> entries = new List<string>();
            foreach (string filePattern in filesPatterns)
            {
                entries.AddRange(allEntries.Where(entry => entry.EndsWith(filePattern)));
            }

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
