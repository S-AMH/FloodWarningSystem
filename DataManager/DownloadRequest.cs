using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    /// <summary>
    /// Download Request Class Creates Download Requests Containing uri, path, authentication and timeLimit.
    /// </summary>
    class DownloadRequest
    {
        private Uri uri = new Uri("");
        private string path = "";
        private Tuple<string, string> authentication = new Tuple<string, string>("","");
        private int timeLimit = -1;

        public Uri Uri { get => uri; set => uri = value; }
        public string Path { get => path; set => path = value; }
        public Tuple<string, string> Authentication { get => authentication; set => authentication = value; }
        public int TimeLimit { get => timeLimit; set => timeLimit = value; }
    }
}
