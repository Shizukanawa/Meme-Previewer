namespace WindowsFormsApplication2
{
    partial class StringVariables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StringVariables));
            this.btnStrings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.picBoxGIF = new System.Windows.Forms.PictureBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStrings
            // 
            this.btnStrings.Location = new System.Drawing.Point(12, 12);
            this.btnStrings.Name = "btnStrings";
            this.btnStrings.Size = new System.Drawing.Size(533, 53);
            this.btnStrings.TabIndex = 0;
            this.btnStrings.Text = "Press this button when you typed a meme";
            this.btnStrings.UseVisualStyleBackColor = true;
            this.btnStrings.Click += new System.EventHandler(this.btnStrings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type meme here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(133, 72);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(412, 22);
            this.txtBox2.TabIndex = 9;
            this.txtBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Meme_KeyDown);
            // 
            // picBoxGIF
            // 
            this.picBoxGIF.Location = new System.Drawing.Point(12, 153);
            this.picBoxGIF.Name = "picBoxGIF";
            this.picBoxGIF.Size = new System.Drawing.Size(533, 363);
            this.picBoxGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxGIF.TabIndex = 5;
            this.picBoxGIF.TabStop = false;
            this.picBoxGIF.Click += new System.EventHandler(this.picBoxGIF_Click);
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(12, 125);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(533, 22);
            this.txtBox3.TabIndex = 6;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(211, 105);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(129, 17);
            this.lbl_2.TabIndex = 7;
            this.lbl_2.Text = "Link to meme here:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 100);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(193, 19);
            this.progressBar1.TabIndex = 10;
            // 
            // StringVariables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 528);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.picBoxGIF);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStrings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StringVariables";
            this.Text = "Meme Previewer Generator";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGIF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStrings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.PictureBox picBoxGIF;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

