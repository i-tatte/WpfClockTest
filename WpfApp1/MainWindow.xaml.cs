﻿using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        /// <summary>
        /// 時刻表示用タイマー
        /// </summary>
        private DispatcherTimer timer;

        public MainWindow() {
            InitializeComponent();
            timer = CreateTimer();
        }

        /// <summary>
        /// タイマー生成処理
        /// </summary>
        /// <returns>生成したタイマー</returns>
        private DispatcherTimer CreateTimer() {
            DispatcherTimer t = new DispatcherTimer(DispatcherPriority.SystemIdle);
            t.Interval = TimeSpan.FromMilliseconds(10);
            t.Tick += (sender, e) => {
                timeIndicator.Text = DateTime.Now.ToString("HH:mm:ss:ff");
            };
            return t;
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e) {
            timer.Start();
        }
    }
}
