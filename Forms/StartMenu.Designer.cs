using MatheQuiz;
namespace MatheQuiz.Forms
{
    partial class StartMenu
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
            this.btn_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Red;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_start.Location = new System.Drawing.Point(274, 227);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(257, 117);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F);
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 200);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mathe Quiz !\r\n\r\nEs wurde 10 Matheaufgaben gefragt.\r\n\r\nBeantworten Sie alle innerh" +
    "alb der Zeit";
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_start);
            this.Name = "StartMenu";
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label1;
    }
}

