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
        private int timeLimit = -1;
        //<username, password> -> username:password
        private Tuple<string, string> authentication = new Tuple<string, string>("","");

        /// <summary>
        /// Creates DownloadRequest object with specific download address and path, no authentication is used and timeLimit is set to its maximum (approximately 25 days)
        /// </summary>
        /// <param name="uri"> file address in network/internter(url)</param>
        /// <param name="path"> local path to save downloaded file from network/internet </param>
        public DownloadRequest(Uri uri, string path)
        {
            this.uri = uri;
            this.path = path;
            this.timeLimit = int.MaxValue;
        }

        /// <summary>
        /// Creates DownloadRequest object with specific download address, path and time limit(Millisecond), no authentication is used.
        /// </summary>
        /// <param name="uri">file address in network/internter(url)</param>
        /// <param name="path">local path to save downloaded file from network/internet</param>
        /// <param name="timeLimit">unsigned integer value, represented allowed time for file to download in Millisecond</param>
        public DownloadRequest(Uri uri, string path, int timeLimit)
        {
            this.uri = uri;
            this.path = path;
            if (timeLimit > 0)
                this.timeLimit = timeLimit;
            else
                throw new ArgumentException("timeLimit should be only unsigned integers and positive values.", "timeLimit");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="path"></param>
        /// <param name="authentication"></param>
        public DownloadRequest(Uri uri, string path, Tuple<string, string> authentication)
        {
            this.uri = uri;
            this.path = path;
            this.authentication = authentication;
            this.timeLimit = int.MaxValue;
        }

        public DownloadRequest(Uri uri, string path, Tuple<string, string> authentication, int timeLimit)
        {
            this.uri = uri;
            this.path = path;
            this.authentication = authentication;
            if (timeLimit > 0)
                this.timeLimit = timeLimit;
            else
                throw new ArgumentException("timeLimit should be only unsigned integers and positive values.", "timeLimit");
        }

        public Uri Uri { get => uri; set => uri = value; }
        public string Path { get => path; set => path = value; }
        public Tuple<string, string> Authentication { get => authentication; set => authentication = value; }
        public int TimeLimit { get => timeLimit; set => timeLimit = value; }
    }
}
