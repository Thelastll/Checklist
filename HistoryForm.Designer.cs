namespace Checklist
{
    partial class HistoryForm
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
            this.history = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // history
            // 
            this.history.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.history.FormattingEnabled = true;
            this.history.ItemHeight = 16;
            this.history.Location = new System.Drawing.Point(20, 74);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(336, 356);
            this.history.TabIndex = 0;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.history);
            this.MaximizeBox = false;
            this.Name = "HistoryForm";
            this.Text = "Tasks history";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox history;
    }
}