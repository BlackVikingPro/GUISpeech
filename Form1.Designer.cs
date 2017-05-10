namespace GUISpeech
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
            this.words_to_say = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "What to Say:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // words_to_say
            // 
            this.words_to_say.Location = new System.Drawing.Point(41, 89);
            this.words_to_say.Multiline = true;
            this.words_to_say.Name = "words_to_say";
            this.words_to_say.Size = new System.Drawing.Size(895, 430);
            this.words_to_say.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(41, 563);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(895, 59);
            this.submit.TabIndex = 2;
            this.submit.Text = "Speak";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 667);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.words_to_say);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GUISpeech ~ By: Willy Fox - @BlackVikingPro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox words_to_say;
        private System.Windows.Forms.Button submit;
    }
}

