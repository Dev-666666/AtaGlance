namespace serialization_Demo
{
    partial class ProductDemo
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
            this.binaryread = new System.Windows.Forms.Button();
            this.binarywrite = new System.Windows.Forms.Button();
            this.jsonread = new System.Windows.Forms.Button();
            this.jsonwrite = new System.Windows.Forms.Button();
            this.xmlread = new System.Windows.Forms.Button();
            this.xmlwrite = new System.Windows.Forms.Button();
            this.sopread = new System.Windows.Forms.Button();
            this.sopwrite = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlocatoion = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // binaryread
            // 
            this.binaryread.Location = new System.Drawing.Point(85, 270);
            this.binaryread.Name = "binaryread";
            this.binaryread.Size = new System.Drawing.Size(78, 39);
            this.binaryread.TabIndex = 0;
            this.binaryread.Text = "BinaryRead";
            this.binaryread.UseVisualStyleBackColor = true;
            this.binaryread.Click += new System.EventHandler(this.binaryread_Click);
            // 
            // binarywrite
            // 
            this.binarywrite.Location = new System.Drawing.Point(214, 269);
            this.binarywrite.Name = "binarywrite";
            this.binarywrite.Size = new System.Drawing.Size(87, 40);
            this.binarywrite.TabIndex = 1;
            this.binarywrite.Text = "BinaryWrite";
            this.binarywrite.UseVisualStyleBackColor = true;
            this.binarywrite.Click += new System.EventHandler(this.binarywrite_Click);
            // 
            // jsonread
            // 
            this.jsonread.Location = new System.Drawing.Point(347, 270);
            this.jsonread.Name = "jsonread";
            this.jsonread.Size = new System.Drawing.Size(89, 39);
            this.jsonread.TabIndex = 2;
            this.jsonread.Text = "JsonRead";
            this.jsonread.UseVisualStyleBackColor = true;
            this.jsonread.Click += new System.EventHandler(this.jsonread_Click);
            // 
            // jsonwrite
            // 
            this.jsonwrite.Location = new System.Drawing.Point(475, 270);
            this.jsonwrite.Name = "jsonwrite";
            this.jsonwrite.Size = new System.Drawing.Size(92, 38);
            this.jsonwrite.TabIndex = 3;
            this.jsonwrite.Text = "JsonWrite";
            this.jsonwrite.UseVisualStyleBackColor = true;
            this.jsonwrite.Click += new System.EventHandler(this.jsonwrite_Click);
            // 
            // xmlread
            // 
            this.xmlread.Location = new System.Drawing.Point(85, 352);
            this.xmlread.Name = "xmlread";
            this.xmlread.Size = new System.Drawing.Size(79, 44);
            this.xmlread.TabIndex = 4;
            this.xmlread.Text = "XMLRead";
            this.xmlread.UseVisualStyleBackColor = true;
            this.xmlread.Click += new System.EventHandler(this.xmlread_Click);
            // 
            // xmlwrite
            // 
            this.xmlwrite.Location = new System.Drawing.Point(214, 352);
            this.xmlwrite.Name = "xmlwrite";
            this.xmlwrite.Size = new System.Drawing.Size(87, 44);
            this.xmlwrite.TabIndex = 5;
            this.xmlwrite.Text = "XMLWrite";
            this.xmlwrite.UseVisualStyleBackColor = true;
            this.xmlwrite.Click += new System.EventHandler(this.xmlwrite_Click);
            // 
            // sopread
            // 
            this.sopread.Location = new System.Drawing.Point(347, 348);
            this.sopread.Name = "sopread";
            this.sopread.Size = new System.Drawing.Size(89, 44);
            this.sopread.TabIndex = 6;
            this.sopread.Text = "SOAPRead";
            this.sopread.UseVisualStyleBackColor = true;
            this.sopread.Click += new System.EventHandler(this.sopread_Click);
            // 
            // sopwrite
            // 
            this.sopwrite.Location = new System.Drawing.Point(477, 350);
            this.sopwrite.Name = "sopwrite";
            this.sopwrite.Size = new System.Drawing.Size(90, 44);
            this.sopwrite.TabIndex = 7;
            this.sopwrite.Text = "SOAP Write";
            this.sopwrite.UseVisualStyleBackColor = true;
            this.sopwrite.Click += new System.EventHandler(this.sopwrite_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(323, 63);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(232, 20);
            this.txtId.TabIndex = 8;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(323, 125);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(239, 20);
            this.txtname.TabIndex = 9;
            // 
            // txtlocatoion
            // 
            this.txtlocatoion.Location = new System.Drawing.Point(323, 182);
            this.txtlocatoion.Name = "txtlocatoion";
            this.txtlocatoion.Size = new System.Drawing.Size(244, 20);
            this.txtlocatoion.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(129, 70);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(61, 13);
            this.ID.TabIndex = 11;
            this.ID.Text = "Product_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Product_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Product_Location";
            // 
            // ProductDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 588);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtlocatoion);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.sopwrite);
            this.Controls.Add(this.sopread);
            this.Controls.Add(this.xmlwrite);
            this.Controls.Add(this.xmlread);
            this.Controls.Add(this.jsonwrite);
            this.Controls.Add(this.jsonread);
            this.Controls.Add(this.binarywrite);
            this.Controls.Add(this.binaryread);
            this.Name = "ProductDemo";
            this.Text = "ProductDesign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button binaryread;
        private System.Windows.Forms.Button binarywrite;
        private System.Windows.Forms.Button jsonread;
        private System.Windows.Forms.Button jsonwrite;
        private System.Windows.Forms.Button xmlread;
        private System.Windows.Forms.Button xmlwrite;
        private System.Windows.Forms.Button sopread;
        private System.Windows.Forms.Button sopwrite;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlocatoion;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}