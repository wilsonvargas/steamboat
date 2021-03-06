﻿using SQLite;
using Steamboat.Components;
using Steamboat.Controllers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Steamboat
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            App.Controller = new MainController();
        }

        public static MainController Controller;

        private static string databaseName = "Accounts.db";
        private static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string databasePath = System.IO.Path.Combine(folderPath, databaseName);
    }
}
