namespace DortSeviyeliYapboz
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLevelOne = new System.Windows.Forms.Button();
            this.buttonLevelTwo = new System.Windows.Forms.Button();
            this.buttonLevelThree = new System.Windows.Forms.Button();
            this.buttonLevelFour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLevelOne
            // 
            this.buttonLevelOne.Location = new System.Drawing.Point(34, 227);
            this.buttonLevelOne.Name = "buttonLevelOne";
            this.buttonLevelOne.Size = new System.Drawing.Size(100, 100);
            this.buttonLevelOne.TabIndex = 0;
            this.buttonLevelOne.Text = "Level 1";
            this.buttonLevelOne.UseVisualStyleBackColor = true;
            this.buttonLevelOne.Click += new System.EventHandler(this.buttonLevelOne_Click);
            // 
            // buttonLevelTwo
            // 
            this.buttonLevelTwo.Location = new System.Drawing.Point(158, 227);
            this.buttonLevelTwo.Name = "buttonLevelTwo";
            this.buttonLevelTwo.Size = new System.Drawing.Size(100, 100);
            this.buttonLevelTwo.TabIndex = 0;
            this.buttonLevelTwo.Text = "Level 2";
            this.buttonLevelTwo.UseVisualStyleBackColor = true;
            this.buttonLevelTwo.Click += new System.EventHandler(this.buttonLevelTwo_Click);
            // 
            // buttonLevelThree
            // 
            this.buttonLevelThree.Location = new System.Drawing.Point(288, 227);
            this.buttonLevelThree.Name = "buttonLevelThree";
            this.buttonLevelThree.Size = new System.Drawing.Size(100, 100);
            this.buttonLevelThree.TabIndex = 0;
            this.buttonLevelThree.Text = "Level 3";
            this.buttonLevelThree.UseVisualStyleBackColor = true;
            this.buttonLevelThree.Click += new System.EventHandler(this.buttonLevelThree_Click);
            // 
            // buttonLevelFour
            // 
            this.buttonLevelFour.Location = new System.Drawing.Point(419, 227);
            this.buttonLevelFour.Name = "buttonLevelFour";
            this.buttonLevelFour.Size = new System.Drawing.Size(100, 100);
            this.buttonLevelFour.TabIndex = 0;
            this.buttonLevelFour.Text = "Level 4";
            this.buttonLevelFour.UseVisualStyleBackColor = true;
            this.buttonLevelFour.Click += new System.EventHandler(this.buttonLevelFour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "4 Seviyeli Yapboz\'a hoşgeldiniz!\r\nLütfen level seçiniz!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLevelFour);
            this.Controls.Add(this.buttonLevelThree);
            this.Controls.Add(this.buttonLevelTwo);
            this.Controls.Add(this.buttonLevelOne);
            this.Name = "Form1";
            this.Text = "4 Levelli Puzzle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLevelOne;
        private System.Windows.Forms.Button buttonLevelTwo;
        private System.Windows.Forms.Button buttonLevelThree;
        private System.Windows.Forms.Button buttonLevelFour;
        private System.Windows.Forms.Label label1;
    }
}

