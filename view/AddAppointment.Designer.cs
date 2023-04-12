namespace OOADCalendar.view
{
    partial class AddAppointment
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
            startTime = new TextBox();
            endTime = new TextBox();
            location = new TextBox();
            name = new TextBox();
            b15minutes = new CheckBox();
            b1hour = new CheckBox();
            b1day = new CheckBox();
            name_l = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            location_l = new Label();
            SuspendLayout();
            // 
            // startTime
            // 
            startTime.BorderStyle = BorderStyle.None;
            startTime.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            startTime.ForeColor = Color.FromArgb(209, 77, 114);
            startTime.Location = new Point(159, 197);
            startTime.Name = "startTime";
            startTime.Size = new Size(125, 25);
            startTime.TabIndex = 0;
            // 
            // endTime
            // 
            endTime.BorderStyle = BorderStyle.None;
            endTime.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            endTime.ForeColor = Color.FromArgb(209, 77, 114);
            endTime.Location = new Point(376, 197);
            endTime.Name = "endTime";
            endTime.Size = new Size(125, 25);
            endTime.TabIndex = 1;
            // 
            // location
            // 
            location.BorderStyle = BorderStyle.None;
            location.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            location.ForeColor = Color.FromArgb(209, 77, 114);
            location.Location = new Point(159, 138);
            location.Name = "location";
            location.Size = new Size(342, 25);
            location.TabIndex = 2;
            // 
            // name
            // 
            name.BackColor = Color.FromArgb(252, 200, 209);
            name.BorderStyle = BorderStyle.None;
            name.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.ForeColor = Color.FromArgb(209, 77, 114);
            name.Location = new Point(159, 76);
            name.Name = "name";
            name.Size = new Size(342, 25);
            name.TabIndex = 3;
            // 
            // b15minutes
            // 
            b15minutes.AutoSize = true;
            b15minutes.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b15minutes.ForeColor = Color.FromArgb(209, 77, 114);
            b15minutes.Location = new Point(48, 273);
            b15minutes.Name = "b15minutes";
            b15minutes.Size = new Size(205, 27);
            b15minutes.TabIndex = 4;
            b15minutes.Text = "Before 15 minutes";
            b15minutes.UseVisualStyleBackColor = true;
            // 
            // b1hour
            // 
            b1hour.AutoSize = true;
            b1hour.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b1hour.ForeColor = Color.FromArgb(209, 77, 114);
            b1hour.Location = new Point(48, 326);
            b1hour.Name = "b1hour";
            b1hour.Size = new Size(161, 27);
            b1hour.TabIndex = 5;
            b1hour.Text = "Before 1 hour";
            b1hour.UseVisualStyleBackColor = true;
            // 
            // b1day
            // 
            b1day.AutoSize = true;
            b1day.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b1day.ForeColor = Color.FromArgb(209, 77, 114);
            b1day.Location = new Point(48, 380);
            b1day.Name = "b1day";
            b1day.Size = new Size(156, 27);
            b1day.TabIndex = 6;
            b1day.Text = "Before 1 day";
            b1day.UseVisualStyleBackColor = true;
            // 
            // name_l
            // 
            name_l.AutoSize = true;
            name_l.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            name_l.ForeColor = Color.FromArgb(209, 77, 114);
            name_l.Location = new Point(48, 77);
            name_l.Name = "name_l";
            name_l.Size = new Size(70, 23);
            name_l.TabIndex = 7;
            name_l.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(209, 77, 114);
            panel1.Location = new Point(159, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 10);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(209, 77, 114);
            panel2.Location = new Point(159, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 10);
            panel2.TabIndex = 9;
            // 
            // location_l
            // 
            location_l.AutoSize = true;
            location_l.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            location_l.ForeColor = Color.FromArgb(209, 77, 114);
            location_l.Location = new Point(48, 140);
            location_l.Name = "location_l";
            location_l.Size = new Size(94, 23);
            location_l.TabIndex = 10;
            location_l.Text = "Location";
            // 
            // AddAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 200, 209);
            ClientSize = new Size(881, 487);
            Controls.Add(location_l);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(name_l);
            Controls.Add(b1day);
            Controls.Add(b1hour);
            Controls.Add(b15minutes);
            Controls.Add(name);
            Controls.Add(location);
            Controls.Add(endTime);
            Controls.Add(startTime);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddAppointment";
            Text = "AddAppointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox startTime;
        private TextBox endTime;
        private TextBox location;
        private TextBox name;
        private CheckBox b15minutes;
        private CheckBox b1hour;
        private CheckBox b1day;
        private Label name_l;
        private Panel panel1;
        private Panel panel2;
        private Label location_l;
    }
}