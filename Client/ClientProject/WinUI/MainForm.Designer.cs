namespace WinUI
{
    partial class MainForm
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
            this.tabControlSAE = new System.Windows.Forms.TabControl();
            this.tabPageUpload = new System.Windows.Forms.TabPage();
            this.tabPageDownload = new System.Windows.Forms.TabPage();
            this.lblSAEName = new System.Windows.Forms.Label();
            this.txtSAEName = new System.Windows.Forms.TextBox();
            this.txtStoragename = new System.Windows.Forms.TextBox();
            this.lblStorageName = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControlSAE.SuspendLayout();
            this.tabPageDownload.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSAE
            // 
            this.tabControlSAE.Controls.Add(this.tabPageUpload);
            this.tabControlSAE.Controls.Add(this.tabPageDownload);
            this.tabControlSAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSAE.Location = new System.Drawing.Point(0, 0);
            this.tabControlSAE.Name = "tabControlSAE";
            this.tabControlSAE.SelectedIndex = 0;
            this.tabControlSAE.Size = new System.Drawing.Size(654, 471);
            this.tabControlSAE.TabIndex = 0;
            // 
            // tabPageUpload
            // 
            this.tabPageUpload.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpload.Name = "tabPageUpload";
            this.tabPageUpload.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpload.Size = new System.Drawing.Size(832, 432);
            this.tabPageUpload.TabIndex = 0;
            this.tabPageUpload.Text = "SAE上传管理";
            this.tabPageUpload.UseVisualStyleBackColor = true;
            // 
            // tabPageDownload
            // 
            this.tabPageDownload.Controls.Add(this.groupBox2);
            this.tabPageDownload.Controls.Add(this.groupBox1);
            this.tabPageDownload.Location = new System.Drawing.Point(4, 22);
            this.tabPageDownload.Name = "tabPageDownload";
            this.tabPageDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDownload.Size = new System.Drawing.Size(646, 445);
            this.tabPageDownload.TabIndex = 1;
            this.tabPageDownload.Text = "SAE下载管理";
            this.tabPageDownload.UseVisualStyleBackColor = true;
            // 
            // lblSAEName
            // 
            this.lblSAEName.AutoSize = true;
            this.lblSAEName.Location = new System.Drawing.Point(6, 26);
            this.lblSAEName.Name = "lblSAEName";
            this.lblSAEName.Size = new System.Drawing.Size(59, 12);
            this.lblSAEName.TabIndex = 0;
            this.lblSAEName.Text = "SAE应用名";
            // 
            // txtSAEName
            // 
            this.txtSAEName.Location = new System.Drawing.Point(71, 23);
            this.txtSAEName.Name = "txtSAEName";
            this.txtSAEName.Size = new System.Drawing.Size(178, 21);
            this.txtSAEName.TabIndex = 1;
            // 
            // txtStoragename
            // 
            this.txtStoragename.Location = new System.Drawing.Point(332, 23);
            this.txtStoragename.Name = "txtStoragename";
            this.txtStoragename.Size = new System.Drawing.Size(171, 21);
            this.txtStoragename.TabIndex = 3;
            // 
            // lblStorageName
            // 
            this.lblStorageName.AutoSize = true;
            this.lblStorageName.Location = new System.Drawing.Point(255, 26);
            this.lblStorageName.Name = "lblStorageName";
            this.lblStorageName.Size = new System.Drawing.Size(71, 12);
            this.lblStorageName.TabIndex = 2;
            this.lblStorageName.Text = "Storage名称";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(509, 20);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(117, 23);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "Storage内容分析";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSAEName);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.txtSAEName);
            this.groupBox1.Controls.Add(this.txtStoragename);
            this.groupBox1.Controls.Add(this.lblStorageName);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 56);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(6, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 369);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "存储信息";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 17);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(620, 349);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 471);
            this.Controls.Add(this.tabControlSAE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAE Tools";
            this.TopMost = true;
            this.tabControlSAE.ResumeLayout(false);
            this.tabPageDownload.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSAE;
        private System.Windows.Forms.TabPage tabPageUpload;
        private System.Windows.Forms.TabPage tabPageDownload;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtStoragename;
        private System.Windows.Forms.Label lblStorageName;
        private System.Windows.Forms.TextBox txtSAEName;
        private System.Windows.Forms.Label lblSAEName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}