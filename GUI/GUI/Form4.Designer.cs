
namespace GUI
{
    partial class Form4
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
            this.byname2 = new System.Windows.Forms.RadioButton();
            this.byemail2 = new System.Windows.Forms.RadioButton();
            this.bypno2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.showname2 = new System.Windows.Forms.TextBox();
            this.showemail2 = new System.Windows.Forms.TextBox();
            this.showpno2 = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bypno2);
            this.groupBox1.Controls.Add(this.byemail2);
            this.groupBox1.Controls.Add(this.byname2);
            this.groupBox1.Location = new System.Drawing.Point(103, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choice";
            // 
            // byname2
            // 
            this.byname2.AutoSize = true;
            this.byname2.Location = new System.Drawing.Point(7, 39);
            this.byname2.Name = "byname2";
            this.byname2.Size = new System.Drawing.Size(87, 17);
            this.byname2.TabIndex = 0;
            this.byname2.TabStop = true;
            this.byname2.Text = "By Full Name";
            this.byname2.UseVisualStyleBackColor = true;
            // 
            // byemail2
            // 
            this.byemail2.AutoSize = true;
            this.byemail2.Location = new System.Drawing.Point(7, 93);
            this.byemail2.Name = "byemail2";
            this.byemail2.Size = new System.Drawing.Size(109, 17);
            this.byemail2.TabIndex = 1;
            this.byemail2.TabStop = true;
            this.byemail2.Text = "By E-mail Address";
            this.byemail2.UseVisualStyleBackColor = true;
            // 
            // bypno2
            // 
            this.bypno2.AutoSize = true;
            this.bypno2.Location = new System.Drawing.Point(7, 140);
            this.bypno2.Name = "bypno2";
            this.bypno2.Size = new System.Drawing.Size(131, 17);
            this.bypno2.TabIndex = 2;
            this.bypno2.TabStop = true;
            this.bypno2.Text = "By Telephone Number";
            this.bypno2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // showname2
            // 
            this.showname2.Location = new System.Drawing.Point(375, 130);
            this.showname2.Name = "showname2";
            this.showname2.Size = new System.Drawing.Size(236, 20);
            this.showname2.TabIndex = 2;
            // 
            // showemail2
            // 
            this.showemail2.Location = new System.Drawing.Point(375, 184);
            this.showemail2.Name = "showemail2";
            this.showemail2.Size = new System.Drawing.Size(236, 20);
            this.showemail2.TabIndex = 3;
            // 
            // showpno2
            // 
            this.showpno2.Location = new System.Drawing.Point(375, 231);
            this.showpno2.Name = "showpno2";
            this.showpno2.Size = new System.Drawing.Size(236, 20);
            this.showpno2.TabIndex = 4;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(536, 300);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 5;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.showpno2);
            this.Controls.Add(this.showemail2);
            this.Controls.Add(this.showname2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bypno2;
        private System.Windows.Forms.RadioButton byemail2;
        private System.Windows.Forms.RadioButton byname2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox showname2;
        private System.Windows.Forms.TextBox showemail2;
        private System.Windows.Forms.TextBox showpno2;
        private System.Windows.Forms.Button delete;
    }
}