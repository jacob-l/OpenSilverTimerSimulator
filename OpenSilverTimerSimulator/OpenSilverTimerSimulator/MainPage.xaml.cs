using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace OpenSilverTimerSimulator
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Enter construction logic here...
        }

        public void Run(object sender, EventArgs args)
        {
            var dt = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            var startedAt = DateTime.Now;
            dt.Tick += (s,e) => {
                TextBlockOutPut.Text = $"Elapsed - {DateTime.Now - startedAt}. Must be > 1s";
                dt.Stop();
            };
            dt.Start();
            Thread.Sleep(1100);
            dt.Stop();

            startedAt = DateTime.Now;
            dt.Start();
        }
    }
}
