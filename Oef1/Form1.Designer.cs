namespace Oef1
{
    partial class Task_manager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.inputInhoud = new System.Windows.Forms.TextBox();
            this.inputDate = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.OpslaanTaak = new System.Windows.Forms.Button();
            this.volgendeTaak = new System.Windows.Forms.Button();
            this.verwijderTaak = new System.Windows.Forms.Button();
            this.ZetAchteraan = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Te doen";
            // 
            // inputTitle
            // 
            this.inputTitle.Location = new System.Drawing.Point(122, 186);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(350, 27);
            this.inputTitle.TabIndex = 1;
            // 
            // inputInhoud
            // 
            this.inputInhoud.Enabled = false;
            this.inputInhoud.Location = new System.Drawing.Point(542, 186);
            this.inputInhoud.Multiline = true;
            this.inputInhoud.Name = "inputInhoud";
            this.inputInhoud.Size = new System.Drawing.Size(499, 195);
            this.inputInhoud.TabIndex = 2;
            // 
            // inputDate
            // 
            this.inputDate.CustomFormat = "dd-MM-yyyy HH:mm";
            this.inputDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputDate.Location = new System.Drawing.Point(138, 378);
            this.inputDate.Name = "inputDate";
            this.inputDate.Size = new System.Drawing.Size(253, 27);
            this.inputDate.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(397, 378);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Time";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // OpslaanTaak
            // 
            this.OpslaanTaak.Location = new System.Drawing.Point(221, 426);
            this.OpslaanTaak.Name = "OpslaanTaak";
            this.OpslaanTaak.Size = new System.Drawing.Size(94, 29);
            this.OpslaanTaak.TabIndex = 5;
            this.OpslaanTaak.Text = "Opslaan";
            this.OpslaanTaak.UseVisualStyleBackColor = true;
            this.OpslaanTaak.Click += new System.EventHandler(this.OpslaanTaak_Click);
            // 
            // volgendeTaak
            // 
            this.volgendeTaak.Location = new System.Drawing.Point(542, 413);
            this.volgendeTaak.Name = "volgendeTaak";
            this.volgendeTaak.Size = new System.Drawing.Size(133, 29);
            this.volgendeTaak.TabIndex = 6;
            this.volgendeTaak.Text = "volgende taak";
            this.volgendeTaak.UseVisualStyleBackColor = true;
            this.volgendeTaak.Click += new System.EventHandler(this.volgendeTaak_Click);
            // 
            // verwijderTaak
            // 
            this.verwijderTaak.Location = new System.Drawing.Point(898, 413);
            this.verwijderTaak.Name = "verwijderTaak";
            this.verwijderTaak.Size = new System.Drawing.Size(133, 29);
            this.verwijderTaak.TabIndex = 7;
            this.verwijderTaak.Text = "verwijder taak";
            this.verwijderTaak.UseVisualStyleBackColor = true;
            this.verwijderTaak.Click += new System.EventHandler(this.verwijderTaak_Click);
            // 
            // ZetAchteraan
            // 
            this.ZetAchteraan.Location = new System.Drawing.Point(723, 413);
            this.ZetAchteraan.Name = "ZetAchteraan";
            this.ZetAchteraan.Size = new System.Drawing.Size(133, 29);
            this.ZetAchteraan.TabIndex = 8;
            this.ZetAchteraan.Text = "zet achteraan";
            this.ZetAchteraan.UseVisualStyleBackColor = true;
            this.ZetAchteraan.Click += new System.EventHandler(this.ZetAchteraan_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 219);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 138);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(914, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "OFF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(658, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "OFF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Message box";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(779, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "informatie venster";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(731, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Informatievenster";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 15;
            this.label5.Click += new System.EventHandler(this.label5_Tick);
            // 
            // Task_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 735);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ZetAchteraan);
            this.Controls.Add(this.verwijderTaak);
            this.Controls.Add(this.volgendeTaak);
            this.Controls.Add(this.OpslaanTaak);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.inputDate);
            this.Controls.Add(this.inputInhoud);
            this.Controls.Add(this.inputTitle);
            this.Controls.Add(this.label1);
            this.Name = "Task_manager";
            this.Text = "Task manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.TextBox inputInhoud;
        private System.Windows.Forms.DateTimePicker inputDate;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button OpslaanTaak;
        private System.Windows.Forms.Button volgendeTaak;
        private System.Windows.Forms.Button verwijderTaak;
        private System.Windows.Forms.Button ZetAchteraan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

