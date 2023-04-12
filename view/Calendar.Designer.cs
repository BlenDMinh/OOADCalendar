namespace OOADCalendar.view {
    partial class Calendar {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            flowLayoutPanel = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            date = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Location = new Point(10, 118);
            flowLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(726, 477);
            flowLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(209, 77, 114);
            label1.Location = new Point(26, 88);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 1;
            label1.Text = "Sunday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(209, 77, 114);
            label2.Location = new Point(115, 88);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 2;
            label2.Text = "Monday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(209, 77, 114);
            label3.Location = new Point(205, 88);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 3;
            label3.Text = "Tuesday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(209, 77, 114);
            label4.Location = new Point(578, 88);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 6;
            label4.Text = "Saturday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(209, 77, 114);
            label5.Location = new Point(395, 88);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 5;
            label5.Text = "Thursday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(209, 77, 114);
            label6.Location = new Point(286, 88);
            label6.Name = "label6";
            label6.Size = new Size(94, 19);
            label6.TabIndex = 4;
            label6.Text = "Wednesday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(209, 77, 114);
            label7.Location = new Point(496, 88);
            label7.Name = "label7";
            label7.Size = new Size(51, 19);
            label7.TabIndex = 7;
            label7.Text = "Friday";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            date.Location = new Point(285, 46);
            date.Name = "date";
            date.Size = new Size(125, 28);
            date.TabIndex = 8;
            date.Text = "mm/yyyy";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(570, 46);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 28);
            button1.TabIndex = 9;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(23, 46);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 28);
            button2.TabIndex = 10;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 200, 209);
            ClientSize = new Size(672, 604);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(date);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel);
            ForeColor = Color.FromArgb(209, 77, 114);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Calendar";
            Text = "Calendar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label date;
        private Button button1;
        private Button button2;
    }
}