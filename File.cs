
using System.IO;

namespace StarportObjects
{
    public class File
    {
        public File()
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
        /// <param name="fileSize">file size is in bytes just in case you're wondering</param>
        public File(string fileName, string fileExtension, string fileContents, byte[] fileBytes, System.DateTime createdDate, System.DateTime lastUpdated, ulong fileSize, string folderStructure, DirectoryInfo directory)
        {
            this.fileName = fileName;
            this.fileExtension = fileExtension;
            this.fileContents = fileContents;
            this.fileBytes = fileBytes;
            this.createdDate = createdDate;
            this.lastUpdated = lastUpdated;
            this.fileSize = fileSize;
            this.folderStructure = folderStructure;
            this.directory = directory;
        }

        string fileName { get; set; }
        string fileExtension { get; set; }
        string fileContents { get; set; }
        byte[] fileBytes { get; set; }
        System.DateTime createdDate { get; set; }
        System.DateTime lastUpdated { get; set; }
        /// <summary>
        /// File size is in bytes just in casee you're wondering
        /// </summary>
        ulong fileSize { get; set; }
        string folderStructure { get; set; }
        DirectoryInfo directory { get; set; }

    }
}
