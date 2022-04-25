namespace Cagri.Gorunum
{
    partial class SekreterFormu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstTemsilci = new System.Windows.Forms.ListBox();
            this.lstBekleyen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAktar = new System.Windows.Forms.Button();
            this.btnKuyruk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tmrSekreter = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtSiradaki = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstTemsilci);
            this.groupBox1.Location = new System.Drawing.Point(255, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 179);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Temsilcileri";
            // 
            // lstTemsilci
            // 
            this.lstTemsilci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstTemsilci.FormattingEnabled = true;
            this.lstTemsilci.ItemHeight = 20;
            this.lstTemsilci.Location = new System.Drawing.Point(9, 37);
            this.lstTemsilci.Name = "lstTemsilci";
            this.lstTemsilci.Size = new System.Drawing.Size(182, 124);
            this.lstTemsilci.TabIndex = 1;
            // 
            // lstBekleyen
            // 
            this.lstBekleyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstBekleyen.FormattingEnabled = true;
            this.lstBekleyen.ItemHeight = 20;
            this.lstBekleyen.Location = new System.Drawing.Point(12, 83);
            this.lstBekleyen.Name = "lstBekleyen";
            this.lstBekleyen.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstBekleyen.Size = new System.Drawing.Size(237, 204);
            this.lstBekleyen.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bekleyen &çağrılar:";
            // 
            // btnAktar
            // 
            this.btnAktar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAktar.FlatAppearance.BorderSize = 0;
            this.btnAktar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnAktar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktar.Location = new System.Drawing.Point(458, 209);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(129, 78);
            this.btnAktar.TabIndex = 9;
            this.btnAktar.Text = "Doğrudan &Temsilciye Aktar";
            this.btnAktar.UseVisualStyleBackColor = false;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // btnKuyruk
            // 
            this.btnKuyruk.BackColor = System.Drawing.Color.LightCoral;
            this.btnKuyruk.FlatAppearance.BorderSize = 0;
            this.btnKuyruk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKuyruk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnKuyruk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKuyruk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKuyruk.Location = new System.Drawing.Point(458, 125);
            this.btnKuyruk.Name = "btnKuyruk";
            this.btnKuyruk.Size = new System.Drawing.Size(129, 78);
            this.btnKuyruk.TabIndex = 8;
            this.btnKuyruk.Text = "Temsilci &Kuyruğuna Aktar";
            this.btnKuyruk.UseVisualStyleBackColor = false;
            this.btnKuyruk.Click += new System.EventHandler(this.btnKuyruk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "&Notlar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 79);
            this.textBox1.TabIndex = 11;
            // 
            // tmrSekreter
            // 
            this.tmrSekreter.Interval = 1000;
            this.tmrSekreter.Tick += new System.EventHandler(this.tmrSekreter_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sıradaki: ";
            // 
            // txtSiradaki
            // 
            this.txtSiradaki.Location = new System.Drawing.Point(12, 23);
            this.txtSiradaki.Name = "txtSiradaki";
            this.txtSiradaki.ReadOnly = true;
            this.txtSiradaki.Size = new System.Drawing.Size(237, 22);
            this.txtSiradaki.TabIndex = 13;
            // 
            // SekreterFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 299);
            this.Controls.Add(this.txtSiradaki);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstBekleyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.btnKuyruk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SekreterFormu";
            this.Text = "Sekreter";
            this.Load += new System.EventHandler(this.SekreterFormu_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstTemsilci;
        private System.Windows.Forms.ListBox lstBekleyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Button btnKuyruk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer tmrSekreter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSiradaki;
    }
}