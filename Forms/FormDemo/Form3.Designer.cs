namespace FormDemo
{
    partial class FormDept
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
            this.ibl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.butfile = new System.Windows.Forms.Button();
            this.butfolder = new System.Windows.Forms.Button();
            this.butread = new System.Windows.Forms.Button();
            this.butwrite = new System.Windows.Forms.Button();
            this.lblloc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ibl_id
            // 
            this.ibl_id.AutoSize = true;
            this.ibl_id.Location = new System.Drawing.Point(121, 84);
            this.ibl_id.Name = "ibl_id";
            this.ibl_id.Size = new System.Drawing.Size(77, 13);
            this.ibl_id.TabIndex = 0;
            this.ibl_id.Text = "Department_Id";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(121, 128);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(96, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Department_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IOOperation";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(244, 82);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(260, 20);
            this.txtid.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(242, 121);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(262, 20);
            this.txtname.TabIndex = 4;
            // 
            // butfile
            // 
            this.butfile.Location = new System.Drawing.Point(140, 234);
            this.butfile.Name = "butfile";
            this.butfile.Size = new System.Drawing.Size(107, 42);
            this.butfile.TabIndex = 6;
            this.butfile.Text = "Create Folder";
            this.butfile.UseVisualStyleBackColor = true;
            this.butfile.Click += new System.EventHandler(this.butfile_Click);
            // 
            // butfolder
            // 
            this.butfolder.Location = new System.Drawing.Point(295, 234);
            this.butfolder.Name = "butfolder";
            this.butfolder.Size = new System.Drawing.Size(109, 42);
            this.butfolder.TabIndex = 7;
            this.butfolder.Text = "Create File";
            this.butfolder.UseVisualStyleBackColor = true;
            this.butfolder.Click += new System.EventHandler(this.butfolder_Click);
            // 
            // butread
            // 
            this.butread.Location = new System.Drawing.Point(455, 233);
            this.butread.Name = "butread";
            this.butread.Size = new System.Drawing.Size(100, 43);
            this.butread.TabIndex = 8;
            this.butread.Text = "Binariread";
            this.butread.UseVisualStyleBackColor = true;
            this.butread.Click += new System.EventHandler(this.butread_Click);
            // 
            // butwrite
            // 
            this.butwrite.Location = new System.Drawing.Point(604, 234);
            this.butwrite.Name = "butwrite";
            this.butwrite.Size = new System.Drawing.Size(102, 42);
            this.butwrite.TabIndex = 9;
            this.butwrite.Text = "Binarywrite";
            this.butwrite.UseVisualStyleBackColor = true;
            // 
            // lblloc
            // 
            this.lblloc.AutoSize = true;
            this.lblloc.Location = new System.Drawing.Point(121, 180);
            this.lblloc.Name = "lblloc";
            this.lblloc.Size = new System.Drawing.Size(48, 13);
            this.lblloc.TabIndex = 10;
            this.lblloc.Text = "Location";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 20);
            this.textBox1.TabIndex = 11;
            // 
            // FormDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblloc);
            this.Controls.Add(this.butwrite);
            this.Controls.Add(this.butread);
            this.Controls.Add(this.butfolder);
            this.Controls.Add(this.butfile);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.ibl_id);
            this.Name = "FormDept";
            this.Text = "FileIOOperation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ibl_id;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button butfile;
        private System.Windows.Forms.Button butfolder;
        private System.Windows.Forms.Button butread;
        private System.Windows.Forms.Button butwrite;
        private System.Windows.Forms.Label lblloc;
        private System.Windows.Forms.TextBox textBox1;
    }
}