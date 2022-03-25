namespace serialization_Demo
{
    partial class Product
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpric = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jsonRead = new System.Windows.Forms.Button();
            this.jsonWrite = new System.Windows.Forms.Button();
            this.xmlRead = new System.Windows.Forms.Button();
            this.xmlWrite = new System.Windows.Forms.Button();
            this.SoapWrite = new System.Windows.Forms.Button();
            this.soapReda = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtquan = new System.Windows.Forms.TextBox();
            this.binRead = new System.Windows.Forms.Button();
            this.binWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(324, 92);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(173, 20);
            this.txtid.TabIndex = 0;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(324, 147);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(171, 20);
            this.txtname.TabIndex = 1;
            // 
            // txtpric
            // 
            this.txtpric.Location = new System.Drawing.Point(324, 197);
            this.txtpric.Name = "txtpric";
            this.txtpric.Size = new System.Drawing.Size(169, 20);
            this.txtpric.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ProductId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product_Price";
            // 
            // jsonRead
            // 
            this.jsonRead.Location = new System.Drawing.Point(171, 331);
            this.jsonRead.Name = "jsonRead";
            this.jsonRead.Size = new System.Drawing.Size(87, 41);
            this.jsonRead.TabIndex = 6;
            this.jsonRead.Text = "JsonRead";
            this.jsonRead.UseVisualStyleBackColor = true;
            this.jsonRead.Click += new System.EventHandler(this.jsonRead_Click);
            // 
            // jsonWrite
            // 
            this.jsonWrite.Location = new System.Drawing.Point(303, 331);
            this.jsonWrite.Name = "jsonWrite";
            this.jsonWrite.Size = new System.Drawing.Size(83, 41);
            this.jsonWrite.TabIndex = 7;
            this.jsonWrite.Text = "JsonWrite";
            this.jsonWrite.UseVisualStyleBackColor = true;
            this.jsonWrite.Click += new System.EventHandler(this.jsonWrite_Click);
            // 
            // xmlRead
            // 
            this.xmlRead.Location = new System.Drawing.Point(434, 328);
            this.xmlRead.Name = "xmlRead";
            this.xmlRead.Size = new System.Drawing.Size(93, 42);
            this.xmlRead.TabIndex = 8;
            this.xmlRead.Text = "xmlRead";
            this.xmlRead.UseVisualStyleBackColor = true;
            // 
            // xmlWrite
            // 
            this.xmlWrite.Location = new System.Drawing.Point(564, 331);
            this.xmlWrite.Name = "xmlWrite";
            this.xmlWrite.Size = new System.Drawing.Size(87, 37);
            this.xmlWrite.TabIndex = 9;
            this.xmlWrite.Text = "xmlWrite";
            this.xmlWrite.UseVisualStyleBackColor = true;
            // 
            // SoapWrite
            // 
            this.SoapWrite.Location = new System.Drawing.Point(303, 394);
            this.SoapWrite.Name = "SoapWrite";
            this.SoapWrite.Size = new System.Drawing.Size(84, 44);
            this.SoapWrite.TabIndex = 10;
            this.SoapWrite.Text = "SoapWrite";
            this.SoapWrite.UseVisualStyleBackColor = true;
            // 
            // soapReda
            // 
            this.soapReda.Location = new System.Drawing.Point(171, 394);
            this.soapReda.Name = "soapReda";
            this.soapReda.Size = new System.Drawing.Size(87, 44);
            this.soapReda.TabIndex = 11;
            this.soapReda.Text = "SoapRead";
            this.soapReda.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity";
            // 
            // txtquan
            // 
            this.txtquan.Location = new System.Drawing.Point(324, 246);
            this.txtquan.Name = "txtquan";
            this.txtquan.Size = new System.Drawing.Size(171, 20);
            this.txtquan.TabIndex = 13;
            // 
            // binRead
            // 
            this.binRead.Location = new System.Drawing.Point(437, 394);
            this.binRead.Name = "binRead";
            this.binRead.Size = new System.Drawing.Size(90, 44);
            this.binRead.TabIndex = 14;
            this.binRead.Text = "BnariRead";
            this.binRead.UseVisualStyleBackColor = true;
            // 
            // binWrite
            // 
            this.binWrite.Location = new System.Drawing.Point(564, 393);
            this.binWrite.Name = "binWrite";
            this.binWrite.Size = new System.Drawing.Size(86, 45);
            this.binWrite.TabIndex = 15;
            this.binWrite.Text = "BinaryWrite";
            this.binWrite.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.binWrite);
            this.Controls.Add(this.binRead);
            this.Controls.Add(this.txtquan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.soapReda);
            this.Controls.Add(this.SoapWrite);
            this.Controls.Add(this.xmlWrite);
            this.Controls.Add(this.xmlRead);
            this.Controls.Add(this.jsonWrite);
            this.Controls.Add(this.jsonRead);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpric);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Name = "Product";
            this.Text = "ProductDesign";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button jsonRead;
        private System.Windows.Forms.Button jsonWrite;
        private System.Windows.Forms.Button xmlRead;
        private System.Windows.Forms.Button xmlWrite;
        private System.Windows.Forms.Button SoapWrite;
        private System.Windows.Forms.Button soapReda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtquan;
        private System.Windows.Forms.Button binRead;
        private System.Windows.Forms.Button binWrite;
    }
}