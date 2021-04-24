
namespace interfaceFromHell
{
    partial class Form3
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
            this.threadLabel = new System.Windows.Forms.Label();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // threadLabel
            // 
            this.threadLabel.AutoSize = true;
            this.threadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threadLabel.Location = new System.Drawing.Point(21, 24);
            this.threadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.threadLabel.Name = "threadLabel";
            this.threadLabel.Size = new System.Drawing.Size(76, 25);
            this.threadLabel.TabIndex = 0;
            this.threadLabel.Text = "label1";
            this.threadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countdownLabel
            // 
            this.countdownLabel.AutoSize = true;
            this.countdownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel.Location = new System.Drawing.Point(24, 61);
            this.countdownLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(57, 20);
            this.countdownLabel.TabIndex = 1;
            this.countdownLabel.Text = "label1";
            this.countdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.Cyan;
            this.noButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.noButton.Location = new System.Drawing.Point(288, 275);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 30);
            this.noButton.TabIndex = 3;
            this.noButton.Text = "NO";
            this.noButton.UseVisualStyleBackColor = false;
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.Cyan;
            this.yesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.yesButton.Location = new System.Drawing.Point(187, 275);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 30);
            this.yesButton.TabIndex = 4;
            this.yesButton.Text = "YES";
            this.yesButton.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(534, 317);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.threadLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Countdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label threadLabel;
        private System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button yesButton;
    }
}