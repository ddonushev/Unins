using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UserLogin
{
    public static class Logger
    {
        private static readonly List<string> CurrentSessionActivities = new List<string>();

        public static void LogActivity(string activity)
        {
            var activityLine = DateTime.Now + ";"
                                            + LoginValidation.CurrentUserUsername + ";"
                                            + LoginValidation.CurrentUserRole + ";"
                                            + activity;
            CurrentSessionActivities.Add(activityLine);
            //Relative path from content root does not appear to work. Absolute path is used. TODO: Fix this so it works with a relative path 
            if (File.Exists("C:\\Users\\Dimitar\\RiderProjects\\UserLogin\\test.txt"))
            {
                Console.WriteLine("test.txt was found");
                File.AppendAllText("C:\\Users\\Dimitar\\RiderProjects\\UserLogin\\test.txt", activityLine);
            }
            else
            {
                Console.WriteLine("test.txt not found");
            }
        }

        public static void SeeLog()
        {
            var sr = new StreamReader("C:\\Users\\Dimitar\\RiderProjects\\UserLogin\\test.txt");
            var sb = new StringBuilder();
            sb.Append(sr.ReadToEnd());
            Console.WriteLine(sb.ToString());
            sr.Close();
        }

        public static void GetCurrentSessionActivities()
        {
            var sb = new StringBuilder();
            foreach (var line in CurrentSessionActivities) sb.Append(line);
            Console.WriteLine(sb.ToString());
        }
    }
}