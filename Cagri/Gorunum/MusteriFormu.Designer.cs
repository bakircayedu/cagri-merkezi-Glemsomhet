namespace Cagri.Gorunum
{
    partial class MusteriFormu
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
            this.gboSira = new System.Windows.Forms.GroupBox();
            this.lblSira = new System.Windows.Forms.Label();
            this.dtpArama = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrMusteri = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.gboSira.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboSira
            // 
            this.gboSira.Controls.Add(this.lblSira);
            this.gboSira.Location = new System.Drawing.Point(194, 95);
            this.gboSira.Name = "gboSira";
            this.gboSira.Size = new System.Drawing.Size(164, 63);
            this.gboSira.TabIndex = 11;
            this.gboSira.TabStop = false;
            this.gboSira.Text = "Sıra numaranız:";
            this.gboSira.Visible = false;
            // 
            // lblSira
            // 
            this.lblSira.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSira.ForeColor = System.Drawing.Color.Brown;
            this.lblSira.Location = new System.Drawing.Point(6, 23);
            this.lblSira.Name = "lblSira";
            this.lblSira.Size = new System.Drawing.Size(152, 37);
            this.lblSira.TabIndex = 0;
            this.lblSira.Text = "-1";
            this.lblSira.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpArama
            // 
            this.dtpArama.CustomFormat = "HH:MM:SS";
            this.dtpArama.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpArama.Location = new System.Drawing.Point(209, 37);
            this.dtpArama.Margin = new System.Windows.Forms.Padding(4);
            this.dtpArama.Name = "dtpArama";
            this.dtpArama.ShowUpDown = true;
            this.dtpArama.Size = new System.Drawing.Size(124, 22);
            this.dtpArama.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Arama &zamanı: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(340, 13);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(150, 75);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "&Arama yap!";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(208, 13);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.MaxLength = 20;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(124, 22);
            this.txtId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "&Müşteri tanımlayıcısı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrMusteri
            // 
            this.tmrMusteri.Interval = 500;
            this.tmrMusteri.Tick += new System.EventHandler(this.tmrMusteri_Tick);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "&Ad soyad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(209, 65);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(123, 22);
            this.txtAd.TabIndex = 13;
            this.txtAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MusteriFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 173);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gboSira);
            this.Controls.Add(this.dtpArama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "MusteriFormu";
            this.Text = "Müşteri";
            this.gboSira.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboSira;
        private System.Windows.Forms.Label lblSira;
        private System.Windows.Forms.DateTimePicker dtpArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrMusteri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
    }
}