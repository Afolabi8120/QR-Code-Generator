namespace QR_Code_Generator
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnJPG = new System.Windows.Forms.Button();
            this.btnPNG = new System.Windows.Forms.Button();
            this.btnJPEG = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 112);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(13, 75);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(231, 27);
            this.txtCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your text";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Location = new System.Drawing.Point(251, 73);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(87, 31);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnJPG
            // 
            this.btnJPG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJPG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnJPG.Location = new System.Drawing.Point(12, 336);
            this.btnJPG.Name = "btnJPG";
            this.btnJPG.Size = new System.Drawing.Size(102, 30);
            this.btnJPG.TabIndex = 5;
            this.btnJPG.Text = "Save as JPG";
            this.btnJPG.UseVisualStyleBackColor = true;
            this.btnJPG.Click += new System.EventHandler(this.btnJPG_Click);
            // 
            // btnPNG
            // 
            this.btnPNG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPNG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPNG.Location = new System.Drawing.Point(124, 336);
            this.btnPNG.Name = "btnPNG";
            this.btnPNG.Size = new System.Drawing.Size(102, 30);
            this.btnPNG.TabIndex = 6;
            this.btnPNG.Text = "Save as PNG";
            this.btnPNG.UseVisualStyleBackColor = true;
            this.btnPNG.Click += new System.EventHandler(this.btnPNG_Click);
            // 
            // btnJPEG
            // 
            this.btnJPEG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJPEG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnJPEG.Location = new System.Drawing.Point(236, 336);
            this.btnJPEG.Name = "btnJPEG";
            this.btnJPEG.Size = new System.Drawing.Size(102, 30);
            this.btnJPEG.TabIndex = 8;
            this.btnJPEG.Text = "Save as JPEG";
            this.btnJPEG.UseVisualStyleBackColor = true;
            this.btnJPEG.Click += new System.EventHandler(this.btnJPEG_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "QR Code Generator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnJPEG);
            this.Controls.Add(this.btnPNG);
            this.Controls.Add(this.btnJPG);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Generator Developed by Temidayo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnJPG;
        private System.Windows.Forms.Button btnPNG;
        private System.Windows.Forms.Button btnJPEG;
        private System.Windows.Forms.Label label2;
    }
}

