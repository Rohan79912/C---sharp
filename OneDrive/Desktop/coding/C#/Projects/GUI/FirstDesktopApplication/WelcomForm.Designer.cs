namespace FirstDesktopApplication
{
    partial class WelcomForm
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
            this.lblname = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblcourse = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbllang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(86, 59);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(324, 64);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "WELCOME";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(86, 157);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(324, 64);
            this.lbldob.TabIndex = 1;
            this.lbldob.Text = "WELCOME";
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcourse.Location = new System.Drawing.Point(86, 257);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(324, 64);
            this.lblcourse.TabIndex = 2;
            this.lblcourse.Text = "WELCOME";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcity.Location = new System.Drawing.Point(86, 347);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(324, 64);
            this.lblcity.TabIndex = 3;
            this.lblcity.Text = "WELCOME";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(86, 450);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(324, 64);
            this.lblgender.TabIndex = 4;
            this.lblgender.Text = "WELCOME";
            // 
            // lbllang
            // 
            this.lbllang.AutoSize = true;
            this.lbllang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllang.Location = new System.Drawing.Point(86, 551);
            this.lbllang.Name = "lbllang";
            this.lbllang.Size = new System.Drawing.Size(324, 64);
            this.lbllang.TabIndex = 5;
            this.lbllang.Text = "WELCOME";
            // 
            // WelcomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 1396);
            this.Controls.Add(this.lbllang);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblcity);
            this.Controls.Add(this.lblcourse);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.lblname);
            this.Name = "WelcomForm";
            this.Text = "WelcomForm";
            this.Load += new System.EventHandler(this.WelcomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbllang;
    }
}