namespace ChuckNorrisJokes
{
    partial class ChuckNorrisJokesGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChuckNorrisJokesGenerator));
            this.jokeButton = new System.Windows.Forms.Button();
            this.jokeCategoryBox = new System.Windows.Forms.ComboBox();
            this.multipleJokesButton = new System.Windows.Forms.Button();
            this.jokeAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.jokeAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // jokeButton
            // 
            this.jokeButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.jokeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jokeButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.jokeButton.Location = new System.Drawing.Point(305, 359);
            this.jokeButton.Name = "jokeButton";
            this.jokeButton.Size = new System.Drawing.Size(182, 78);
            this.jokeButton.TabIndex = 0;
            this.jokeButton.Text = "Click for a joke";
            this.jokeButton.UseVisualStyleBackColor = false;
            this.jokeButton.Click += new System.EventHandler(this.jokeButton_Click);
            // 
            // jokeCategoryBox
            // 
            this.jokeCategoryBox.AllowDrop = true;
            this.jokeCategoryBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jokeCategoryBox.FormattingEnabled = true;
            this.jokeCategoryBox.Location = new System.Drawing.Point(305, 306);
            this.jokeCategoryBox.Name = "jokeCategoryBox";
            this.jokeCategoryBox.Size = new System.Drawing.Size(182, 35);
            this.jokeCategoryBox.TabIndex = 1;
            // 
            // multipleJokesButton
            // 
            this.multipleJokesButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.multipleJokesButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.multipleJokesButton.Location = new System.Drawing.Point(303, 443);
            this.multipleJokesButton.Name = "multipleJokesButton";
            this.multipleJokesButton.Size = new System.Drawing.Size(184, 78);
            this.multipleJokesButton.TabIndex = 2;
            this.multipleJokesButton.Text = "Click for multiple jokes!";
            this.multipleJokesButton.UseVisualStyleBackColor = false;
            this.multipleJokesButton.Click += new System.EventHandler(this.multipleJokesButton_Click);
            // 
            // jokeAmount
            // 
            this.jokeAmount.Location = new System.Drawing.Point(530, 477);
            this.jokeAmount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.jokeAmount.Name = "jokeAmount";
            this.jokeAmount.Size = new System.Drawing.Size(180, 35);
            this.jokeAmount.TabIndex = 3;
            this.jokeAmount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ChuckNorrisJokesGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.jokeAmount);
            this.Controls.Add(this.multipleJokesButton);
            this.Controls.Add(this.jokeCategoryBox);
            this.Controls.Add(this.jokeButton);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ChuckNorrisJokesGenerator";
            this.Text = "ChuckNorrisJokesGenerator";
            this.Load += new System.EventHandler(this.ChuckNorrisJokesGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jokeAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button jokeButton;
        private ComboBox jokeCategoryBox;
        private Button multipleJokesButton;
        private NumericUpDown jokeAmount;
    }
}