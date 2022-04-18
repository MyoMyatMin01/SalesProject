namespace SalesProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.job = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(100, 85);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 19);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(194, 80);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 30);
            this.txtName.TabIndex = 1;
            // 
            // txtJob
            // 
            this.txtJob.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJob.Location = new System.Drawing.Point(194, 136);
            this.txtJob.Multiline = true;
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(211, 30);
            this.txtJob.TabIndex = 2;
            // 
            // job
            // 
            this.job.AutoSize = true;
            this.job.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.job.Location = new System.Drawing.Point(100, 141);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(30, 19);
            this.job.TabIndex = 3;
            this.job.Text = "Job";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(294, 190);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(111, 29);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.AutoSize = true;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMessage.Location = new System.Drawing.Point(194, 252);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(0, 19);
            this.txtMessage.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(514, 346);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.job);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.name);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label name;
        private TextBox txtName;
        private TextBox txtJob;
        private Label job;
        private Button btnShow;
        private Label txtMessage;
    }
}