namespace Cagri.Gorunum
{
    partial class MusteriTemsilcisiFormu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSiradaki = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCagrilar = new System.Windows.Forms.ListBox();
            this.btnBitir = new System.Windows.Forms.Button();
            this.btnGorus = new System.Windows.Forms.Button();
            this.tmrTemsilci = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Görüşülen Müşteri:";
            // 
            // txtSiradaki
            // 
            this.txtSiradaki.Location = new System.Drawing.Point(135, 6);
            this.txtSiradaki.Name = "txtSiradaki";
            this.txtSiradaki.ReadOnly = true;
            this.txtSiradaki.Size = new System.Drawing.Size(225, 22);
            this.txtSiradaki.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sıradaki Müşteriler:";
            // 
            // lstCagrilar
            // 
            this.lstCagrilar.FormattingEnabled = true;
            this.lstCagrilar.ItemHeight = 16;
            this.lstCagrilar.Location = new System.Drawing.Point(15, 63);
            this.lstCagrilar.Name = "lstCagrilar";
            this.lstCagrilar.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstCagrilar.Size = new System.Drawing.Size(243, 196);
            this.lstCagrilar.TabIndex = 3;
            // 
            // btnBitir
            // 
            this.btnBitir.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnBitir.Location = new System.Drawing.Point(264, 63);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(96, 72);
            this.btnBitir.TabIndex = 4;
            this.btnBitir.Text = "Görüşmeyi &Bitir";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // btnGorus
            // 
            this.btnGorus.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnGorus.Location = new System.Drawing.Point(264, 141);
            this.btnGorus.Name = "btnGorus";
            this.btnGorus.Size = new System.Drawing.Size(96, 72);
            this.btnGorus.TabIndex = 5;
            this.btnGorus.Text = "&Görüşmeyi Başlat";
            this.btnGorus.UseVisualStyleBackColor = true;
            this.btnGorus.Click += new System.EventHandler(this.btnGorus_Click);
            // 
            // tmrTemsilci
            // 
            this.tmrTemsilci.Interval = 1000;
            this.tmrTemsilci.Tick += new System.EventHandler(this.tmrTemsilci_Tick);
            // 
            // MusteriTemsilcisiFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 264);
            this.Controls.Add(this.btnGorus);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.lstCagrilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSiradaki);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MusteriTemsilcisiFormu";
            this.Text = "Müşteri Temsilcisi ";
            this.Load += new System.EventHandler(this.MusteriTemsilcisiFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSiradaki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCagrilar;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Button btnGorus;
        private System.Windows.Forms.Timer tmrTemsilci;
    }
}