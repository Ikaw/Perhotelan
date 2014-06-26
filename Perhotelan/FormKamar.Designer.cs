namespace Perhotelan
{
    partial class FormKamar
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
            this.buttonSelesai = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.dataGridKamar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKamar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelesai
            // 
            this.buttonSelesai.Location = new System.Drawing.Point(1060, 545);
            this.buttonSelesai.Name = "buttonSelesai";
            this.buttonSelesai.Size = new System.Drawing.Size(130, 54);
            this.buttonSelesai.TabIndex = 9;
            this.buttonSelesai.Text = "Selesai";
            this.buttonSelesai.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(1060, 453);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(130, 51);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(1060, 364);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(130, 51);
            this.buttonHapus.TabIndex = 7;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(1060, 272);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(130, 52);
            this.buttonTambah.TabIndex = 6;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            // 
            // dataGridKamar
            // 
            this.dataGridKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKamar.Location = new System.Drawing.Point(217, 193);
            this.dataGridKamar.Name = "dataGridKamar";
            this.dataGridKamar.Size = new System.Drawing.Size(817, 504);
            this.dataGridKamar.TabIndex = 5;
            // 
            // FormKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Perhotelan.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(1264, 742);
            this.Controls.Add(this.buttonSelesai);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridKamar);
            this.Name = "FormKamar";
            this.Text = "FormKamar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKamar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelesai;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DataGridView dataGridKamar;
    }
}