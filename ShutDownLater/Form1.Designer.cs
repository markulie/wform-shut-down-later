namespace ShutDownLater
{
    partial class FormMain
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelInfo.Location = new System.Drawing.Point(49, 68);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(37, 15);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "label1";
            this.labelInfo.Visible = false;
            this.labelInfo.Click += new System.EventHandler(this.labelInfo_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.buttonRun.BackColor = System.Drawing.Color.White;
            this.buttonRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRun.Location = new System.Drawing.Point(49, 125);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(122, 23);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "1 Hour Timer\r\n";
            this.buttonRun.UseVisualStyleBackColor = false;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShutDownLater.Properties.Resources.bck;
            this.ClientSize = new System.Drawing.Size(211, 191);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.labelInfo);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sleepy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Timer timer;
    }
}

