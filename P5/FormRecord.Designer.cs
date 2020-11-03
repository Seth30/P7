namespace P5
{
    partial class FormRecord
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
            this.IDbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Titlebox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.discovererbox = new System.Windows.Forms.ComboBox();
            this.statusbox = new System.Windows.Forms.ComboBox();
            this.descriptbox = new System.Windows.Forms.TextBox();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.createbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDbox
            // 
            this.IDbox.Enabled = false;
            this.IDbox.Location = new System.Drawing.Point(104, 70);
            this.IDbox.Name = "IDbox";
            this.IDbox.ReadOnly = true;
            this.IDbox.Size = new System.Drawing.Size(71, 20);
            this.IDbox.TabIndex = 0;
            this.IDbox.Tag = "";
            this.IDbox.Text = "CHANGE ME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title:";
            // 
            // Titlebox
            // 
            this.Titlebox.Location = new System.Drawing.Point(104, 96);
            this.Titlebox.Name = "Titlebox";
            this.Titlebox.Size = new System.Drawing.Size(333, 20);
            this.Titlebox.TabIndex = 4;
            this.Titlebox.Tag = "";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(333, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Tag = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(332, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // discovererbox
            // 
            this.discovererbox.FormattingEnabled = true;
            this.discovererbox.Location = new System.Drawing.Point(104, 147);
            this.discovererbox.Name = "discovererbox";
            this.discovererbox.Size = new System.Drawing.Size(333, 21);
            this.discovererbox.TabIndex = 10;
            // 
            // statusbox
            // 
            this.statusbox.FormattingEnabled = true;
            this.statusbox.Location = new System.Drawing.Point(104, 199);
            this.statusbox.Name = "statusbox";
            this.statusbox.Size = new System.Drawing.Size(333, 21);
            this.statusbox.TabIndex = 11;
            // 
            // descriptbox
            // 
            this.descriptbox.Location = new System.Drawing.Point(104, 263);
            this.descriptbox.Multiline = true;
            this.descriptbox.Name = "descriptbox";
            this.descriptbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.descriptbox.Size = new System.Drawing.Size(333, 240);
            this.descriptbox.TabIndex = 12;
            this.descriptbox.Tag = "";
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(185, 521);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(111, 23);
            this.cancelbutton.TabIndex = 13;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // createbutton
            // 
            this.createbutton.Location = new System.Drawing.Point(325, 521);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(111, 23);
            this.createbutton.TabIndex = 14;
            this.createbutton.Text = "Create Issue";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Component:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Discoverer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Initial Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Discovery Date:";
            // 
            // FormRecord
            // 
            this.AcceptButton = this.createbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 591);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.descriptbox);
            this.Controls.Add(this.statusbox);
            this.Controls.Add(this.discovererbox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Titlebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDbox);
            this.Name = "FormRecord";
            this.Text = "Record Issue";
            this.Load += new System.EventHandler(this.Record_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Titlebox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox discovererbox;
        private System.Windows.Forms.ComboBox statusbox;
        private System.Windows.Forms.TextBox descriptbox;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}