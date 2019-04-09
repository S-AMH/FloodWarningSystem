/*
 * 
 * @Author: S.AmirMohammad Hasanli <amir.hasanli@ut.ac.ir>
 * @Company: Iran's Water Research Institute <www.wri.ac.ir>
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSGeo.GDAL;
using OSGeo.OGR;
using OSGeo.OSR;
using SimpleLogger;
using System.IO;

namespace DataManager
{
    class Program
    {
        static void Main(string[] args)
        {
            GdalConfiguration.ConfigureGdal();
            GdalConfiguration.ConfigureOgr();
            Gdal.AllRegister();
            Ogr.RegisterAll();
            Gdal.SetErrorHandler("CPLQuietErrorHandler");
            Gdal.PushErrorHandler("CPLQuietErrorHandler");
            
            // Start Logger. DataManager_yyyy-MM-dd.log
            SimpleLog.SetLogFile(logDir: Path.Combine(Resource.DB, "Logs", "DataManager"),
                prefix: "DataManager_", dateFormat: "yyyy-MM-dd", writeText: false);


        }

    }
}
