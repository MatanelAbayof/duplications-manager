using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace DuplicationsManager.Duplications
{
    public class MediaFileInfo
    {
        public enum MediaType { VIDEO, MUSIC }

        public enum MediaSortType { BY_DURATION, BY_SIZE } // TODO add: BY_NAME

        private MediaFileInfo() { }

        // get media sort type info 
        public static string GetMediaSortTypeInfo(MediaSortType mediaSortType)
        {
            switch (mediaSortType)
            {
                case MediaSortType.BY_DURATION:
                    return "By duration";
                case MediaSortType.BY_SIZE:
                    return "By size";
                default:
                    throw new Exception("Cannot detect media type info of mediaSortType=" + mediaSortType);
            }
        }

        // get media type info
        public static string GetMediaTypeInfo(MediaType mediaType)
        {
            switch (mediaType)
            {
                case MediaType.VIDEO:
                    return "Video";
                case MediaType.MUSIC:
                    return "Music";
                default:
                    throw new Exception("Cannot detect file pattern of mediaType=" + mediaType);
            }
        }

        // get file pattern of media type
        public static string[] GetFilesPatterns(MediaType mediaType) {
            switch (mediaType)
            {
                case MediaType.VIDEO:
                    return new string[] { ".mp4", ".wmv" };
                case MediaType.MUSIC:
                    return new string[] { ".mp3" };
                default:
                    throw new Exception("Cannot detect file pattern of mediaType=" + mediaType);
            }
        }

        // get sort function from media sort type
        public static Func<string, long> GetSortFunc(MediaSortType mediaSortType)
        {
            switch (mediaSortType)
            {
                case MediaSortType.BY_DURATION:
                    return filePath => (long) new WindowsMediaPlayer().newMedia(filePath).duration; // TODO need elegant convert!!
                case MediaSortType.BY_SIZE:
                    return filePath => new FileInfo(filePath).Length;
                default:
                    throw new Exception("Cannot detect sort function of mediaSortType=" + mediaSortType);
            }
        }
    }
}