using MatheQuiz;
namespace MatheQuiz.Forms
{
    partial class Aufgabe
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
            this.label_first_value = new System.Windows.Forms.Label();
            this.label_mathsymbol = new System.Windows.Forms.Label();
            this.label_second_value = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label_score = new System.Windows.Forms.Label();
            this.prg_bar = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_first_value
            // 
            this.label_first_value.AutoSize = true;
            this.label_first_value.BackColor = System.Drawing.Color.Transparent;
            this.label_first_value.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_first_value.ForeColor = System.Drawing.SystemColors.Window;
            this.label_first_value.Location = new System.Drawing.Point(227, 127);
            this.label_first_value.Name = "label_first_value";
            this.label_first_value.Size = new System.Drawing.Size(97, 85);
            this.label_first_value.TabIndex = 0;
            this.label_first_value.Text = "█";
            // 
            // label_mathsymbol
            // 
            this.label_mathsymbol.AutoSize = true;
            this.label_mathsymbol.BackColor = System.Drawing.Color.Transparent;
            this.label_mathsymbol.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mathsymbol.ForeColor = System.Drawing.SystemColors.Window;
            this.label_mathsymbol.Location = new System.Drawing.Point(330, 127);
            this.label_mathsymbol.Name = "label_mathsymbol";
            this.label_mathsymbol.Size = new System.Drawing.Size(97, 85);
            this.label_mathsymbol.TabIndex = 1;
            this.label_mathsymbol.Text = "█";
            // 
            // label_second_value
            // 
            this.label_second_value.AutoSize = true;
            this.label_second_value.BackColor = System.Drawing.Color.Transparent;
            this.label_second_value.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_second_value.ForeColor = System.Drawing.SystemColors.Window;
            this.label_second_value.Location = new System.Drawing.Point(433, 127);
            this.label_second_value.Name = "label_second_value";
            this.label_second_value.Size = new System.Drawing.Size(97, 85);
            this.label_second_value.TabIndex = 2;
            this.label_second_value.Text = "█";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_input);
            this.panel1.Location = new System.Drawing.Point(221, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 52);
            this.panel1.TabIndex = 3;
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(9, 18);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(288, 20);
            this.txt_input.TabIndex = 0;
            this.txt_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_input_KeyPress);
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.Color.Transparent;
            this.label_score.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Italic);
            this.label_score.ForeColor = System.Drawing.SystemColors.Window;
            this.label_score.Location = new System.Drawing.Point(663, 19);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(114, 34);
            this.label_score.TabIndex = 4;
            this.label_score.Text = "Score 0";
            // 
            // prg_bar
            // 
            this.prg_bar.Location = new System.Drawing.Point(221, 322);
            this.prg_bar.Name = "prg_bar";
            this.prg_bar.Size = new System.Drawing.Size(309, 51);
            this.prg_bar.TabIndex = 5;
            // 
            // Aufgabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prg_bar);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_second_value);
            this.Controls.Add(this.label_mathsymbol);
            this.Controls.Add(this.label_first_value);
            this.Name = "Aufgabe";
            this.Text = "Aufgabe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Aufgabe_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_first_value;
        private System.Windows.Forms.Label label_mathsymbol;
        private System.Windows.Forms.Label label_second_value;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.ProgressBar prg_bar;
    }
}
