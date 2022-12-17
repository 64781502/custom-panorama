
namespace custom_panorama
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.PathBox = new System.Windows.Forms.ComboBox();
            this.ThumbBox = new System.Windows.Forms.PictureBox();
            this.OutputImgBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.FromPanorama = new System.Windows.Forms.Label();
            this.ToPanorama = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClearCacheButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panorama:";
            // 
            // PathBox
            // 
            this.PathBox.DropDownHeight = 250;
            this.PathBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PathBox.DropDownWidth = 175;
            this.PathBox.FormattingEnabled = true;
            this.PathBox.IntegralHeight = false;
            this.PathBox.Location = new System.Drawing.Point(19, 82);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(121, 21);
            this.PathBox.TabIndex = 1;
            this.PathBox.SelectionChangeCommitted += new System.EventHandler(this.PathBox_SelectionChangeCommitted);
            // 
            // ThumbBox
            // 
            this.ThumbBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThumbBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ThumbBox.Location = new System.Drawing.Point(168, 12);
            this.ThumbBox.Name = "ThumbBox";
            this.ThumbBox.Size = new System.Drawing.Size(320, 180);
            this.ThumbBox.TabIndex = 2;
            this.ThumbBox.TabStop = false;
            // 
            // OutputImgBox
            // 
            this.OutputImgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputImgBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.OutputImgBox.Location = new System.Drawing.Point(560, 12);
            this.OutputImgBox.Name = "OutputImgBox";
            this.OutputImgBox.Size = new System.Drawing.Size(320, 180);
            this.OutputImgBox.TabIndex = 3;
            this.OutputImgBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "=>";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(19, 26);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 5;
            this.OpenFileButton.Text = "Pick image";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(41, 148);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 7;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // FromPanorama
            // 
            this.FromPanorama.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FromPanorama.Location = new System.Drawing.Point(168, 195);
            this.FromPanorama.Name = "FromPanorama";
            this.FromPanorama.Size = new System.Drawing.Size(320, 19);
            this.FromPanorama.TabIndex = 8;
            this.FromPanorama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToPanorama
            // 
            this.ToPanorama.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ToPanorama.Location = new System.Drawing.Point(560, 195);
            this.ToPanorama.Name = "ToPanorama";
            this.ToPanorama.Size = new System.Drawing.Size(320, 19);
            this.ToPanorama.TabIndex = 9;
            this.ToPanorama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Image:";
            // 
            // ClearCacheButton
            // 
            this.ClearCacheButton.Location = new System.Drawing.Point(41, 171);
            this.ClearCacheButton.Name = "ClearCacheButton";
            this.ClearCacheButton.Size = new System.Drawing.Size(75, 23);
            this.ClearCacheButton.TabIndex = 11;
            this.ClearCacheButton.Text = "Clear cache";
            this.ClearCacheButton.UseVisualStyleBackColor = true;
            this.ClearCacheButton.Click += new System.EventHandler(this.ClearCacheButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(904, 218);
            this.Controls.Add(this.ClearCacheButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ToPanorama);
            this.Controls.Add(this.FromPanorama);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputImgBox);
            this.Controls.Add(this.ThumbBox);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "CS:GO Custom Panorama";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.ThumbBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PathBox;
        private System.Windows.Forms.PictureBox ThumbBox;
        private System.Windows.Forms.PictureBox OutputImgBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label FromPanorama;
        private System.Windows.Forms.Label ToPanorama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClearCacheButton;
    }
}

