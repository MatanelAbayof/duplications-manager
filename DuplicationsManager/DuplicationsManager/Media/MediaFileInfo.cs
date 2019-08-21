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

        public enum MediaSortType { BY_DURTION, BY_SIZE } // TODO add: BY_NAME

        private MediaFileInfo() { }

        // get media type as string
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
        public static string GetFilesPattern(MediaType mediaType) {
            switch (mediaType)
            {
                case MediaType.VIDEO:
                    return "*.mp4";
                case MediaType.MUSIC:
                    return "*.mp3";
                default:
                    throw new Exception("Cannot detect file pattern of mediaType=" + mediaType);
            }
        }

        // get sort function from media sort type
        public static Func<string, long> GetSortFunc(MediaSortType mediaSortType)
        {
            switch (mediaSortType)
            {
                case MediaSortType.BY_DURTION:
                    return filePath => (long) new WindowsMediaPlayer().newMedia(filePath).duration; // TODO need elegant convert!!
                case MediaSortType.BY_SIZE:
                    return filePath => new FileInfo(filePath).Length;
                default:
                    throw new Exception("Cannot detect sort function of mediaSortType=" + mediaSortType);
            }
        }
    }
}