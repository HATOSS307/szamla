namespace szamlak
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
            this.listBox1_adatok = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.textBox1_tulajdonosNeve = new System.Windows.Forms.TextBox();
            this.numericUpDown1_egyenleg = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1_nyitasdatum = new System.Windows.Forms.DateTimePicker();
            this.button1_new = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_egyenleg)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1_adatok
            // 
            this.listBox1_adatok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1_adatok.FormattingEnabled = true;
            this.listBox1_adatok.Location = new System.Drawing.Point(0, 0);
            this.listBox1_adatok.Name = "listBox1_adatok";
            this.listBox1_adatok.Size = new System.Drawing.Size(205, 393);
            this.listBox1_adatok.TabIndex = 0;
            this.listBox1_adatok.SelectedIndexChanged += new System.EventHandler(this.listBox1_adatok_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tulajdonos neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "egyenleg:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "nyitásdátum:";
            // 
            // textBox1_id
            // 
            this.textBox1_id.Location = new System.Drawing.Point(323, 61);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.Size = new System.Drawing.Size(100, 20);
            this.textBox1_id.TabIndex = 5;
            // 
            // textBox1_tulajdonosNeve
            // 
            this.textBox1_tulajdonosNeve.Location = new System.Drawing.Point(322, 94);
            this.textBox1_tulajdonosNeve.Name = "textBox1_tulajdonosNeve";
            this.textBox1_tulajdonosNeve.Size = new System.Drawing.Size(100, 20);
            this.textBox1_tulajdonosNeve.TabIndex = 6;
            // 
            // numericUpDown1_egyenleg
            // 
            this.numericUpDown1_egyenleg.Location = new System.Drawing.Point(322, 126);
            this.numericUpDown1_egyenleg.Name = "numericUpDown1_egyenleg";
            this.numericUpDown1_egyenleg.Size = new System.Drawing.Size(101, 20);
            this.numericUpDown1_egyenleg.TabIndex = 7;
            // 
            // dateTimePicker1_nyitasdatum
            // 
            this.dateTimePicker1_nyitasdatum.Location = new System.Drawing.Point(323, 157);
            this.dateTimePicker1_nyitasdatum.Name = "dateTimePicker1_nyitasdatum";
            this.dateTimePicker1_nyitasdatum.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker1_nyitasdatum.TabIndex = 8;
            // 
            // button1_new
            // 
            this.button1_new.Location = new System.Drawing.Point(237, 224);
            this.button1_new.Name = "button1_new";
            this.button1_new.Size = new System.Drawing.Size(122, 28);
            this.button1_new.TabIndex = 9;
            this.button1_new.Text = "Új adat";
            this.button1_new.UseVisualStyleBackColor = true;
            this.button1_new.Click += new System.EventHandler(this.button1_new_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(237, 258);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(122, 28);
            this.edit.TabIndex = 10;
            this.edit.Text = "Módosítás";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(237, 292);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(122, 28);
            this.delete.TabIndex = 11;
            this.delete.Text = "Törlés";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 393);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.button1_new);
            this.Controls.Add(this.dateTimePicker1_nyitasdatum);
            this.Controls.Add(this.numericUpDown1_egyenleg);
            this.Controls.Add(this.textBox1_tulajdonosNeve);
            this.Controls.Add(this.textBox1_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1_adatok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_egyenleg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1_adatok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_id;
        private System.Windows.Forms.TextBox textBox1_tulajdonosNeve;
        private System.Windows.Forms.NumericUpDown numericUpDown1_egyenleg;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_nyitasdatum;
        private System.Windows.Forms.Button button1_new;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
    }
}

