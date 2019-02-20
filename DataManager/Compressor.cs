using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataManager
{
    partial class Compressor
    {
        private enum compressorEngine { GZipStream, DeflateStream }

    }
    partial class Compressor
    {
        private List<FileInfo> targetFiles = new List<FileInfo>();
        private List<DirectoryInfo> targetDirectories = new List<DirectoryInfo>();
        private string destination = "";
    }
}


