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
        internal static class WindowSettings
        {
            public static CLForm form;

            static WindowSettings()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                form = new CLForm();
                UpdateWindowSettings();
            }

            public static void UpdateWindowSettings()
            {
                var file = new List<string>(File.ReadAllLines("SettingsData.csv"));
                form.Movable = bool.Parse(file[1]);
            }

            public static void start()
            {
                Application.Run(form);
            }
        }

        public Settings()
        {
            InitializeComponent();
            WindowSettings.UpdateWindowSettings();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            var file = new List<string>(File.ReadAllLines("SettingsData.csv"));
            TotalItemsCount.Text = file[0].ToString();
            AllowDragWindow.Checked = bool.Parse(file[1]);
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText("SettingsData.csv", TotalItemsCount.Text + '\n' + AllowDragWindow.Checked.ToString() + '\n');
            WindowSettings.UpdateWindowSettings();
        }
    }
}
