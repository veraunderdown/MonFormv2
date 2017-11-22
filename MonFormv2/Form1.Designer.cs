namespace MonFormv2
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
            this.uiHelloWorldButton = new System.Windows.Forms.Button();
            this.uiGoodbyeDaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiHelloWorldButton
            // 
            this.uiHelloWorldButton.Location = new System.Drawing.Point(638, 201);
            this.uiHelloWorldButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uiHelloWorldButton.Name = "uiHelloWorldButton";
            this.uiHelloWorldButton.Size = new System.Drawing.Size(125, 30);
            this.uiHelloWorldButton.TabIndex = 0;
            this.uiHelloWorldButton.Text = "Hello World";
            this.uiHelloWorldButton.UseVisualStyleBackColor = true;
            // 
            // uiGoodbyeDaveButton
            // 
            this.uiGoodbyeDaveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uiGoodbyeDaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiGoodbyeDaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiGoodbyeDaveButton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiGoodbyeDaveButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.uiGoodbyeDaveButton.Location = new System.Drawing.Point(638, 276);
            this.uiGoodbyeDaveButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uiGoodbyeDaveButton.Name = "uiGoodbyeDaveButton";
            this.uiGoodbyeDaveButton.Size = new System.Drawing.Size(157, 37);
            this.uiGoodbyeDaveButton.TabIndex = 1;
            this.uiGoodbyeDaveButton.Text = "Goodbye Dave";
            this.uiGoodbyeDaveButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1062, 585);
            this.Controls.Add(this.uiGoodbyeDaveButton);
            this.Controls.Add(this.uiHelloWorldButton);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiHelloWorldButton;
        private System.Windows.Forms.Button uiGoodbyeDaveButton;
    }
}

