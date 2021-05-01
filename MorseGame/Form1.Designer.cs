
namespace MorseGame
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Decryption = new System.Windows.Forms.RichTextBox();
            this.Txt_Cipher = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pb_Check = new System.Windows.Forms.PictureBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_NextCipher = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UpDn_Difficulty = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Answer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_Difficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nueva Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(228)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(119, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "The cipher";
            // 
            // Txt_Decryption
            // 
            this.Txt_Decryption.Font = new System.Drawing.Font("Orator Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Decryption.Location = new System.Drawing.Point(12, 218);
            this.Txt_Decryption.Name = "Txt_Decryption";
            this.Txt_Decryption.Size = new System.Drawing.Size(340, 91);
            this.Txt_Decryption.TabIndex = 2;
            this.Txt_Decryption.Text = "";
            this.Txt_Decryption.TextChanged += new System.EventHandler(this.Txt_Decryption_TextChanged);
            // 
            // Txt_Cipher
            // 
            this.Txt_Cipher.Font = new System.Drawing.Font("Orator Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cipher.Location = new System.Drawing.Point(12, 54);
            this.Txt_Cipher.Name = "Txt_Cipher";
            this.Txt_Cipher.Size = new System.Drawing.Size(340, 96);
            this.Txt_Cipher.TabIndex = 3;
            this.Txt_Cipher.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nueva Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(228)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(102, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your decryption";
            // 
            // Pb_Check
            // 
            this.Pb_Check.Location = new System.Drawing.Point(387, 54);
            this.Pb_Check.Name = "Pb_Check";
            this.Pb_Check.Size = new System.Drawing.Size(63, 62);
            this.Pb_Check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_Check.TabIndex = 5;
            this.Pb_Check.TabStop = false;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(247)))));
            this.Btn_Exit.Location = new System.Drawing.Point(372, 259);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(135, 37);
            this.Btn_Exit.TabIndex = 6;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_NextCipher
            // 
            this.Btn_NextCipher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NextCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_NextCipher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(247)))));
            this.Btn_NextCipher.Location = new System.Drawing.Point(372, 197);
            this.Btn_NextCipher.Name = "Btn_NextCipher";
            this.Btn_NextCipher.Size = new System.Drawing.Size(135, 33);
            this.Btn_NextCipher.TabIndex = 7;
            this.Btn_NextCipher.Text = "Next Cipher";
            this.Btn_NextCipher.UseVisualStyleBackColor = true;
            this.Btn_NextCipher.Click += new System.EventHandler(this.Btn_NextCipher_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nueva Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(228)))), ((int)(((byte)(174)))));
            this.label3.Location = new System.Drawing.Point(368, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Answer check";
            // 
            // UpDn_Difficulty
            // 
            this.UpDn_Difficulty.Location = new System.Drawing.Point(387, 161);
            this.UpDn_Difficulty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDn_Difficulty.Name = "UpDn_Difficulty";
            this.UpDn_Difficulty.Size = new System.Drawing.Size(120, 20);
            this.UpDn_Difficulty.TabIndex = 9;
            this.UpDn_Difficulty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nueva Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(228)))), ((int)(((byte)(174)))));
            this.label4.Location = new System.Drawing.Point(383, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Difficulty";
            // 
            // Btn_Answer
            // 
            this.Btn_Answer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Answer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(153)))), ((int)(((byte)(247)))));
            this.Btn_Answer.Location = new System.Drawing.Point(467, 74);
            this.Btn_Answer.Name = "Btn_Answer";
            this.Btn_Answer.Size = new System.Drawing.Size(70, 28);
            this.Btn_Answer.TabIndex = 11;
            this.Btn_Answer.Text = "Answer";
            this.Btn_Answer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Answer.UseVisualStyleBackColor = true;
            this.Btn_Answer.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(549, 321);
            this.Controls.Add(this.Btn_Answer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UpDn_Difficulty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_NextCipher);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Pb_Check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Cipher);
            this.Controls.Add(this.Txt_Decryption);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MorseGame";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_Difficulty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Txt_Decryption;
        private System.Windows.Forms.RichTextBox Txt_Cipher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Pb_Check;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_NextCipher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown UpDn_Difficulty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Answer;
    }
}

