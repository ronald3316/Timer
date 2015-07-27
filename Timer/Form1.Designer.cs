namespace Timer
{
    partial class Form1
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
            this.Ltime = new System.Windows.Forms.Label();
            this.setHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.SetMinutes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.setSeconds = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Shours = new System.Windows.Forms.Label();
            this.Sminutes = new System.Windows.Forms.Label();
            this.Secounds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ltime
            // 
            this.Ltime.AutoSize = true;
            this.Ltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Ltime.Location = new System.Drawing.Point(149, 9);
            this.Ltime.Name = "Ltime";
            this.Ltime.Size = new System.Drawing.Size(134, 55);
            this.Ltime.TabIndex = 0;
            this.Ltime.Text = "Time";
            // 
            // setHours
            // 
            this.setHours.Location = new System.Drawing.Point(85, 167);
            this.setHours.MaxLength = 2;
            this.setHours.Name = "setHours";
            this.setHours.Size = new System.Drawing.Size(155, 20);
            this.setHours.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set Hours";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(261, 292);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(103, 41);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(386, 292);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(103, 41);
            this.start.TabIndex = 3;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // SetMinutes
            // 
            this.SetMinutes.Location = new System.Drawing.Point(85, 193);
            this.SetMinutes.MaxLength = 5;
            this.SetMinutes.Name = "SetMinutes";
            this.SetMinutes.Size = new System.Drawing.Size(155, 20);
            this.SetMinutes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Set Minutes";
            // 
            // setSeconds
            // 
            this.setSeconds.Location = new System.Drawing.Point(85, 219);
            this.setSeconds.MaxLength = 5;
            this.setSeconds.Name = "setSeconds";
            this.setSeconds.Size = new System.Drawing.Size(155, 20);
            this.setSeconds.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Set Seconds";
            // 
            // Shours
            // 
            this.Shours.AutoSize = true;
            this.Shours.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shours.Location = new System.Drawing.Point(246, 166);
            this.Shours.Name = "Shours";
            this.Shours.Size = new System.Drawing.Size(47, 18);
            this.Shours.TabIndex = 2;
            this.Shours.Text = "Status";
            this.Shours.Visible = false;
            // 
            // Sminutes
            // 
            this.Sminutes.AutoSize = true;
            this.Sminutes.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sminutes.Location = new System.Drawing.Point(246, 192);
            this.Sminutes.Name = "Sminutes";
            this.Sminutes.Size = new System.Drawing.Size(47, 18);
            this.Sminutes.TabIndex = 2;
            this.Sminutes.Text = "Status";
            this.Sminutes.Visible = false;
            // 
            // Secounds
            // 
            this.Secounds.AutoSize = true;
            this.Secounds.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Secounds.Location = new System.Drawing.Point(246, 218);
            this.Secounds.Name = "Secounds";
            this.Secounds.Size = new System.Drawing.Size(47, 18);
            this.Secounds.TabIndex = 2;
            this.Secounds.Text = "Status";
            this.Secounds.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 345);
            this.Controls.Add(this.start);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.Secounds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sminutes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Shours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setSeconds);
            this.Controls.Add(this.SetMinutes);
            this.Controls.Add(this.setHours);
            this.Controls.Add(this.Ltime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ltime;
        private System.Windows.Forms.TextBox setHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox SetMinutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox setSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Shours;
        private System.Windows.Forms.Label Sminutes;
        private System.Windows.Forms.Label Secounds;
    }
}

