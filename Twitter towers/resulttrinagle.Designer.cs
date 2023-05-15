
namespace Twitter_towers
{
    partial class resulttrinagle
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
            this.circumference = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.solution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // circumference
            // 
            this.circumference.Location = new System.Drawing.Point(150, 151);
            this.circumference.Name = "circumference";
            this.circumference.Size = new System.Drawing.Size(94, 29);
            this.circumference.TabIndex = 0;
            this.circumference.Text = "circumference";
            this.circumference.UseVisualStyleBackColor = true;
            this.circumference.Click += new System.EventHandler(this.circumference_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(468, 151);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(94, 29);
            this.print.TabIndex = 1;
            this.print.Text = "print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // solution
            // 
            this.solution.AutoSize = true;
            this.solution.Location = new System.Drawing.Point(275, 259);
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(198, 20);
            this.solution.TabIndex = 2;
            this.solution.Text = "the solution will appear here";
            // 
            // resulttrinagle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.solution);
            this.Controls.Add(this.print);
            this.Controls.Add(this.circumference);
            this.Name = "resulttrinagle";
            this.Text = "resultRectangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button circumference;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label solution;
    }
}