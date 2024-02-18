
namespace GUI
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bypno = new System.Windows.Forms.RadioButton();
            this.byemail = new System.Windows.Forms.RadioButton();
            this.byname = new System.Windows.Forms.RadioButton();
            this.showname = new System.Windows.Forms.TextBox();
            this.showemail = new System.Windows.Forms.TextBox();
            this.showpno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bypno);
            this.groupBox1.Controls.Add(this.byemail);
            this.groupBox1.Controls.Add(this.byname);
            this.groupBox1.Location = new System.Drawing.Point(107, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choice";
            // 
            // bypno
            // 
            this.bypno.AutoSize = true;
            this.bypno.Location = new System.Drawing.Point(7, 149);
            this.bypno.Name = "bypno";
            this.bypno.Size = new System.Drawing.Size(131, 17);
            this.bypno.TabIndex = 2;
            this.bypno.TabStop = true;
            this.bypno.Text = "By Telephone Number";
            this.bypno.UseVisualStyleBackColor = true;
            // 
            // byemail
            // 
            this.byemail.AutoSize = true;
            this.byemail.Location = new System.Drawing.Point(7, 99);
            this.byemail.Name = "byemail";
            this.byemail.Size = new System.Drawing.Size(109, 17);
            this.byemail.TabIndex = 1;
            this.byemail.TabStop = true;
            this.byemail.Text = "By E-mail Address";
            this.byemail.UseVisualStyleBackColor = true;
            // 
            // byname
            // 
            this.byname.AutoSize = true;
            this.byname.Location = new System.Drawing.Point(7, 43);
            this.byname.Name = "byname";
            this.byname.Size = new System.Drawing.Size(87, 17);
            this.byname.TabIndex = 0;
            this.byname.TabStop = true;
            this.byname.Text = "By Full Name";
            this.byname.UseVisualStyleBackColor = true;
            // 
            // showname
            // 
            this.showname.Location = new System.Drawing.Point(344, 129);
            this.showname.Name = "showname";
            this.showname.Size = new System.Drawing.Size(223, 20);
            this.showname.TabIndex = 1;
            // 
            // showemail
            // 
            this.showemail.Location = new System.Drawing.Point(344, 185);
            this.showemail.Name = "showemail";
            this.showemail.Size = new System.Drawing.Size(223, 20);
            this.showemail.TabIndex = 2;
            // 
            // showpno
            // 
            this.showpno.Location = new System.Drawing.Point(344, 235);
            this.showpno.Name = "showpno";
            this.showpno.Size = new System.Drawing.Size(223, 20);
            this.showpno.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(491, 311);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 5;
            this.close.Text = "OK";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showpno);
            this.Controls.Add(this.showemail);
            this.Controls.Add(this.showname);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bypno;
        private System.Windows.Forms.RadioButton byemail;
        private System.Windows.Forms.RadioButton byname;
        private System.Windows.Forms.TextBox showname;
        private System.Windows.Forms.TextBox showemail;
        private System.Windows.Forms.TextBox showpno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
    }
}