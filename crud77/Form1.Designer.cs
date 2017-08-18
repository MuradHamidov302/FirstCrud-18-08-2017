namespace crud77
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
            this.Ad = new System.Windows.Forms.TextBox();
            this.Soyad = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.idData = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(20, 58);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(100, 20);
            this.Ad.TabIndex = 0;
            // 
            // Soyad
            // 
            this.Soyad.Location = new System.Drawing.Point(20, 97);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(100, 20);
            this.Soyad.TabIndex = 1;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(20, 138);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(100, 20);
            this.Age.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yash";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(233, 165);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 53);
            this.add.TabIndex = 6;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // idData
            // 
            this.idData.FormattingEnabled = true;
            this.idData.Location = new System.Drawing.Point(233, 60);
            this.idData.Name = "idData";
            this.idData.Size = new System.Drawing.Size(100, 21);
            this.idData.TabIndex = 7;
            this.idData.SelectedIndexChanged += new System.EventHandler(this.idData_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "idData";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(233, 87);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 33);
            this.update.TabIndex = 9;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Ad);
            this.panel1.Controls.Add(this.Soyad);
            this.panel1.Controls.Add(this.Age);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 206);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(37, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "CRUD";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(233, 126);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 33);
            this.delete.TabIndex = 11;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 229);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idData);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.TextBox Soyad;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox idData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label5;
    }
}

