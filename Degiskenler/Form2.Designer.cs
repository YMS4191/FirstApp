namespace Degiskenler
{
    partial class Form2
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
            this.btnTamSayilar = new System.Windows.Forms.Button();
            this.btnOndalikliSayilar = new System.Windows.Forms.Button();
            this.btnMetinsel = new System.Windows.Forms.Button();
            this.btnMantiksal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTamSayilar
            // 
            this.btnTamSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamSayilar.Location = new System.Drawing.Point(12, 12);
            this.btnTamSayilar.Name = "btnTamSayilar";
            this.btnTamSayilar.Size = new System.Drawing.Size(302, 77);
            this.btnTamSayilar.TabIndex = 0;
            this.btnTamSayilar.Text = "Tam Sayılar";
            this.btnTamSayilar.UseVisualStyleBackColor = true;
            this.btnTamSayilar.Click += new System.EventHandler(this.btnTamSayilar_Click);
            // 
            // btnOndalikliSayilar
            // 
            this.btnOndalikliSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOndalikliSayilar.Location = new System.Drawing.Point(12, 95);
            this.btnOndalikliSayilar.Name = "btnOndalikliSayilar";
            this.btnOndalikliSayilar.Size = new System.Drawing.Size(302, 77);
            this.btnOndalikliSayilar.TabIndex = 1;
            this.btnOndalikliSayilar.Text = "Ondalıklı Sayılar";
            this.btnOndalikliSayilar.UseVisualStyleBackColor = true;
            this.btnOndalikliSayilar.Click += new System.EventHandler(this.btnOndalikliSayilar_Click);
            // 
            // btnMetinsel
            // 
            this.btnMetinsel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetinsel.Location = new System.Drawing.Point(12, 178);
            this.btnMetinsel.Name = "btnMetinsel";
            this.btnMetinsel.Size = new System.Drawing.Size(302, 77);
            this.btnMetinsel.TabIndex = 2;
            this.btnMetinsel.Text = "Metinsel";
            this.btnMetinsel.UseVisualStyleBackColor = true;
            this.btnMetinsel.Click += new System.EventHandler(this.btnMetinsel_Click);
            // 
            // btnMantiksal
            // 
            this.btnMantiksal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantiksal.Location = new System.Drawing.Point(12, 261);
            this.btnMantiksal.Name = "btnMantiksal";
            this.btnMantiksal.Size = new System.Drawing.Size(302, 77);
            this.btnMantiksal.TabIndex = 3;
            this.btnMantiksal.Text = "Mantıksal";
            this.btnMantiksal.UseVisualStyleBackColor = true;
            this.btnMantiksal.Click += new System.EventHandler(this.btnMantiksal_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 354);
            this.Controls.Add(this.btnMantiksal);
            this.Controls.Add(this.btnMetinsel);
            this.Controls.Add(this.btnOndalikliSayilar);
            this.Controls.Add(this.btnTamSayilar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTamSayilar;
        private System.Windows.Forms.Button btnOndalikliSayilar;
        private System.Windows.Forms.Button btnMetinsel;
        private System.Windows.Forms.Button btnMantiksal;
    }
}