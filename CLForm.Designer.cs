namespace Checklist
{
    partial class CLForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLForm));
            this.daylist = new System.Windows.Forms.CheckedListBox();
            this.AddLine = new MetroFramework.Controls.MetroTextBox();
            this.AddButton = new MetroFramework.Controls.MetroButton();
            this.DelButton = new MetroFramework.Controls.MetroButton();
            this.UpdateButton = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Streak = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.Label();
            this.GraphicPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Lable = new System.Windows.Forms.TableLayoutPanel();
            this.label0 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.VremyaDoKonzhaStrika = new System.Windows.Forms.Label();
            this.DneyPodryad = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.PictureBox();
            this.UpdateStreakTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RenameButton = new MetroFramework.Controls.MetroButton();
            this.UpdateGraphicTimer = new System.Windows.Forms.Timer(this.components);
            this.CheckHistory = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.GraphicPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.Lable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // daylist
            // 
            this.daylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daylist.FormattingEnabled = true;
            this.daylist.Location = new System.Drawing.Point(20, 112);
            this.daylist.Margin = new System.Windows.Forms.Padding(0);
            this.daylist.Name = "daylist";
            this.daylist.Size = new System.Drawing.Size(519, 497);
            this.daylist.TabIndex = 0;
            // 
            // AddLine
            // 
            // 
            // 
            // 
            this.AddLine.CustomButton.Image = null;
            this.AddLine.CustomButton.Location = new System.Drawing.Point(481, 2);
            this.AddLine.CustomButton.Name = "";
            this.AddLine.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.AddLine.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AddLine.CustomButton.TabIndex = 1;
            this.AddLine.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AddLine.CustomButton.UseSelectable = true;
            this.AddLine.CustomButton.Visible = false;
            this.AddLine.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.AddLine.Lines = new string[0];
            this.AddLine.Location = new System.Drawing.Point(23, 618);
            this.AddLine.Margin = new System.Windows.Forms.Padding(0);
            this.AddLine.MaxLength = 32767;
            this.AddLine.Multiline = true;
            this.AddLine.Name = "AddLine";
            this.AddLine.PasswordChar = '\0';
            this.AddLine.PromptText = "Введите название для добавления или переименования";
            this.AddLine.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AddLine.SelectedText = "";
            this.AddLine.SelectionLength = 0;
            this.AddLine.SelectionStart = 0;
            this.AddLine.ShortcutsEnabled = true;
            this.AddLine.ShowClearButton = true;
            this.AddLine.Size = new System.Drawing.Size(519, 40);
            this.AddLine.TabIndex = 1;
            this.AddLine.UseSelectable = true;
            this.AddLine.WaterMark = "Введите название для добавления или переименования";
            this.AddLine.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AddLine.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddButton
            // 
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Location = new System.Drawing.Point(129, 0);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 28);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseSelectable = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelButton.Location = new System.Drawing.Point(0, 0);
            this.DelButton.Margin = new System.Windows.Forms.Padding(0);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(129, 28);
            this.DelButton.TabIndex = 3;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseSelectable = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.Location = new System.Drawing.Point(387, 0);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(0);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(132, 28);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Завершить";
            this.UpdateButton.UseSelectable = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Streak, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.EndTime, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.GraphicPanel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.VremyaDoKonzhaStrika, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DneyPodryad, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(569, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(608, 620);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Streak
            // 
            this.Streak.AutoSize = true;
            this.Streak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Streak.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Streak.Location = new System.Drawing.Point(0, 31);
            this.Streak.Margin = new System.Windows.Forms.Padding(0);
            this.Streak.Name = "Streak";
            this.Streak.Size = new System.Drawing.Size(608, 124);
            this.Streak.TabIndex = 4;
            this.Streak.Text = "0";
            this.Streak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndTime
            // 
            this.EndTime.AutoSize = true;
            this.EndTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.EndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndTime.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndTime.Location = new System.Drawing.Point(0, 186);
            this.EndTime.Margin = new System.Windows.Forms.Padding(0);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(608, 124);
            this.EndTime.TabIndex = 3;
            this.EndTime.Text = "0";
            this.EndTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GraphicPanel
            // 
            this.GraphicPanel.Controls.Add(this.tableLayoutPanel3);
            this.GraphicPanel.Controls.Add(this.label12);
            this.GraphicPanel.Controls.Add(this.label11);
            this.GraphicPanel.Controls.Add(this.Lable);
            this.GraphicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraphicPanel.Location = new System.Drawing.Point(0, 310);
            this.GraphicPanel.Margin = new System.Windows.Forms.Padding(0);
            this.GraphicPanel.Name = "GraphicPanel";
            this.GraphicPanel.Size = new System.Drawing.Size(608, 310);
            this.GraphicPanel.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 10;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.label22, 9, 0);
            this.tableLayoutPanel3.Controls.Add(this.label21, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.label20, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.label19, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.label18, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label17, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label16, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label15, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label14, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(54, 282);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(538, 25);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Location = new System.Drawing.Point(477, 0);
            this.label22.Margin = new System.Windows.Forms.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 25);
            this.label22.TabIndex = 16;
            this.label22.Text = "10";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Location = new System.Drawing.Point(424, 0);
            this.label21.Margin = new System.Windows.Forms.Padding(0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 25);
            this.label21.TabIndex = 15;
            this.label21.Text = "9";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(371, 0);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 25);
            this.label20.TabIndex = 14;
            this.label20.Text = "8";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(318, 0);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 25);
            this.label19.TabIndex = 13;
            this.label19.Text = "7";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(265, 0);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 25);
            this.label18.TabIndex = 12;
            this.label18.Text = "6";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(212, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 25);
            this.label17.TabIndex = 11;
            this.label17.Text = "5";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(159, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 25);
            this.label16.TabIndex = 10;
            this.label16.Text = "4";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(106, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "3";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(53, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "2";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = "1";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 286);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Дней";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Задач";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lable
            // 
            this.Lable.ColumnCount = 1;
            this.Lable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Lable.Controls.Add(this.label0, 0, 10);
            this.Lable.Controls.Add(this.Label1, 0, 9);
            this.Lable.Controls.Add(this.Label2, 0, 8);
            this.Lable.Controls.Add(this.Label3, 0, 7);
            this.Lable.Controls.Add(this.Label4, 0, 6);
            this.Lable.Controls.Add(this.Label5, 0, 5);
            this.Lable.Controls.Add(this.Label6, 0, 4);
            this.Lable.Controls.Add(this.Label7, 0, 3);
            this.Lable.Controls.Add(this.Label8, 0, 2);
            this.Lable.Controls.Add(this.Label9, 0, 1);
            this.Lable.Controls.Add(this.Label10, 0, 0);
            this.Lable.Location = new System.Drawing.Point(3, 15);
            this.Lable.Name = "Lable";
            this.Lable.RowCount = 11;
            this.Lable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Lable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Lable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Lable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Lable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Lable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Lable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Lable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Lable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Lable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Lable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Lable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Lable.Size = new System.Drawing.Size(42, 269);
            this.Lable.TabIndex = 0;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label0.Location = new System.Drawing.Point(0, 240);
            this.label0.Margin = new System.Windows.Forms.Padding(0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(42, 29);
            this.label0.TabIndex = 10;
            this.label0.Text = "0";
            this.label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Location = new System.Drawing.Point(0, 216);
            this.Label1.Margin = new System.Windows.Forms.Padding(0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(42, 24);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "0";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label2.Location = new System.Drawing.Point(0, 192);
            this.Label2.Margin = new System.Windows.Forms.Padding(0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(42, 24);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "0";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label3.Location = new System.Drawing.Point(0, 168);
            this.Label3.Margin = new System.Windows.Forms.Padding(0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(42, 24);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "0";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label4.Location = new System.Drawing.Point(0, 144);
            this.Label4.Margin = new System.Windows.Forms.Padding(0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(42, 24);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "0";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label5.Location = new System.Drawing.Point(0, 120);
            this.Label5.Margin = new System.Windows.Forms.Padding(0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(42, 24);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "0";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label6.Location = new System.Drawing.Point(0, 96);
            this.Label6.Margin = new System.Windows.Forms.Padding(0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(42, 24);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "0";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label7.Location = new System.Drawing.Point(0, 72);
            this.Label7.Margin = new System.Windows.Forms.Padding(0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(42, 24);
            this.Label7.TabIndex = 3;
            this.Label7.Text = "0";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label8.Location = new System.Drawing.Point(0, 48);
            this.Label8.Margin = new System.Windows.Forms.Padding(0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(42, 24);
            this.Label8.TabIndex = 2;
            this.Label8.Text = "0";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label9.Location = new System.Drawing.Point(0, 24);
            this.Label9.Margin = new System.Windows.Forms.Padding(0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(42, 24);
            this.Label9.TabIndex = 1;
            this.Label9.Text = "0";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label10.Location = new System.Drawing.Point(0, 0);
            this.Label10.Margin = new System.Windows.Forms.Padding(0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(42, 24);
            this.Label10.TabIndex = 0;
            this.Label10.Text = "0";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VremyaDoKonzhaStrika
            // 
            this.VremyaDoKonzhaStrika.AutoSize = true;
            this.VremyaDoKonzhaStrika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VremyaDoKonzhaStrika.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VremyaDoKonzhaStrika.Location = new System.Drawing.Point(0, 155);
            this.VremyaDoKonzhaStrika.Margin = new System.Windows.Forms.Padding(0);
            this.VremyaDoKonzhaStrika.Name = "VremyaDoKonzhaStrika";
            this.VremyaDoKonzhaStrika.Size = new System.Drawing.Size(608, 31);
            this.VremyaDoKonzhaStrika.TabIndex = 6;
            this.VremyaDoKonzhaStrika.Text = "Время до конца стрика";
            this.VremyaDoKonzhaStrika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DneyPodryad
            // 
            this.DneyPodryad.AutoSize = true;
            this.DneyPodryad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DneyPodryad.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DneyPodryad.Location = new System.Drawing.Point(0, 0);
            this.DneyPodryad.Margin = new System.Windows.Forms.Padding(0);
            this.DneyPodryad.Name = "DneyPodryad";
            this.DneyPodryad.Size = new System.Drawing.Size(608, 31);
            this.DneyPodryad.TabIndex = 7;
            this.DneyPodryad.Text = "Дней подряд";
            this.DneyPodryad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.Location = new System.Drawing.Point(23, 64);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(45, 45);
            this.Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Settings.TabIndex = 7;
            this.Settings.TabStop = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // UpdateStreakTimer
            // 
            this.UpdateStreakTimer.Enabled = true;
            this.UpdateStreakTimer.Interval = 1000;
            this.UpdateStreakTimer.Tick += new System.EventHandler(this.UpdateStreakTimer_Tick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.RenameButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.AddButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.DelButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.UpdateButton, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 661);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(519, 30);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // RenameButton
            // 
            this.RenameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RenameButton.Location = new System.Drawing.Point(258, 0);
            this.RenameButton.Margin = new System.Windows.Forms.Padding(0);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(129, 28);
            this.RenameButton.TabIndex = 5;
            this.RenameButton.Text = "Переименовать";
            this.RenameButton.UseSelectable = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // UpdateGraphicTimer
            // 
            this.UpdateGraphicTimer.Enabled = true;
            this.UpdateGraphicTimer.Interval = 10;
            this.UpdateGraphicTimer.Tick += new System.EventHandler(this.UpdateGraphicTimer_Tick);
            // 
            // CheckHistory
            // 
            this.CheckHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckHistory.Image = ((System.Drawing.Image)(resources.GetObject("CheckHistory.Image")));
            this.CheckHistory.Location = new System.Drawing.Point(74, 64);
            this.CheckHistory.Name = "CheckHistory";
            this.CheckHistory.Size = new System.Drawing.Size(45, 45);
            this.CheckHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheckHistory.TabIndex = 9;
            this.CheckHistory.TabStop = false;
            this.CheckHistory.Click += new System.EventHandler(this.CheckHistory_Click);
            // 
            // CLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.CheckHistory);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AddLine);
            this.Controls.Add(this.daylist);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Movable = false;
            this.Name = "CLForm";
            this.Text = "Checklist";
            this.Load += new System.EventHandler(this.CLForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.GraphicPanel.ResumeLayout(false);
            this.GraphicPanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.Lable.ResumeLayout(false);
            this.Lable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CheckHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox daylist;
        private MetroFramework.Controls.MetroTextBox AddLine;
        private MetroFramework.Controls.MetroButton AddButton;
        private MetroFramework.Controls.MetroButton DelButton;
        private MetroFramework.Controls.MetroButton UpdateButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Streak;
        private System.Windows.Forms.Label EndTime;
        private System.Windows.Forms.Panel GraphicPanel;
        private System.Windows.Forms.Label VremyaDoKonzhaStrika;
        private System.Windows.Forms.Label DneyPodryad;
        private System.Windows.Forms.PictureBox Settings;
        private System.Windows.Forms.Timer UpdateStreakTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroButton RenameButton;
        private System.Windows.Forms.Timer UpdateGraphicTimer;
        private System.Windows.Forms.TableLayoutPanel Lable;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.PictureBox CheckHistory;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}