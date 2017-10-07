namespace FirstFrameDisplay
{
    partial class FirstFrame
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
            this.components = new System.ComponentModel.Container();
            this.frameOne = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.frameOne)).BeginInit();
            this.SuspendLayout();
            // 
            // frameOne
            // 
            this.frameOne.Enabled = false;
            this.frameOne.Location = new System.Drawing.Point(13, 13);
            this.frameOne.Name = "frameOne";
            this.frameOne.Size = new System.Drawing.Size(257, 228);
            this.frameOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.frameOne.TabIndex = 2;
            this.frameOne.TabStop = false;
            // 
            // FirstFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.frameOne);
            this.Name = "FirstFrame";
            this.Text = "First Frame";
            ((System.ComponentModel.ISupportInitialize)(this.frameOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox frameOne;
    }
}

