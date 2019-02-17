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

namespace DataManager
{
    class Program
    {
        static void Main(string[] args)
        {

            Gdal.AllRegister();
            Ogr.RegisterAll();
            GdalConfiguration.ConfigureGdal();
            GdalConfiguration.ConfigureOgr();
            Gdal.SetErrorHandler("CPLQuietErrorHandler"); // Set Quiet Error Handler to prevent Gdal Warnings from displaying in command line. 
        }
    }
}
