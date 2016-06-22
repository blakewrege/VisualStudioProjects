namespace FileSharingClient
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
            this.Filesfgsf = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Filesfgsf
            // 
            this.Filesfgsf.AutoSize = true;
            this.Filesfgsf.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filesfgsf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Filesfgsf.Location = new System.Drawing.Point(55, 28);
            this.Filesfgsf.Name = "Filesfgsf";
            this.Filesfgsf.Size = new System.Drawing.Size(161, 23);
            this.Filesfgsf.TabIndex = 1;
            this.Filesfgsf.Text = "File Sharing Client";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(74, 137);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(139, 20);
            this.txtFile.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(211, 137);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(63, 22);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(74, 188);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(73, 27);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select File";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(74, 69);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(100, 20);
            this.txtIPAddress.TabIndex = 6;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(74, 105);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 20);
            this.txtHost.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "IP Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 251);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.Filesfgsf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Filesfgsf;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

