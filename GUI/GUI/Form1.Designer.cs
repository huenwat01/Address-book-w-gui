
namespace GUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.creat = new System.Windows.Forms.RadioButton();
            this.delete = new System.Windows.Forms.RadioButton();
            this.LookoneRecord = new System.Windows.Forms.RadioButton();
            this.checkall = new System.Windows.Forms.RadioButton();
            this.initialize = new System.Windows.Forms.RadioButton();
            this.confirm = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Quit = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Quit);
            this.groupBox1.Controls.Add(this.creat);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.LookoneRecord);
            this.groupBox1.Controls.Add(this.checkall);
            this.groupBox1.Controls.Add(this.initialize);
            this.groupBox1.Location = new System.Drawing.Point(252, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choice";
            // 
            // creat
            // 
            this.creat.AutoSize = true;
            this.creat.Location = new System.Drawing.Point(7, 69);
            this.creat.Name = "creat";
            this.creat.Size = new System.Drawing.Size(178, 17);
            this.creat.TabIndex = 4;
            this.creat.TabStop = true;
            this.creat.Text = "Creat person contact information";
            this.creat.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Location = new System.Drawing.Point(7, 140);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(193, 17);
            this.delete.TabIndex = 3;
            this.delete.TabStop = true;
            this.delete.Text = "Remove person contact information";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // LookoneRecord
            // 
            this.LookoneRecord.AutoSize = true;
            this.LookoneRecord.Location = new System.Drawing.Point(7, 103);
            this.LookoneRecord.Name = "LookoneRecord";
            this.LookoneRecord.Size = new System.Drawing.Size(189, 17);
            this.LookoneRecord.TabIndex = 2;
            this.LookoneRecord.TabStop = true;
            this.LookoneRecord.Text = "Lookup person contact information";
            this.LookoneRecord.UseVisualStyleBackColor = true;
            // 
            // checkall
            // 
            this.checkall.AutoSize = true;
            this.checkall.Location = new System.Drawing.Point(7, 173);
            this.checkall.Name = "checkall";
            this.checkall.Size = new System.Drawing.Size(202, 17);
            this.checkall.TabIndex = 1;
            this.checkall.TabStop = true;
            this.checkall.Text = "Lookup all person contact information";
            this.checkall.UseVisualStyleBackColor = true;
            // 
            // initialize
            // 
            this.initialize.AutoSize = true;
            this.initialize.Location = new System.Drawing.Point(7, 36);
            this.initialize.Name = "initialize";
            this.initialize.Size = new System.Drawing.Size(147, 17);
            this.initialize.TabIndex = 0;
            this.initialize.TabStop = true;
            this.initialize.Text = "Initialize the address book";
            this.initialize.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(359, 319);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 1;
            this.confirm.Text = "Ok";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Quit
            // 
            this.Quit.AutoSize = true;
            this.Quit.Location = new System.Drawing.Point(7, 196);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(44, 17);
            this.Quit.TabIndex = 5;
            this.Quit.TabStop = true;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton initialize;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.RadioButton checkall;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton LookoneRecord;
        private System.Windows.Forms.RadioButton delete;
        private System.Windows.Forms.RadioButton creat;
        private System.Windows.Forms.RadioButton Quit;
    }
}

