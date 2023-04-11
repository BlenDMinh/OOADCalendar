namespace OOADCalendar.view
{
    partial class Date
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            day_l = new Label();
            SuspendLayout();
            // 
            // day_l
            // 
            day_l.AutoSize = true;
            day_l.BackColor = Color.FromArgb(255, 171, 171);
            day_l.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            day_l.ForeColor = Color.FromArgb(209, 77, 114);
            day_l.Location = new Point(11, 12);
            day_l.Name = "day_l";
            day_l.Size = new Size(32, 23);
            day_l.TabIndex = 0;
            day_l.Text = "00";
            // 
            // Date
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 171, 171);
            Controls.Add(day_l);
            Name = "Date";
            Size = new Size(100, 100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label day_l;
    }
}
