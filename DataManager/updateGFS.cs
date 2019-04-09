using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleLogger;
using System.IO;

namespace DataManager
{
    class updateGFS
    {
        private static bool upload(string _date, string _run, string _var)
        { 
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = @"cmd.exe";
            process.StartInfo.Arguments = @"/C" + " " + "python" + " ";
            if (_var == "APCP")
                process.StartInfo.Arguments += Resource.GFSUploadApcp + " " + _date + _run;
            else if (_var == "RAIN")
                process.StartInfo.Arguments += Resource.GFSUploadRain + " " + _date + _run;
            else
                throw new ArgumentException("Invalid Argument passed.", "_var");

            bool result = process.Start();
            process.WaitForExit();
            return result;
        }
        private static bool publish(string _var)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = @"cmd.exe";
            process.StartInfo.Arguments = @"/C" + " " + "python" + " ";
            if (_var == "APCP")
                process.StartInfo.Arguments += Resource.GFSPublishApcp;
            else if (_var == "RAIN")
                process.StartInfo.Arguments += Resource.GFSPublishRain;
            else
                throw new ArgumentException("Invalid Argument passed.", "_var");

            bool result = process.Start();
            process.WaitForExit();
            return result;
        }
        private static Queue<string> readDB()
        {
            string[] runs = { "00", "06", "12", "18" };
            Queue<string> content = new Queue<string>();
            Queue<string> result = new Queue<string>();
            StreamReader objReader = new StreamReader(Resource.GFSRuns);
            while (objReader.Peek() != -1)
                content.Enqueue(objReader.ReadLine());
            foreach (var c in content)
                for (int i = 0; i < Convert.ToInt32(c.Last()) - 1; i++)
                    result.Enqueue(c.Substring(0, c.Length - 1) + "-" + runs[i]);
            return result;
        }
        private static Queue<string> downloadQuery()
        {
            throw new NotImplementedException("This Feature is not Implemented yet.");
        }
        public static bool update()
        {
            throw new NotImplementedException("This Feature is not Implemented yet.");
        }

    }
}
