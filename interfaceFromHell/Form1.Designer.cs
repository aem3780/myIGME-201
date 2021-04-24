
namespace interfaceFromHell
{
    partial class AnimalForm
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
            this.guessButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.animalPictureBox = new System.Windows.Forms.PictureBox();
            this.animalGuessLabel = new System.Windows.Forms.Label();
            this.colorChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.dogRadioButton = new System.Windows.Forms.RadioButton();
            this.zebraRadioButton = new System.Windows.Forms.RadioButton();
            this.pigRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guessButton
            // 
            this.guessButton.BackColor = System.Drawing.Color.Fuchsia;
            this.guessButton.Location = new System.Drawing.Point(93, 12);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 0;
            this.guessButton.Text = "Exit";
            this.guessButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Violet;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(12, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Guess";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // animalPictureBox
            // 
            this.animalPictureBox.ImageLocation = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/golden-retriever-roy" +
    "alty-free-image-506756303-1560962726.jpg?crop=0.672xw:1.00xh;0.166xw,0&resize=64" +
    "0:*";
            this.animalPictureBox.Location = new System.Drawing.Point(187, 12);
            this.animalPictureBox.Name = "animalPictureBox";
            this.animalPictureBox.Size = new System.Drawing.Size(348, 414);
            this.animalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.animalPictureBox.TabIndex = 3;
            this.animalPictureBox.TabStop = false;
            // 
            // animalGuessLabel
            // 
            this.animalGuessLabel.AutoSize = true;
            this.animalGuessLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalGuessLabel.ForeColor = System.Drawing.Color.Magenta;
            this.animalGuessLabel.Location = new System.Drawing.Point(564, 17);
            this.animalGuessLabel.Name = "animalGuessLabel";
            this.animalGuessLabel.Size = new System.Drawing.Size(235, 18);
            this.animalGuessLabel.TabIndex = 4;
            this.animalGuessLabel.Text = "What kind of animal is this?";
            // 
            // colorChangeCheckBox
            // 
            this.colorChangeCheckBox.AutoSize = true;
            this.colorChangeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorChangeCheckBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.colorChangeCheckBox.Location = new System.Drawing.Point(104, 410);
            this.colorChangeCheckBox.Name = "colorChangeCheckBox";
            this.colorChangeCheckBox.Size = new System.Drawing.Size(199, 28);
            this.colorChangeCheckBox.TabIndex = 5;
            this.colorChangeCheckBox.Text = "CLICK ME IM FUN";
            this.colorChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // dogRadioButton
            // 
            this.dogRadioButton.AutoSize = true;
            this.dogRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogRadioButton.Location = new System.Drawing.Point(555, 63);
            this.dogRadioButton.Name = "dogRadioButton";
            this.dogRadioButton.Size = new System.Drawing.Size(128, 28);
            this.dogRadioButton.TabIndex = 6;
            this.dogRadioButton.TabStop = true;
            this.dogRadioButton.Text = "that is a dog";
            this.dogRadioButton.UseVisualStyleBackColor = true;
            // 
            // zebraRadioButton
            // 
            this.zebraRadioButton.AutoSize = true;
            this.zebraRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zebraRadioButton.Location = new System.Drawing.Point(555, 109);
            this.zebraRadioButton.Name = "zebraRadioButton";
            this.zebraRadioButton.Size = new System.Drawing.Size(166, 33);
            this.zebraRadioButton.TabIndex = 7;
            this.zebraRadioButton.TabStop = true;
            this.zebraRadioButton.Text = "thats a zebra";
            this.zebraRadioButton.UseVisualStyleBackColor = true;
            // 
            // pigRadioButton
            // 
            this.pigRadioButton.AutoSize = true;
            this.pigRadioButton.Location = new System.Drawing.Point(689, 63);
            this.pigRadioButton.Name = "pigRadioButton";
            this.pigRadioButton.Size = new System.Drawing.Size(74, 17);
            this.pigRadioButton.TabIndex = 8;
            this.pigRadioButton.TabStop = true;
            this.pigRadioButton.Text = "thats a pig";
            this.pigRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "OINK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(730, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "OINK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "OINK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "OINK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(573, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "OINK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "OINK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(755, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "OINK";
            // 
            // AnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pigRadioButton);
            this.Controls.Add(this.zebraRadioButton);
            this.Controls.Add(this.dogRadioButton);
            this.Controls.Add(this.colorChangeCheckBox);
            this.Controls.Add(this.animalGuessLabel);
            this.Controls.Add(this.animalPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.guessButton);
            this.Name = "AnimalForm";
            this.Text = "Animals";
            ((System.ComponentModel.ISupportInitialize)(this.animalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox animalPictureBox;
        private System.Windows.Forms.Label animalGuessLabel;
        private System.Windows.Forms.CheckBox colorChangeCheckBox;
        private System.Windows.Forms.RadioButton dogRadioButton;
        private System.Windows.Forms.RadioButton zebraRadioButton;
        private System.Windows.Forms.RadioButton pigRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

