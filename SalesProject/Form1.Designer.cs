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
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.chkVGood = new System.Windows.Forms.CheckBox();
            this.chkGood = new System.Windows.Forms.CheckBox();
            this.gender = new System.Windows.Forms.Label();
            this.review = new System.Windows.Forms.Label();
            this.cmbLanguages = new System.Windows.Forms.ComboBox();
            this.gVDataTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gVDataTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(243, 42);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 19);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(344, 37);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(225, 30);
            this.txtName.TabIndex = 1;
            // 
            // txtJob
            // 
            this.txtJob.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJob.Location = new System.Drawing.Point(344, 93);
            this.txtJob.Multiline = true;
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(225, 30);
            this.txtJob.TabIndex = 2;
            // 
            // job
            // 
            this.job.AutoSize = true;
            this.job.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.job.Location = new System.Drawing.Point(243, 98);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(30, 19);
            this.job.TabIndex = 3;
            this.job.Text = "Job";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(458, 292);
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
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnMale.Location = new System.Drawing.Point(0, 19);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(57, 23);
            this.rbtnMale.TabIndex = 6;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnFemale.Location = new System.Drawing.Point(128, 19);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(70, 23);
            this.rbtnFemale.TabIndex = 7;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // chkVGood
            // 
            this.chkVGood.AutoSize = true;
            this.chkVGood.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkVGood.Location = new System.Drawing.Point(472, 199);
            this.chkVGood.Name = "chkVGood";
            this.chkVGood.Size = new System.Drawing.Size(93, 23);
            this.chkVGood.TabIndex = 8;
            this.chkVGood.Text = "Very Good";
            this.chkVGood.UseVisualStyleBackColor = true;
            // 
            // chkGood
            // 
            this.chkGood.AutoSize = true;
            this.chkGood.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkGood.Location = new System.Drawing.Point(344, 199);
            this.chkGood.Name = "chkGood";
            this.chkGood.Size = new System.Drawing.Size(62, 23);
            this.chkGood.TabIndex = 9;
            this.chkGood.Text = "Good";
            this.chkGood.UseVisualStyleBackColor = true;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gender.Location = new System.Drawing.Point(243, 152);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(54, 19);
            this.gender.TabIndex = 10;
            this.gender.Text = "Gender";
            // 
            // review
            // 
            this.review.AutoSize = true;
            this.review.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.review.Location = new System.Drawing.Point(243, 199);
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(51, 19);
            this.review.TabIndex = 11;
            this.review.Text = "Review";
            // 
            // cmbLanguages
            // 
            this.cmbLanguages.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbLanguages.FormattingEnabled = true;
            this.cmbLanguages.Location = new System.Drawing.Point(344, 243);
            this.cmbLanguages.Name = "cmbLanguages";
            this.cmbLanguages.Size = new System.Drawing.Size(225, 28);
            this.cmbLanguages.TabIndex = 12;
            this.cmbLanguages.SelectedIndexChanged += new System.EventHandler(this.cmbLanguages_SelectedIndexChanged);
            // 
            // gVDataTable
            // 
            this.gVDataTable.BackgroundColor = System.Drawing.Color.White;
            this.gVDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVDataTable.Location = new System.Drawing.Point(83, 349);
            this.gVDataTable.Name = "gVDataTable";
            this.gVDataTable.RowTemplate.Height = 25;
            this.gVDataTable.Size = new System.Drawing.Size(486, 188);
            this.gVDataTable.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnMale);
            this.groupBox1.Controls.Add(this.rbtnFemale);
            this.groupBox1.Location = new System.Drawing.Point(344, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 64);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(653, 549);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gVDataTable);
            this.Controls.Add(this.cmbLanguages);
            this.Controls.Add(this.review);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.chkGood);
            this.Controls.Add(this.chkVGood);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVDataTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private RadioButton rbtnMale;
        private RadioButton rbtnFemale;
        private CheckBox chkVGood;
        private CheckBox chkGood;
        private Label gender;
        private Label review;
        private ComboBox cmbLanguages;
        private DataGridView gVDataTable;
        private GroupBox groupBox1;
    }
}