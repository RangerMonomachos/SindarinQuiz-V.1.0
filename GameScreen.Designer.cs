namespace SindarinQuiz_V._1._0
{
    partial class GameScreen
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
            this.WordToTranslate = new System.Windows.Forms.Label();
            this.Option1 = new System.Windows.Forms.Button();
            this.Option2 = new System.Windows.Forms.Button();
            this.Option3 = new System.Windows.Forms.Button();
            this.Option4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ScoreTracker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sindarin Quiz";
            // 
            // WordToTranslate
            // 
            this.WordToTranslate.AutoSize = true;
            this.WordToTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordToTranslate.Location = new System.Drawing.Point(338, 108);
            this.WordToTranslate.Name = "WordToTranslate";
            this.WordToTranslate.Size = new System.Drawing.Size(60, 24);
            this.WordToTranslate.TabIndex = 1;
            this.WordToTranslate.Text = "label2";
            // 
            // Option1
            // 
            this.Option1.Location = new System.Drawing.Point(122, 123);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(75, 23);
            this.Option1.TabIndex = 2;
            this.Option1.Text = "button1";
            this.Option1.UseVisualStyleBackColor = true;
            this.Option1.Click += new System.EventHandler(this.Option1_Click);
            // 
            // Option2
            // 
            this.Option2.Location = new System.Drawing.Point(511, 123);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(75, 23);
            this.Option2.TabIndex = 3;
            this.Option2.Text = "button2";
            this.Option2.UseVisualStyleBackColor = true;
            this.Option2.Click += new System.EventHandler(this.Option2_Click);
            // 
            // Option3
            // 
            this.Option3.Location = new System.Drawing.Point(122, 274);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(75, 23);
            this.Option3.TabIndex = 4;
            this.Option3.Text = "button3";
            this.Option3.UseVisualStyleBackColor = true;
            this.Option3.Click += new System.EventHandler(this.Option3_Click);
            // 
            // Option4
            // 
            this.Option4.Location = new System.Drawing.Point(511, 274);
            this.Option4.Name = "Option4";
            this.Option4.Size = new System.Drawing.Size(75, 23);
            this.Option4.TabIndex = 5;
            this.Option4.Text = "button4";
            this.Option4.UseVisualStyleBackColor = true;
            this.Option4.Click += new System.EventHandler(this.Option4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Score";
            // 
            // ScoreTracker
            // 
            this.ScoreTracker.AutoSize = true;
            this.ScoreTracker.Location = new System.Drawing.Point(269, 366);
            this.ScoreTracker.Name = "ScoreTracker";
            this.ScoreTracker.Size = new System.Drawing.Size(38, 13);
            this.ScoreTracker.TabIndex = 7;
            this.ScoreTracker.Text = "lable 1";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScoreTracker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Option4);
            this.Controls.Add(this.Option3);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.WordToTranslate);
            this.Controls.Add(this.label1);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WordToTranslate;
        private System.Windows.Forms.Button Option1;
        private System.Windows.Forms.Button Option2;
        private System.Windows.Forms.Button Option3;
        private System.Windows.Forms.Button Option4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ScoreTracker;
    }
}