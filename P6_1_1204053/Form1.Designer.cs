namespace P6_1_1204053
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbSingkatan = new System.Windows.Forms.Label();
            this.lbKP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdProdi = new System.Windows.Forms.TextBox();
            this.txtNamaProdi = new System.Windows.Forms.TextBox();
            this.txtSingkatan = new System.Windows.Forms.TextBox();
            this.txtKaProdi = new System.Windows.Forms.TextBox();
            this.txtSekProdi = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Input Prodi";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(141, 114);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(164, 22);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "ID Prodi                 :";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNama.Location = new System.Drawing.Point(141, 164);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(164, 22);
            this.lbNama.TabIndex = 2;
            this.lbNama.Text = "Nama Prodi           :";
            // 
            // lbSingkatan
            // 
            this.lbSingkatan.AutoSize = true;
            this.lbSingkatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSingkatan.Location = new System.Drawing.Point(141, 217);
            this.lbSingkatan.Name = "lbSingkatan";
            this.lbSingkatan.Size = new System.Drawing.Size(165, 22);
            this.lbSingkatan.TabIndex = 3;
            this.lbSingkatan.Text = "Singkatan              :";
            this.lbSingkatan.Click += new System.EventHandler(this.lbSingkatan_Click);
            // 
            // lbKP
            // 
            this.lbKP.AutoSize = true;
            this.lbKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKP.Location = new System.Drawing.Point(141, 265);
            this.lbKP.Name = "lbKP";
            this.lbKP.Size = new System.Drawing.Size(164, 22);
            this.lbKP.TabIndex = 4;
            this.lbKP.Text = "Ketua Prodi           :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sekertaris Prodi    :";
            // 
            // txtIdProdi
            // 
            this.txtIdProdi.Location = new System.Drawing.Point(311, 114);
            this.txtIdProdi.Name = "txtIdProdi";
            this.txtIdProdi.Size = new System.Drawing.Size(133, 26);
            this.txtIdProdi.TabIndex = 6;
            // 
            // txtNamaProdi
            // 
            this.txtNamaProdi.Location = new System.Drawing.Point(311, 164);
            this.txtNamaProdi.Name = "txtNamaProdi";
            this.txtNamaProdi.Size = new System.Drawing.Size(290, 26);
            this.txtNamaProdi.TabIndex = 7;
            // 
            // txtSingkatan
            // 
            this.txtSingkatan.Location = new System.Drawing.Point(312, 217);
            this.txtSingkatan.Name = "txtSingkatan";
            this.txtSingkatan.Size = new System.Drawing.Size(174, 26);
            this.txtSingkatan.TabIndex = 8;
            // 
            // txtKaProdi
            // 
            this.txtKaProdi.Location = new System.Drawing.Point(312, 265);
            this.txtKaProdi.Name = "txtKaProdi";
            this.txtKaProdi.Size = new System.Drawing.Size(289, 26);
            this.txtKaProdi.TabIndex = 9;
            // 
            // txtSekProdi
            // 
            this.txtSekProdi.Location = new System.Drawing.Point(312, 317);
            this.txtSekProdi.Name = "txtSekProdi";
            this.txtSekProdi.Size = new System.Drawing.Size(289, 26);
            this.txtSekProdi.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(282, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 44);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(408, 411);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 42);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSekProdi);
            this.Controls.Add(this.txtKaProdi);
            this.Controls.Add(this.txtSingkatan);
            this.Controls.Add(this.txtNamaProdi);
            this.Controls.Add(this.txtIdProdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbKP);
            this.Controls.Add(this.lbSingkatan);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbSingkatan;
        private System.Windows.Forms.Label lbKP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdProdi;
        private System.Windows.Forms.TextBox txtNamaProdi;
        private System.Windows.Forms.TextBox txtSingkatan;
        private System.Windows.Forms.TextBox txtKaProdi;
        private System.Windows.Forms.TextBox txtSekProdi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}

