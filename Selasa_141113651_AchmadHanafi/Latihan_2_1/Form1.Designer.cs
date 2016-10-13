namespace Latihan_2_1
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
            this.pilihbulan = new System.Windows.Forms.DomainUpDown();
            this.pilihtgl = new System.Windows.Forms.NumericUpDown();
            this.kalenderkeren = new System.Windows.Forms.MonthCalendar();
            this.tmbltambah = new System.Windows.Forms.Button();
            this.tmblhapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pilihtgl)).BeginInit();
            this.SuspendLayout();
            // 
            // pilihbulan
            // 
            this.pilihbulan.Items.Add("Januari");
            this.pilihbulan.Items.Add("Februari");
            this.pilihbulan.Items.Add("Maret");
            this.pilihbulan.Items.Add("April");
            this.pilihbulan.Items.Add("Mei");
            this.pilihbulan.Items.Add("Juni");
            this.pilihbulan.Items.Add("Juli");
            this.pilihbulan.Items.Add("Agustus");
            this.pilihbulan.Items.Add("September");
            this.pilihbulan.Items.Add("Oktober");
            this.pilihbulan.Items.Add("November");
            this.pilihbulan.Items.Add("Desember");
            this.pilihbulan.Location = new System.Drawing.Point(161, 28);
            this.pilihbulan.Name = "pilihbulan";
            this.pilihbulan.Size = new System.Drawing.Size(120, 20);
            this.pilihbulan.TabIndex = 0;
            this.pilihbulan.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // pilihtgl
            // 
            this.pilihtgl.Location = new System.Drawing.Point(12, 28);
            this.pilihtgl.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pilihtgl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pilihtgl.Name = "pilihtgl";
            this.pilihtgl.Size = new System.Drawing.Size(120, 20);
            this.pilihtgl.TabIndex = 1;
            this.pilihtgl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kalenderkeren
            // 
            this.kalenderkeren.CalendarDimensions = new System.Drawing.Size(3, 3);
            this.kalenderkeren.Location = new System.Drawing.Point(12, 87);
            this.kalenderkeren.Name = "kalenderkeren";
            this.kalenderkeren.TabIndex = 2;
            // 
            // tmbltambah
            // 
            this.tmbltambah.Location = new System.Drawing.Point(418, 24);
            this.tmbltambah.Name = "tmbltambah";
            this.tmbltambah.Size = new System.Drawing.Size(75, 23);
            this.tmbltambah.TabIndex = 3;
            this.tmbltambah.Text = "Tambah";
            this.tmbltambah.UseVisualStyleBackColor = true;
            this.tmbltambah.Click += new System.EventHandler(this.tmbltambah_Click);
            // 
            // tmblhapus
            // 
            this.tmblhapus.Location = new System.Drawing.Point(544, 24);
            this.tmblhapus.Name = "tmblhapus";
            this.tmblhapus.Size = new System.Drawing.Size(75, 23);
            this.tmblhapus.TabIndex = 3;
            this.tmblhapus.Text = "Hapus";
            this.tmblhapus.UseVisualStyleBackColor = true;
            this.tmblhapus.Click += new System.EventHandler(this.tmblhapus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 592);
            this.Controls.Add(this.tmblhapus);
            this.Controls.Add(this.tmbltambah);
            this.Controls.Add(this.kalenderkeren);
            this.Controls.Add(this.pilihtgl);
            this.Controls.Add(this.pilihbulan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Latihan_2_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pilihtgl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DomainUpDown pilihbulan;
        private System.Windows.Forms.NumericUpDown pilihtgl;
        private System.Windows.Forms.MonthCalendar kalenderkeren;
        private System.Windows.Forms.Button tmbltambah;
        private System.Windows.Forms.Button tmblhapus;
    }
}

