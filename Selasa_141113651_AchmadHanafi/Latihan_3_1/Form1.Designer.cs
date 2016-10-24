namespace Latihan_3_1
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
            this.bolot = new System.Windows.Forms.Button();
            this.miring = new System.Windows.Forms.Button();
            this.bawahgaris = new System.Windows.Forms.Button();
            this.warna = new System.Windows.Forms.Button();
            this.jenisfont = new System.Windows.Forms.ComboBox();
            this.ukurannya = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.warnadialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // bolot
            // 
            this.bolot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bolot.Location = new System.Drawing.Point(12, 24);
            this.bolot.Name = "bolot";
            this.bolot.Size = new System.Drawing.Size(47, 34);
            this.bolot.TabIndex = 0;
            this.bolot.Text = "B";
            this.bolot.UseVisualStyleBackColor = true;
            this.bolot.Click += new System.EventHandler(this.bolot_Click);
            // 
            // miring
            // 
            this.miring.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miring.Location = new System.Drawing.Point(65, 24);
            this.miring.Name = "miring";
            this.miring.Size = new System.Drawing.Size(47, 34);
            this.miring.TabIndex = 0;
            this.miring.Text = "/";
            this.miring.UseVisualStyleBackColor = true;
            this.miring.Click += new System.EventHandler(this.miring_Click);
            // 
            // bawahgaris
            // 
            this.bawahgaris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bawahgaris.Location = new System.Drawing.Point(118, 24);
            this.bawahgaris.Name = "bawahgaris";
            this.bawahgaris.Size = new System.Drawing.Size(47, 34);
            this.bawahgaris.TabIndex = 0;
            this.bawahgaris.Text = "U";
            this.bawahgaris.UseVisualStyleBackColor = true;
            this.bawahgaris.Click += new System.EventHandler(this.bawahgaris_Click);
            // 
            // warna
            // 
            this.warna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warna.Location = new System.Drawing.Point(171, 24);
            this.warna.Name = "warna";
            this.warna.Size = new System.Drawing.Size(82, 34);
            this.warna.TabIndex = 0;
            this.warna.Text = "Color";
            this.warna.UseVisualStyleBackColor = true;
            this.warna.Click += new System.EventHandler(this.warna_Click);
            // 
            // jenisfont
            // 
            this.jenisfont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenisfont.FormattingEnabled = true;
            this.jenisfont.Location = new System.Drawing.Point(270, 29);
            this.jenisfont.Name = "jenisfont";
            this.jenisfont.Size = new System.Drawing.Size(140, 26);
            this.jenisfont.TabIndex = 1;
            this.jenisfont.SelectedIndexChanged += new System.EventHandler(this.jenisfont_SelectedIndexChanged);
            // 
            // ukurannya
            // 
            this.ukurannya.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ukurannya.FormattingEnabled = true;
            this.ukurannya.Location = new System.Drawing.Point(425, 29);
            this.ukurannya.Name = "ukurannya";
            this.ukurannya.Size = new System.Drawing.Size(52, 26);
            this.ukurannya.TabIndex = 1;
            this.ukurannya.SelectedIndexChanged += new System.EventHandler(this.ukurannya_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(465, 351);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 442);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ukurannya);
            this.Controls.Add(this.jenisfont);
            this.Controls.Add(this.warna);
            this.Controls.Add(this.bawahgaris);
            this.Controls.Add(this.miring);
            this.Controls.Add(this.bolot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Latihan_3_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bolot;
        private System.Windows.Forms.Button miring;
        private System.Windows.Forms.Button bawahgaris;
        private System.Windows.Forms.Button warna;
        private System.Windows.Forms.ComboBox jenisfont;
        private System.Windows.Forms.ComboBox ukurannya;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ColorDialog warnadialog;
    }
}

