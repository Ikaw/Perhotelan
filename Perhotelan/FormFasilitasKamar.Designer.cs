namespace Perhotelan
{
    partial class FormFasilitasKamar
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
            this.dataGridFasilitasKamar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFasilitasKamar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelesai
            // 
            this.buttonSelesai.Location = new System.Drawing.Point(1069, 551);
            this.buttonSelesai.Name = "buttonSelesai";
            this.buttonSelesai.Size = new System.Drawing.Size(130, 54);
            this.buttonSelesai.TabIndex = 14;
            this.buttonSelesai.Text = "Selesai";
            this.buttonSelesai.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(1069, 459);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(130, 51);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(1069, 370);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(130, 51);
            this.buttonHapus.TabIndex = 12;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(1069, 278);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(130, 52);
            this.buttonTambah.TabIndex = 11;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            // 
            // dataGridFasilitasKamar
            // 
            this.dataGridFasilitasKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFasilitasKamar.Location = new System.Drawing.Point(226, 199);
            this.dataGridFasilitasKamar.Name = "dataGridFasilitasKamar";
            this.dataGridFasilitasKamar.Size = new System.Drawing.Size(817, 504);
            this.dataGridFasilitasKamar.TabIndex = 10;
            // 
            // FormFasilitasKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Perhotelan.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(1264, 742);
            this.Controls.Add(this.buttonSelesai);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridFasilitasKamar);
            this.Name = "FormFasilitasKamar";
            this.Text = "FormFasilitasKamar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFasilitasKamar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelesai;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DataGridView dataGridFasilitasKamar;
    }
}