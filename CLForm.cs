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
using static Checklist.Settings;

namespace Checklist
{
    public partial class CLForm : MetroFramework.Forms.MetroForm
    {
        Graphics g;
        Pen border;
        Pen pen;
        public CLForm()
        {
            InitializeComponent();
        }

        private void CLForm_Load(object sender, EventArgs e)
        {
            g = GraphicPanel.CreateGraphics();
            border = new Pen(Color.Black, 4);
            pen = new Pen(Color.Black, 2);

            UpdateDateData(EverySecond: true);   
            UpdateStreak();
            UpdateEndTime();
            ShiftRecentTasksData();
            UpdateDayList();
            UpdateGraphic();
        }
        
        private void UpdateListData()
        {
            File.WriteAllText("ListData.csv", "");
            var ListData = new List<string>();
            for (int i = 0; i < daylist.Items.Count; i++)
            {
                File.AppendAllText("ListData.csv", daylist.Items[i].ToString() + ';' + daylist.GetItemChecked(i).ToString() + '\n');
                ListData.Add(daylist.Items[i].ToString() + ';' + daylist.GetItemChecked(i).ToString() + '\n');
            }
            UploadedFiles.SetList(ListData);
        }

        private void UpdateDayList()
        {
            daylist.Items.Clear();
            for (int i = 0; i < UploadedFiles.GetList().Count; i++)
            {
                daylist.Items.Add(UploadedFiles.GetList()[i].Split(';')[0]);
                daylist.SetItemChecked(i, bool.Parse(UploadedFiles.GetList()[i].Split(';')[1]));
            }
        }

        private void UpdateDateData(bool EverySecond = false)
        {
            var DateData = UploadedFiles.GetDate();
            if (EverySecond)
            {
                var timenow = DateTime.Now;
                if ((DateTime.Now.Date - DateTime.Parse(UploadedFiles.GetDate()[1]).Date).TotalDays >= 2)
                {
                    File.WriteAllText("DateData.csv", timenow.Day.ToString() +
                    '-' + timenow.Month.ToString() +
                    '-' + timenow.Year.ToString() + '\n' +
                    timenow.Add(TimeSpan.FromDays(-1)).Day.ToString() + '-' + timenow.Add(TimeSpan.FromDays(-1)).Month.ToString() + 
                    '-' + timenow.Add(TimeSpan.FromDays(-1)).Year.ToString() + '\n');

                    DateData[0] = timenow.Day.ToString() + '-' + timenow.Month.ToString() + '-' + timenow.Year.ToString() + '\n';

                    DateData[1] = timenow.Add(TimeSpan.FromDays(-1)).Day.ToString() + '-' + timenow.Add(TimeSpan.FromDays(-1)).Month.ToString() +
                    '-' + timenow.Add(TimeSpan.FromDays(-1)).Year.ToString() + '\n';
                }
            }
            else
            {
                if ((DateTime.Now.Date - DateTime.Parse(UploadedFiles.GetDate()[1]).Date).TotalDays < 2)
                {
                    File.WriteAllText("DateData.csv", DateTime.Parse(UploadedFiles.GetDate()[0]).Day.ToString() +
                    '-' + DateTime.Parse(UploadedFiles.GetDate()[0]).Month.ToString() +
                    '-' + DateTime.Parse(UploadedFiles.GetDate()[0]).Year.ToString() + '\n' +
                    DateTime.Now.Day.ToString() + '-' + DateTime.Now.Month.ToString() + '-' + DateTime.Now.Year.ToString() + '\n');

                    DateData[0] = DateTime.Parse(UploadedFiles.GetDate()[0]).Day.ToString() +
                    '-' + DateTime.Parse(UploadedFiles.GetDate()[0]).Month.ToString() +
                    '-' + DateTime.Parse(UploadedFiles.GetDate()[0]).Year.ToString() + '\n';

                    DateData[1] = DateTime.Now.Day.ToString() + '-' + DateTime.Now.Month.ToString() + '-' + DateTime.Now.Year.ToString() + '\n';
                }
                else if ((DateTime.Now.Date - DateTime.Parse(UploadedFiles.GetDate()[1]).Date).TotalDays >= 2)
                {
                    File.WriteAllText("DateData.csv", DateTime.Now.Day.ToString() +
                    '-' + DateTime.Now.Month.ToString() +
                    '-' + DateTime.Now.Year.ToString() + '\n' +
                    DateTime.Now.Day.ToString() + '-' + DateTime.Now.Month.ToString() + '-' + DateTime.Now.Year.ToString() + '\n');

                    DateData[0] = DateTime.Now.Day.ToString() +
                    '-' + DateTime.Now.Month.ToString() +
                    '-' + DateTime.Now.Year.ToString() + '\n';

                    DateData[1] = DateTime.Now.Day.ToString() + '-' + DateTime.Now.Month.ToString() + '-' + DateTime.Now.Year.ToString() + '\n';
                }
            }
            UploadedFiles.SetDate(DateData);
        }

        private void UpdateRecentTasksData()
        {
            File.WriteAllText("RecentTasksData.csv", "");
            for (int i = 0; i < UploadedFiles.GetRecentTasks().Count; i++)
            {
                File.AppendAllText("RecentTasksData.csv", UploadedFiles.GetRecentTasks()[i] + '\n');
            }
        }

        private void AddRecentTasks(string line)
        {
            var RecentTasksfile = UploadedFiles.GetRecentTasks();
            RecentTasksfile[1] += ";" + line;
            var temporary = RecentTasksfile[1].Split(';');
            temporary[0] = (int.Parse(temporary[0]) + 1).ToString();
            RecentTasksfile[1] = string.Join(";", temporary);
            UploadedFiles.SetRecentTasks(RecentTasksfile);
            UpdateRecentTasksData();
        }

        private void ShiftRecentTasksData()
        {
            
            if (DateTime.Now.Date != DateTime.Parse(UploadedFiles.GetRecentTasks()[0]).Date) 
            {
                var RecentTasksfile = UploadedFiles.GetRecentTasks();
                for (int i = 0; i < (DateTime.Now.Date - DateTime.Parse(RecentTasksfile[0]).Date).TotalDays; i++)
                {
                    for (int j = RecentTasksfile.Count-1; j > 0; j--)
                    {
                        RecentTasksfile[j] = RecentTasksfile[j - 1];
                    }
                    RecentTasksfile[1] = "0";
                }
                RecentTasksfile[0] = DateTime.Now.Date.Day.ToString() + '-' + DateTime.Now.Date.Month.ToString() + '-' + DateTime.Now.Date.Year.ToString();
                UploadedFiles.SetRecentTasks(RecentTasksfile);
                UpdateRecentTasksData();
            }
        }

        private void UpdateStreak()
        {
            Streak.Text = ((DateTime.Parse(UploadedFiles.GetDate()[1]).Date - DateTime.Parse(UploadedFiles.GetDate()[0]).Date).TotalDays + 1).ToString();
            if (int.Parse(Streak.Text) < 0)
            {
                Streak.Text = "0";
            }
        }

        private void UpdateEndTime()
        {
            var time = DateTime.Parse(UploadedFiles.GetDate()[1]).Add(TimeSpan.FromDays(2)) - DateTime.Now;

            if (DateTime.Now.Date == DateTime.Parse(UploadedFiles.GetDate()[1]).Date)
            {
                EndTime.Text = "Всё завершено";
            }
            else if ((DateTime.Now.Date - DateTime.Parse(UploadedFiles.GetDate()[1]).Date).TotalDays == 1 && 
                      DateTime.Parse(UploadedFiles.GetDate()[1]).Date >= DateTime.Parse(UploadedFiles.GetDate()[0]).Date)
            {
                EndTime.Text = time.Hours.ToString() + ':' + time.Minutes.ToString() + ':' + time.Seconds.ToString();
            }
            else
            {
                EndTime.Text = "----------";
            }
        }

        private void UpdateGraphic()
        {
            g.DrawLine(border, 38, 224, GraphicPanel.Width, 224); //горизонтальная
            g.DrawLine(border, 40, 224, 40, 15); //вертикальная

           
            var TasksCountList = new List<int>();
            var LabelsValueList = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

            for (int i = 1; i < UploadedFiles.GetRecentTasks().Count ; i++)
            {
                TasksCountList.Add(int.Parse(UploadedFiles.GetRecentTasks()[i].Split(';')[0]));
            }


            LabelsValueList[9] = (int)(Math.Ceiling(TasksCountList.Max()/10.0)*10.0);
            int num = (int)Math.Round((LabelsValueList[9] - Math.Max(LabelsValueList[0], 1)) / 9.0);
            for (int i = 0; i < 9; i++)
            {
                LabelsValueList[i] = LabelsValueList.Max() / 10 * (i+1);
            }

            for (int i = 0; i < 10; i++)
            {
                g.DrawRectangle(border, 40+i*40, 224 - (float)TasksCountList[i] / LabelsValueList[9] * 200, 40, (float)TasksCountList[i] / LabelsValueList[9] * 200);
            }

            Label1.Text = LabelsValueList[0].ToString();
            Label2.Text = LabelsValueList[1].ToString();
            Label3.Text = LabelsValueList[2].ToString();
            Label4.Text = LabelsValueList[3].ToString();
            Label5.Text = LabelsValueList[4].ToString();
            Label6.Text = LabelsValueList[5].ToString();
            Label7.Text = LabelsValueList[6].ToString();
            Label8.Text = LabelsValueList[7].ToString();
            Label9.Text = LabelsValueList[8].ToString();
            Label10.Text = LabelsValueList[9].ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddLine.Text.Trim() != "") 
            {
                daylist.Items.Add(AddLine.Text.Trim().Replace(";", ""));
                AddLine.Text = "";
                UpdateListData(); 
            }
            daylist.SelectedIndex = -1;
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (daylist.SelectedItems.Count > 0)
            {
                daylist.Items.RemoveAt(daylist.SelectedIndex);
                UpdateListData();
            }
            daylist.SelectedIndex = -1;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateListData();
            CheckListData();
            daylist.SelectedIndex = -1;
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            if (daylist.SelectedItems.Count > 0 && AddLine.Text.Trim() != "")
            {
                daylist.Items[daylist.SelectedIndex] = AddLine.Text.Trim();
                AddLine.Text = "";
                UpdateListData();
            }
            daylist.SelectedIndex = -1;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            daylist.SelectedIndex = -1;
            var settings = new Settings();
            settings.ShowDialog();
        }

        private void CheckHistory_Click(object sender, EventArgs e)
        {
            daylist.SelectedIndex = -1;
            ShiftRecentTasksData();
            var history = new HistoryForm();
            history.ShowDialog();
        }

        private void UpdateStreakTimer_Tick(object sender, EventArgs e)
        {
            UpdateStreak();
            UpdateEndTime();
            UpdateDateData(EverySecond: true);
        }

        private void UpdateGraphicTimer_Tick(object sender, EventArgs e)
        {
            ShiftRecentTasksData();
            UpdateGraphic();
        }

        private void DeleteCompletedTasks()
        {
            for (int i = 0; i < daylist.Items.Count; i++)
            {
                if (daylist.GetItemChecked(i))
                {
                    AddRecentTasks(daylist.Items[i].ToString());
                    daylist.Items.RemoveAt(i);
                    i -= 1;
                }
            }
            UpdateListData();
        }

        private void CheckListData()
        {
            int total = 0;

            for (int i = 0; i < UploadedFiles.GetList().Count; i++)
            {
                if (bool.Parse(UploadedFiles.GetList()[i].Split(';')[1]))
                {
                    total++;
                }
            }

            if (DateTime.Parse(UploadedFiles.GetDate()[1]).Date == DateTime.Now.Date)
            {
                DeleteCompletedTasks();
            }
            else if (total >= int.Parse(UploadedFiles.GetSettings()[0]))
            {
                UpdateDateData();
                DeleteCompletedTasks();
                UpdateStreak();
            }
        }
    }
}
