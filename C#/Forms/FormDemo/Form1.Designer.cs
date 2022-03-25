namespace FormDemo
{
    partial class loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            this.lblloginhead = new System.Windows.Forms.Label();
            this.lbluname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.butlogin = new System.Windows.Forms.Button();
            this.butclear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblloginhead
            // 
            this.lblloginhead.AutoSize = true;
            this.lblloginhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginhead.Location = new System.Drawing.Point(16, 14);
            this.lblloginhead.Name = "lblloginhead";
            this.lblloginhead.Size = new System.Drawing.Size(274, 33);
            this.lblloginhead.TabIndex = 0;
            this.lblloginhead.Text = "Welcome To Login";
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluname.Location = new System.Drawing.Point(18, 83);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(105, 24);
            this.lbluname.TabIndex = 1;
            this.lbluname.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txtuname
            // 
            this.txtuname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuname.Location = new System.Drawing.Point(129, 83);
            this.txtuname.MaxLength = 32800;
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(237, 29);
            this.txtuname.TabIndex = 3;
            this.txtuname.TextChanged += new System.EventHandler(this.txtuname_TextChanged);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(129, 138);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(236, 29);
            this.txtpass.TabIndex = 4;
            // 
            // butlogin
            // 
            this.butlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butlogin.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.butlogin.Image = ((System.Drawing.Image)(resources.GetObject("butlogin.Image")));
            this.butlogin.Location = new System.Drawing.Point(248, 224);
            this.butlogin.Name = "butlogin";
            this.butlogin.Size = new System.Drawing.Size(117, 36);
            this.butlogin.TabIndex = 5;
            this.butlogin.UseVisualStyleBackColor = true;
            this.butlogin.Click += new System.EventHandler(this.butlogin_Click);
            // 
            // butclear
            // 
            this.butclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butclear.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.butclear.Image = ((System.Drawing.Image)(resources.GetObject("butclear.Image")));
            this.butclear.Location = new System.Drawing.Point(129, 224);
            this.butclear.Name = "butclear";
            this.butclear.Size = new System.Drawing.Size(100, 36);
            this.butclear.TabIndex = 6;
            this.butclear.UseVisualStyleBackColor = true;
            this.butclear.Click += new System.EventHandler(this.butclear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblloginhead);
            this.panel1.Controls.Add(this.butclear);
            this.panel1.Controls.Add(this.lbluname);
            this.panel1.Controls.Add(this.butlogin);
            this.panel1.Controls.Add(this.txtuname);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(38, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 415);
            this.panel1.TabIndex = 7;
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "loginform";
            this.Text = "LoGinWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblloginhead;
        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button butlogin;
        private System.Windows.Forms.Button butclear;
        private System.Windows.Forms.Panel panel1;
    }
}

