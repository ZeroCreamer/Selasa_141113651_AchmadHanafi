namespace Latihan_1_1
{
    partial class Latihan_1_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Latihan_1_1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.vsmaax = new System.Windows.Forms.VScrollBar();
            this.vsmiin = new System.Windows.Forms.VScrollBar();
            this.ambiltanggal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmiin = new System.Windows.Forms.Label();
            this.lblmaax = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.ico");
            this.imageList1.Images.SetKeyName(1, "2.ico");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(362, 317);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblmaax);
            this.tabPage1.Controls.Add(this.lblmiin);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.vsmaax);
            this.tabPage1.Controls.Add(this.vsmiin);
            this.tabPage1.Controls.Add(this.ambiltanggal);
            this.tabPage1.ImageKey = "2.ico";
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(354, 290);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kalender";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageKey = "1.ico";
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(354, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // vsmaax
            // 
            this.vsmaax.LargeChange = 1;
            this.vsmaax.Location = new System.Drawing.Point(209, 81);
            this.vsmaax.Maximum = 10;
            this.vsmaax.Name = "vsmaax";
            this.vsmaax.Size = new System.Drawing.Size(28, 174);
            this.vsmaax.TabIndex = 1;
            this.vsmaax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsmaax_Scroll);
            // 
            // vsmiin
            // 
            this.vsmiin.LargeChange = 1;
            this.vsmiin.Location = new System.Drawing.Point(37, 81);
            this.vsmiin.Maximum = 10;
            this.vsmiin.Name = "vsmiin";
            this.vsmiin.Size = new System.Drawing.Size(28, 174);
            this.vsmiin.TabIndex = 0;
            this.vsmiin.Value = 10;
            this.vsmiin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsmiin_Scroll);
            // 
            // ambiltanggal
            // 
            this.ambiltanggal.Location = new System.Drawing.Point(37, 19);
            this.ambiltanggal.Name = "ambiltanggal";
            this.ambiltanggal.Size = new System.Drawing.Size(200, 20);
            this.ambiltanggal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "MIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "MAX";
            // 
            // lblmiin
            // 
            this.lblmiin.AutoSize = true;
            this.lblmiin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmiin.Location = new System.Drawing.Point(42, 264);
            this.lblmiin.Name = "lblmiin";
            this.lblmiin.Size = new System.Drawing.Size(17, 17);
            this.lblmiin.TabIndex = 8;
            this.lblmiin.Text = "0";
            // 
            // lblmaax
            // 
            this.lblmaax.AutoSize = true;
            this.lblmaax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaax.Location = new System.Drawing.Point(208, 264);
            this.lblmaax.Name = "lblmaax";
            this.lblmaax.Size = new System.Drawing.Size(26, 17);
            this.lblmaax.TabIndex = 9;
            this.lblmaax.Text = "10";
            // 
            // Latihan_1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 341);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Latihan_1_1";
            this.Text = "Selasa_141113651_AchmadHanafi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.VScrollBar vsmaax;
        private System.Windows.Forms.VScrollBar vsmiin;
        private System.Windows.Forms.DateTimePicker ambiltanggal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmaax;
        private System.Windows.Forms.Label lblmiin;
    }
}

