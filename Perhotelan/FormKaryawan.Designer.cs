namespace Perhotelan
{
    partial class FormKaryawan
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
            this.dataGVKaryawan = new System.Windows.Forms.DataGridView();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSelesai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKaryawan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVKaryawan
            // 
            this.dataGVKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVKaryawan.Location = new System.Drawing.Point(268, 233);
            this.dataGVKaryawan.Name = "dataGVKaryawan";
            this.dataGVKaryawan.Size = new System.Drawing.Size(817, 504);
            this.dataGVKaryawan.TabIndex = 0;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(1111, 312);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(130, 52);
            this.buttonTambah.TabIndex = 1;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(1111, 404);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(130, 51);
            this.buttonHapus.TabIndex = 2;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(1111, 493);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(130, 51);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonSelesai
            // 
            this.buttonSelesai.Location = new System.Drawing.Point(1111, 585);
            this.buttonSelesai.Name = "buttonSelesai";
            this.buttonSelesai.Size = new System.Drawing.Size(130, 54);
            this.buttonSelesai.TabIndex = 4;
            this.buttonSelesai.Text = "Selesai";
            this.buttonSelesai.UseVisualStyleBackColor = true;
            // 
            // FormKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Perhotelan.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.buttonSelesai);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGVKaryawan);
            this.Name = "FormKaryawan";
            this.Text = "FormKaryawan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKaryawan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVKaryawan;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSelesai;
    }
}