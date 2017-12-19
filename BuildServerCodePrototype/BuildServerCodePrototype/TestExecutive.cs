//////////////////////////////////////////////////////////////////////////////////
// TestExecutive.cs - demonstration code prototype                           /////
// Language:    C++, Visual Studio 2015                                     //////
// Platform:    Dell XPS 8900, Windows 7                                    //////
// Application: Project #1, CSE681 Software Modeling and Analysis, Fall 2017 //////
// Author:      RamaTeja Repaka, Syracuse University, CST 4-187             //////
//              rrepaka@syr.edu                                             //////
//////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;
using Microsoft.Build;
using Microsoft.Build.Utilities;
using Microsoft.Build.BuildEngine;
using Microsoft.Build.Evaluation;
using System.IO;
using Microsoft.Build.Execution;


namespace BuildServerCodePrototype 
{
    //-----------------------< Extending prototype Interface which uses MSBUILd library to build visual studio solution files-------------------->
    class TestExecutive : Prototype
    {

        //--------------------<method which takes project file as an input and starts building all the projects>------------------------------
        public  void buildproject()
        {

            /*  project file contains the test solution file path
             *  In order to test solution please change in the build.proj
             */

            string projectfilePath = "..//..//..//build.proj"; //relative path of the project file

            List<ILogger> loggers = new List<ILogger>(); // list of loggers

            FileLogger fileLogger = new FileLogger(); // used for creating a log file 

            fileLogger.Parameters = @"logfile=" + @"..//..//..//log.txt"; //giving path of a log file

            loggers.Add(new ConsoleLogger()); //adding a console logger to display messages

            loggers.Add(fileLogger); // adding file logger to store logs in log file

            var projectCollection = new ProjectCollection();

            projectCollection.RegisterLoggers(loggers); // registering a logger

            var project = projectCollection.LoadProject(projectfilePath); // Needs a reference to build.proj
            try
            {
                project.Build();
            }
            finally
            {
                projectCollection.UnregisterAllLoggers(); // finally unregistering the loggers
            }

        }


        //-----------<driver code>---------------------
        static void Main(string[] args)
        {

            TestExecutive exectutive= new TestExecutive();

            exectutive.buildproject();

        }


    }
}
