namespace MatheQuiz
{
    partial class Endscreen
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
            this.label_endscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_endscore
            // 
            this.label_endscore.AutoSize = true;
            this.label_endscore.BackColor = System.Drawing.Color.Transparent;
            this.label_endscore.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_endscore.ForeColor = System.Drawing.SystemColors.Window;
            this.label_endscore.Location = new System.Drawing.Point(41, 151);
            this.label_endscore.Name = "label_endscore";
            this.label_endscore.Size = new System.Drawing.Size(97, 85);
            this.label_endscore.TabIndex = 2;
            this.label_endscore.Text = "█";
            // 
            // Endscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_endscore);
            this.Name = "Endscreen";
            this.Text = "Endscreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_endscore;
    }
}