using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.IO;

namespace StarportObjects
{
    public class FileObj
    {
        public FileObj()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="fileExtension"></param>
        /// <param name="fileContents"></param>
        /// <param name="fileBytes"></param>
        /// <param name="createdDate"></param>
        /// <param name="lastUpdated"></param>
        /// <param name="fileSize">File size is in bytes just in case you're wondering</param>
        public FileObj(string fileName, string fileExtension, string fileContents, byte[] fileBytes, System.DateTime createdDate, System.DateTime lastUpdated, ulong fileSize, string folderStructure, DirectoryInfo directory)
        {
            FileName = fileName;
            FileExtension = fileExtension;
            FileContents = fileContents;
            FileBytes = fileBytes;
            CreatedDate = createdDate;
            LastUpdated = lastUpdated;
            FileSize = fileSize;
            FolderStructure = folderStructure;
            Directory = directory;
        }

        [BsonId]
        public ObjectId Id {
            get; set;
        }

        public string FileName {
            get; set;
        }

        public string FileExtension {
            get; set;
        }

        public string FileContents {
            get; set;
        }

        public byte[] FileBytes {
            get; set;
        }

        public System.DateTime CreatedDate {
            get; set;
        }

        public System.DateTime LastUpdated {
            get; set;
        }

        /// <summary>
        /// File size is in bytes just in case you're wondering
        /// </summary>
        public ulong FileSize {
            get; set;
        }

        public string FolderStructure {
            get; set;
        }

        public DirectoryInfo Directory {
            get; set;
        }
    }
}
