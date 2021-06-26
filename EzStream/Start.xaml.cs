﻿using EzStream;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Net;
using AutoUpdaterDotNET;
using System.Reflection;

namespace EzStreaming
{
    /// <summary>
    /// Lógica de interacción para Start.xaml
    /// </summary>
    public partial class Start : Window{
        public Start(){
            //MessageBox.Show(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            string dir = System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            if (!Directory.Exists(dir + "/Data")){
                Directory.CreateDirectory(dir + "/Data");
                Directory.CreateDirectory(dir + "/Data/Video");
                Directory.CreateDirectory(dir + "/Data/Audio");
                Directory.CreateDirectory(dir + "/Data/Channels");
                File.Create(dir + "/Data/Channels.txt").Dispose();
            }
            if (!Directory.Exists(dir + "/Data/Channels"))
                Directory.CreateDirectory(dir + "/Data/Channels");
            if (!File.Exists(dir + "/Data/ffmpeg.exe"))
                using (WebClient wc = new WebClient()) { 
                    wc.DownloadFileAsync(new Uri("https://github.com/YouAreMyTrap/EzStreamig/raw/main/ffmpeg.exe"), dir + "/Data/ffmpeg.exe");
                    wc.DownloadFileAsync(new Uri("https://github.com/YouAreMyTrap/EzStreamig/raw/main/youtube-dl"), dir + "/Data/youtube-dl.exe");
                }

            AutoUpdater.Start("https://github.com/YouAreMyTrap/EzStreamig/raw/main/update.xml");
            MainWindow win2 = new MainWindow();
            win2.Show();
            this.Close();

        }
    }
}
