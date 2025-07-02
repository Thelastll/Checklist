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
using static Checklist.Settings;

namespace Checklist
{
    public partial class HistoryForm : MetroFramework.Forms.MetroForm
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            int day = 0;
            for (int i = 1; i < UploadedFiles.GetRecentTasks().Count; i++)
            {
                day++;
                if (day == 1)
                {
                    history.Items.Add(day.ToString() + " День назад:");
                }
                else if (day >= 2 && day <= 4)
                {
                    history.Items.Add(day.ToString() + " Дня назад:");
                } 
                else
                {
                    history.Items.Add(day.ToString() + " Дней назад:");
                }

                    for (int j = 0; j < int.Parse(UploadedFiles.GetRecentTasks()[i].Split(';')[0]); j++)
                    {
                        history.Items.Add("      " + UploadedFiles.GetRecentTasks()[i].Split(';')[j + 1]);
                    }
            }
        }
    }
}
