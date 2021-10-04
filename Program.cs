﻿using System;
using System.IO;
using NLog.Web;
using System.Collections.Generic;

namespace MediaLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("");

            //////////////////////////////
            //      NLOG Instantiation  //
            //////////////////////////////

            string path = Directory.GetCurrentDirectory() + "\\nlog.config";

            // create instance of Logger
            var logger = NLog.Web.NLogBuilder.ConfigureNLog(path).GetCurrentClassLogger();

            logger.Info("NLOG Loaded");
            

            Movie movie = new Movie
            {
                mediaId = 123,
                title = "Greatest Movie Ever, The (2020)",
                director = "Jeff Grissom",
                // timespan (hours, minutes, seconds)
                runningTime = new TimeSpan(2, 21, 23),
                genres = { "Comedy", "Romance" }
            };

            Console.WriteLine(movie.Display());
            
        }
    }
}