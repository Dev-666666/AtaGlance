namespace serialization_Demo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.butbread = new System.Windows.Forms.Button();
            this.butbwrite = new System.Windows.Forms.Button();
            this.butxmlread = new System.Windows.Forms.Button();
            this.butxmlwrite = new System.Windows.Forms.Button();
            this.butjsonread = new System.Windows.Forms.Button();
            this.butjsonwrite = new System.Windows.Forms.Button();
            this.butsoapread = new System.Windows.Forms.Button();
            this.butsoapwrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dept_ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dept_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(260, 71);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(228, 20);
            this.txtid.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(261, 124);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(231, 20);
            this.txtname.TabIndex = 4;
            // 
            // txtlocation
            // 
            this.txtlocation.Location = new System.Drawing.Point(260, 179);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(232, 20);
            this.txtlocation.TabIndex = 5;
            // 
            // butbread
            // 
            this.butbread.Location = new System.Drawing.Point(125, 260);
            this.butbread.Name = "butbread";
            this.butbread.Size = new System.Drawing.Size(87, 39);
            this.butbread.TabIndex = 6;
            this.butbread.Text = "BinaryRead";
            this.butbread.UseVisualStyleBackColor = true;
            this.butbread.Click += new System.EventHandler(this.button1_Click);
            // 
            // butbwrite
            // 
            this.butbwrite.Location = new System.Drawing.Point(255, 260);
            this.butbwrite.Name = "butbwrite";
            this.butbwrite.Size = new System.Drawing.Size(95, 39);
            this.butbwrite.TabIndex = 7;
            this.butbwrite.Text = "BinaryWrite";
            this.butbwrite.UseVisualStyleBackColor = true;
            // 
            // butxmlread
            // 
            this.butxmlread.Location = new System.Drawing.Point(391, 260);
            this.butxmlread.Name = "butxmlread";
            this.butxmlread.Size = new System.Drawing.Size(97, 39);
            this.butxmlread.TabIndex = 8;
            this.butxmlread.Text = "XMLRead";
            this.butxmlread.UseVisualStyleBackColor = true;
            // 
            // butxmlwrite
            // 
            this.butxmlwrite.Location = new System.Drawing.Point(528, 260);
            this.butxmlwrite.Name = "butxmlwrite";
            this.butxmlwrite.Size = new System.Drawing.Size(95, 39);
            this.butxmlwrite.TabIndex = 9;
            this.butxmlwrite.Text = "XMLWrite";
            this.butxmlwrite.UseVisualStyleBackColor = true;
            // 
            // butjsonread
            // 
            this.butjsonread.Location = new System.Drawing.Point(125, 338);
            this.butjsonread.Name = "butjsonread";
            this.butjsonread.Size = new System.Drawing.Size(87, 47);
            this.butjsonread.TabIndex = 10;
            this.butjsonread.Text = "JSONRead";
            this.butjsonread.UseVisualStyleBackColor = true;
            this.butjsonread.Click += new System.EventHandler(this.butjsonread_Click);
            // 
            // butjsonwrite
            // 
            this.butjsonwrite.Location = new System.Drawing.Point(255, 338);
            this.butjsonwrite.Name = "butjsonwrite";
            this.butjsonwrite.Size = new System.Drawing.Size(95, 44);
            this.butjsonwrite.TabIndex = 11;
            this.butjsonwrite.Text = "JSonWrite";
            this.butjsonwrite.UseVisualStyleBackColor = true;
            this.butjsonwrite.Click += new System.EventHandler(this.butjsonwrite_Click);
            // 
            // butsoapread
            // 
            this.butsoapread.Location = new System.Drawing.Point(391, 338);
            this.butsoapread.Name = "butsoapread";
            this.butsoapread.Size = new System.Drawing.Size(97, 44);
            this.butsoapread.TabIndex = 12;
            this.butsoapread.Text = "SOAPREAD";
            this.butsoapread.UseVisualStyleBackColor = true;
            // 
            // butsoapwrite
            // 
            this.butsoapwrite.Location = new System.Drawing.Point(528, 338);
            this.butsoapwrite.Name = "butsoapwrite";
            this.butsoapwrite.Size = new System.Drawing.Size(95, 44);
            this.butsoapwrite.TabIndex = 13;
            this.butsoapwrite.Text = "SOAPWrite";
            this.butsoapwrite.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butsoapwrite);
            this.Controls.Add(this.butsoapread);
            this.Controls.Add(this.butjsonwrite);
            this.Controls.Add(this.butjsonread);
            this.Controls.Add(this.butxmlwrite);
            this.Controls.Add(this.butxmlread);
            this.Controls.Add(this.butbwrite);
            this.Controls.Add(this.butbread);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SerializableDemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.Button butbread;
        private System.Windows.Forms.Button butbwrite;
        private System.Windows.Forms.Button butxmlread;
        private System.Windows.Forms.Button butxmlwrite;
        private System.Windows.Forms.Button butjsonread;
        private System.Windows.Forms.Button butjsonwrite;
        private System.Windows.Forms.Button butsoapread;
        private System.Windows.Forms.Button butsoapwrite;
    }
}

