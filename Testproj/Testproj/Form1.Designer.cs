namespace Testproj
{
    partial class Batterij
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Batterij));
            this.batery = new System.Windows.Forms.ProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ltime = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tijde = new System.Windows.Forms.Timer(this.components);
            this.changeicon = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // batery
            // 
            this.batery.ForeColor = System.Drawing.Color.Lime;
            this.batery.Location = new System.Drawing.Point(9, 9);
            this.batery.Margin = new System.Windows.Forms.Padding(0);
            this.batery.Name = "batery";
            this.batery.Size = new System.Drawing.Size(71, 38);
            this.batery.Step = 1;
            this.batery.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.batery.TabIndex = 0;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Bold);
            this.lblPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPercent.Location = new System.Drawing.Point(98, -1);
            this.lblPercent.Margin = new System.Windows.Forms.Padding(0);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(93, 48);
            this.lblPercent.TabIndex = 2;
            this.lblPercent.Text = "00%";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(80, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 18);
            this.panel1.TabIndex = 3;
            // 
            // ltime
            // 
            this.ltime.AutoSize = true;
            this.ltime.BackColor = System.Drawing.Color.Transparent;
            this.ltime.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltime.ForeColor = System.Drawing.Color.Silver;
            this.ltime.Location = new System.Drawing.Point(35, 72);
            this.ltime.Name = "ltime";
            this.ltime.Size = new System.Drawing.Size(135, 40);
            this.ltime.TabIndex = 6;
            this.ltime.Text = "00:00:00";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Gray;
            this.lbltime.Location = new System.Drawing.Point(9, 47);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(41, 25);
            this.lbltime.TabIndex = 4;
            this.lbltime.Text = "tijd";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tijde
            // 
            this.tijde.Interval = 500;
            this.tijde.Tick += new System.EventHandler(this.tijde_Tick);
            // 
            // changeicon
            // 
            this.changeicon.Interval = 20000;
            this.changeicon.Tick += new System.EventHandler(this.changeicon_Tick);
            // 
            // Batterij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(200, 107);
            this.Controls.Add(this.ltime);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.batery);
            this.Controls.Add(this.lblPercent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Batterij";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Tag = "Uw laptopaccu";
            this.Text = "Battery";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar batery;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label ltime;
        private System.Windows.Forms.Timer tijde;
        private System.Windows.Forms.Timer changeicon;
    }
}

