using System.Windows.Forms;

namespace oku_Yaz
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
            this.btnBasla = new System.Windows.Forms.Button();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmax = new System.Windows.Forms.Label();
            this.lblnow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCık = new System.Windows.Forms.Button();
            this.lblGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBasla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(419, 405);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(669, 85);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Başlat";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKelime
            // 
            this.txtKelime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKelime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKelime.Location = new System.Drawing.Point(191, 283);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(1176, 83);
            this.txtKelime.TabIndex = 2;
            this.txtKelime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKelime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tüm Yazılan Kelime Sayısı:";
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmax.Location = new System.Drawing.Point(298, 58);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(23, 25);
            this.lblmax.TabIndex = 4;
            this.lblmax.Text = "0";
            // 
            // lblnow
            // 
            this.lblnow.AutoSize = true;
            this.lblnow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblnow.Location = new System.Drawing.Point(298, 107);
            this.lblnow.Name = "lblnow";
            this.lblnow.Size = new System.Drawing.Size(23, 25);
            this.lblnow.TabIndex = 6;
            this.lblnow.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "En Son Yazılan Kelime Sayısı:";
            // 
            // lblCık
            // 
            this.lblCık.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCık.AutoSize = true;
            this.lblCık.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCık.Location = new System.Drawing.Point(1382, 9);
            this.lblCık.Name = "lblCık";
            this.lblCık.Size = new System.Drawing.Size(51, 35);
            this.lblCık.TabIndex = 7;
            this.lblCık.Text = "Çık";
            this.lblCık.Click += new System.EventHandler(this.lblCık_Click);
            // 
            // lblGeri
            // 
            this.lblGeri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGeri.AutoSize = true;
            this.lblGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGeri.Location = new System.Drawing.Point(1318, 9);
            this.lblGeri.Name = "lblGeri";
            this.lblGeri.Size = new System.Drawing.Size(58, 35);
            this.lblGeri.TabIndex = 8;
            this.lblGeri.Text = "Geri";
            this.lblGeri.Click += new System.EventHandler(this.lblGeri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1445, 591);
            this.Controls.Add(this.lblGeri);
            this.Controls.Add(this.lblCık);
            this.Controls.Add(this.lblnow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblmax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKelime);
            this.Controls.Add(this.btnBasla);
            this.Name = "Form1";
            this.Text = "Kelime Yazma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public static void show()
        {
            //Form1 frm = new Form1();
            //frm.Visible = true;
            //frm.Show();
        }
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmax;
        private System.Windows.Forms.Label lblnow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button lblGeri;
        private System.Windows.Forms.Button lblCık;
    }
}

