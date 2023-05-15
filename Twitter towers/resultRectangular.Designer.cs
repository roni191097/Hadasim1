
namespace Twitter_towers
{
    partial class resultRectangular
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
            this.solutionlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // solutionlabel
            // 
            this.solutionlabel.AutoSize = true;
            this.solutionlabel.Location = new System.Drawing.Point(271, 180);
            this.solutionlabel.Name = "solutionlabel";
            this.solutionlabel.Size = new System.Drawing.Size(191, 20);
            this.solutionlabel.TabIndex = 0;
            this.solutionlabel.Text = "the calculate will show here";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "to calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultRectangular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.solutionlabel);
            this.Name = "resultRectangular";
            this.Text = "result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label solutionlabel;
        private System.Windows.Forms.Button button1;
    }
}