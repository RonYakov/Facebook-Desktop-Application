namespace BasicFacebookFeatures
{
    partial class FormAlbums
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
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.listBoxAlbumsComments = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAlbumsLikesAmount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxImage = new System.Windows.Forms.ListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelImagesLikesAmount = new System.Windows.Forms.Label();
            this.listBoxImagesComments = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPostData = new System.Windows.Forms.Label();
            this.buttonSavePic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(41, 116);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(243, 459);
            this.listBoxAlbums.TabIndex = 0;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // listBoxAlbumsComments
            // 
            this.listBoxAlbumsComments.FormattingEnabled = true;
            this.listBoxAlbumsComments.Location = new System.Drawing.Point(309, 483);
            this.listBoxAlbumsComments.Name = "listBoxAlbumsComments";
            this.listBoxAlbumsComments.Size = new System.Drawing.Size(785, 95);
            this.listBoxAlbumsComments.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hadassah Friedlaender", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Likes: ";
            // 
            // labelAlbumsLikesAmount
            // 
            this.labelAlbumsLikesAmount.AutoSize = true;
            this.labelAlbumsLikesAmount.Location = new System.Drawing.Point(363, 381);
            this.labelAlbumsLikesAmount.Name = "labelAlbumsLikesAmount";
            this.labelAlbumsLikesAmount.Size = new System.Drawing.Size(0, 13);
            this.labelAlbumsLikesAmount.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1117, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 95);
            this.button1.TabIndex = 4;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // listBoxImage
            // 
            this.listBoxImage.FormattingEnabled = true;
            this.listBoxImage.Location = new System.Drawing.Point(309, 119);
            this.listBoxImage.Name = "listBoxImage";
            this.listBoxImage.Size = new System.Drawing.Size(521, 329);
            this.listBoxImage.TabIndex = 5;
            this.listBoxImage.SelectedIndexChanged += new System.EventHandler(this.listBoxImage_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(854, 119);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(158, 140);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hadassah Friedlaender", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(851, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Likes:";
            // 
            // labelImagesLikesAmount
            // 
            this.labelImagesLikesAmount.AutoSize = true;
            this.labelImagesLikesAmount.Location = new System.Drawing.Point(915, 202);
            this.labelImagesLikesAmount.Name = "labelImagesLikesAmount";
            this.labelImagesLikesAmount.Size = new System.Drawing.Size(0, 13);
            this.labelImagesLikesAmount.TabIndex = 8;
            // 
            // listBoxImagesComments
            // 
            this.listBoxImagesComments.FormattingEnabled = true;
            this.listBoxImagesComments.Location = new System.Drawing.Point(854, 327);
            this.listBoxImagesComments.Name = "listBoxImagesComments";
            this.listBoxImagesComments.Size = new System.Drawing.Size(339, 121);
            this.listBoxImagesComments.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelPostData);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 99);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(29, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 86);
            this.label4.TabIndex = 19;
            this.label4.Text = "Facebook";
            // 
            // labelPostData
            // 
            this.labelPostData.AutoSize = true;
            this.labelPostData.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostData.Location = new System.Drawing.Point(216, 38);
            this.labelPostData.Name = "labelPostData";
            this.labelPostData.Size = new System.Drawing.Size(0, 25);
            this.labelPostData.TabIndex = 13;
            // 
            // buttonSavePic
            // 
            this.buttonSavePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonSavePic.Location = new System.Drawing.Point(1070, 217);
            this.buttonSavePic.Name = "buttonSavePic";
            this.buttonSavePic.Size = new System.Drawing.Size(123, 42);
            this.buttonSavePic.TabIndex = 16;
            this.buttonSavePic.Text = "Save picture";
            this.buttonSavePic.UseVisualStyleBackColor = true;
            this.buttonSavePic.Click += new System.EventHandler(this.buttonSavePic_Click);
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1218, 600);
            this.Controls.Add(this.buttonSavePic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxImagesComments);
            this.Controls.Add(this.labelImagesLikesAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.listBoxImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAlbumsLikesAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAlbumsComments);
            this.Controls.Add(this.listBoxAlbums);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1234, 639);
            this.MinimumSize = new System.Drawing.Size(1234, 639);
            this.Name = "FormAlbums";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.ListBox listBoxAlbumsComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAlbumsLikesAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxImage;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelImagesLikesAmount;
        private System.Windows.Forms.ListBox listBoxImagesComments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPostData;
        private System.Windows.Forms.Button buttonSavePic;
    }
}