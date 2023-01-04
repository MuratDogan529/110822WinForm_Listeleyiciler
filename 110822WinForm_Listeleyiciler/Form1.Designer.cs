namespace _110822WinForm_Listeleyiciler
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
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.listKisiler = new System.Windows.Forms.ListBox();
            this.bnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim:";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(133, 65);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(205, 22);
            this.txtIsim.TabIndex = 1;
            
            // 
            // listKisiler
            // 
            this.listKisiler.FormattingEnabled = true;
            this.listKisiler.ItemHeight = 16;
            this.listKisiler.Location = new System.Drawing.Point(61, 112);
            this.listKisiler.Name = "listKisiler";
            this.listKisiler.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listKisiler.Size = new System.Drawing.Size(295, 276);
            this.listKisiler.TabIndex = 2;
            this.listKisiler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listKisiler_KeyDown);
            // 
            // bnEkle
            // 
            this.bnEkle.Location = new System.Drawing.Point(375, 65);
            this.bnEkle.Name = "bnEkle";
            this.bnEkle.Size = new System.Drawing.Size(129, 28);
            this.bnEkle.TabIndex = 3;
            this.bnEkle.Text = "Ekle";
            this.bnEkle.UseVisualStyleBackColor = true;
            this.bnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(375, 112);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(127, 27);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.bnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 458);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.bnEkle);
            this.Controls.Add(this.listKisiler);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.ListBox listKisiler;
        private System.Windows.Forms.Button bnEkle;
        private System.Windows.Forms.Button btnSil;
    }
}

