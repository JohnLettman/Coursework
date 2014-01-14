namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.HelloWorldGUI
{
    partial class MainWindow
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
            this.welloWorldLabel = new System.Windows.Forms.Label();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.thisToggleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welloWorldLabel
            // 
            this.welloWorldLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welloWorldLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welloWorldLabel.Location = new System.Drawing.Point(0, 0);
            this.welloWorldLabel.Name = "welloWorldLabel";
            this.welloWorldLabel.Size = new System.Drawing.Size(432, 144);
            this.welloWorldLabel.TabIndex = 0;
            this.welloWorldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClickMe
            // 
            this.btnClickMe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClickMe.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickMe.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnClickMe.Location = new System.Drawing.Point(139, 211);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(157, 39);
            this.btnClickMe.TabIndex = 1;
            this.btnClickMe.Text = "Click Me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // thisToggleLabel
            // 
            this.thisToggleLabel.AutoSize = true;
            this.thisToggleLabel.Location = new System.Drawing.Point(12, 229);
            this.thisToggleLabel.Name = "thisToggleLabel";
            this.thisToggleLabel.Size = new System.Drawing.Size(92, 13);
            this.thisToggleLabel.TabIndex = 2;
            this.thisToggleLabel.Text = "this.toggle = False";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 262);
            this.Controls.Add(this.thisToggleLabel);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.welloWorldLabel);
            this.Name = "MainWindow";
            this.Text = "I am a C# window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welloWorldLabel;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Label thisToggleLabel;
    }
}

