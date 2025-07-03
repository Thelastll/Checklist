using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Checklist
{
    public partial class Settings : MetroFramework.Forms.MetroForm
    {
        internal static class Window
        {
            public static CLForm form;

            static Window()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                form = new CLForm();
                UpdateWindowSettings();
            }

            public static void UpdateWindowSettings()
            {
                form.Movable = bool.Parse(UploadedFiles.GetSettings()[1]);
            }

            public static void start()
            {
                Application.Run(form);
            }
        }

        internal static class UploadedFiles
        {
            enum FileNames
            {
                Date = 0,
                List,
                RecentTasks,
                Settings
            }

            static List<List<string>> files = new List<List<string>>();
            static UploadedFiles()
            {
                CheckForFiles();
                files.Add(new List<string>(File.ReadAllLines("DateData.csv")));
                files.Add(new List<string>(File.ReadAllLines("ListData.csv")));
                files.Add(new List<string>(File.ReadAllLines("RecentTasksData.csv")));
                files.Add(new List<string>(File.ReadAllLines("SettingsData.csv")));
            }

            public static void CheckForFiles()
            {
                if (!File.Exists("DateData.csv"))
                    File.AppendAllText("DateData.csv", DateTime.Now.Day.ToString() + '-' + DateTime.Now.Month.ToString() + '-' + DateTime.Now.Year.ToString() +
                        '\n' + DateTime.Now.Add(TimeSpan.FromDays(-1)).Day.ToString() + '-' + DateTime.Now.Add(TimeSpan.FromDays(-1)).Month.ToString() +
                        '-' + DateTime.Now.Add(TimeSpan.FromDays(-1)).Year.ToString() + '\n');

                if (!File.Exists("ListData.csv"))
                    File.AppendAllText("ListData.csv", "");

                if (!File.Exists("RecentTasksData.csv"))
                    File.AppendAllText("RecentTasksData.csv", DateTime.Now.Date.Day.ToString() + '-' + DateTime.Now.Date.Month.ToString() + '-' +
                        DateTime.Now.Date.Year.ToString() + "\n0\n0\n0\n0\n0\n0\n0\n0\n0\n0\n");

                if (!File.Exists("SettingsData.csv"))
                    File.AppendAllText("SettingsData.csv", "1\nTrue\n");
            }

            public static void SetDate(List<string> newfile)
            {
                if (newfile != null)
                {
                    files[(int)FileNames.Date] = newfile;
                }
            }
            public static List<string> GetDate()
            {
                return files[(int)FileNames.Date];
            }

            public static void SetList(List<string> newfile)
            {
                if (newfile != null)
                {
                    files[(int)FileNames.List] = newfile;
                }
            }
            public static List<string> GetList()
            {
                return files[(int)FileNames.List];
            }

            public static void SetRecentTasks(List<string> newfile)
            {
                if (newfile != null)
                {
                    files[(int)FileNames.RecentTasks] = newfile;
                }
            }
            public static List<string> GetRecentTasks()
            {
                return files[(int)FileNames.RecentTasks];
            }

            public static void SetSettings(List<string> newfile)
            {
                if (newfile != null)
                {
                    files[(int)FileNames.Settings] = newfile;
                }
            }
            public static List<string> GetSettings()
            {
                return files[(int)FileNames.Settings];
            }
        }

        public Settings()
        {
            InitializeComponent();
            Window.UpdateWindowSettings();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            TotalItemsCount.Text = UploadedFiles.GetSettings()[0].ToString();
            AllowDragWindow.Checked = bool.Parse(UploadedFiles.GetSettings()[1]);
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText("SettingsData.csv", TotalItemsCount.Text + '\n' + AllowDragWindow.Checked.ToString() + '\n');
            var SettingsData = new List<string>() { "", "" };

            SettingsData[0] = TotalItemsCount.Text + '\n';
            SettingsData[1] = AllowDragWindow.Checked.ToString() + '\n';

            UploadedFiles.SetSettings(SettingsData);

            Window.UpdateWindowSettings();
        }
    }
}