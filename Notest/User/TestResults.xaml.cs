﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Notest
{
    /// <summary>
    /// Логика взаимодействия для TestResults.xaml
    /// </summary>
    public partial class TestResults : Window
    {
        public TestResults()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                var completed = from compl in db.CompletedTest select compl;
                List<Class.Completed> completedTests = new List<Class.Completed>();
                foreach (CompletedTest test in completed) // в таблице CompletedTest хранится только Id теста
                {
                    var currentTest = db.Tests.Where(t => t.Id == test.TestId).First(); // поэтому мы берём название и тему из таблицы Tests по Id выполненного теста
                    Class.Completed compl = new Class.Completed
                    {
                        UserLogin = test.UserLogin,
                        TestName = currentTest.Header,
                        TestTheme = currentTest.Topic,
                        Result = test.Result,
                        Date = test.Date
                    };
                    completedTests.Add(compl);
                }
                ResultGrid.ItemsSource = completedTests;
            }
        }
        #region кнопки для окна
        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void HideWindow_Click(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void Fullscreen_Click(object sender, RoutedEventArgs e)
        {
            SystemCommands.MaximizeWindow(this);
            Fullscreen.Visibility = Visibility.Hidden;
            FullscreenExit.Visibility = Visibility.Visible;
        }

        private void FullscreenExit_Click(object sender, RoutedEventArgs e)
        {
            SystemCommands.RestoreWindow(this);
            FullscreenExit.Visibility = Visibility.Hidden;
            Fullscreen.Visibility = Visibility.Visible;
        }
        #endregion
    }
}
