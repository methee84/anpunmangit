namespace ObjectDetection
{
    partial class MainUI
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
            this.inputImage = new System.Windows.Forms.PictureBox();
            this.outputImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttBrowseImage = new System.Windows.Forms.Button();
            this.inputImageFileName = new System.Windows.Forms.Label();
            this.outputImageFileName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.predictURL = new System.Windows.Forms.TextBox();
            this.predictKEY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.responseBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).BeginInit();
            this.SuspendLayout();
            // 
            // inputImage
            // 
            this.inputImage.Location = new System.Drawing.Point(33, 80);
            this.inputImage.Name = "inputImage";
            this.inputImage.Size = new System.Drawing.Size(400, 300);
            this.inputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputImage.TabIndex = 0;
            this.inputImage.TabStop = false;
            // 
            // outputImage
            // 
            this.outputImage.Location = new System.Drawing.Point(575, 80);
            this.outputImage.Name = "outputImage";
            this.outputImage.Size = new System.Drawing.Size(400, 300);
            this.outputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputImage.TabIndex = 1;
            this.outputImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttBrowseImage
            // 
            this.buttBrowseImage.Location = new System.Drawing.Point(358, 51);
            this.buttBrowseImage.Name = "buttBrowseImage";
            this.buttBrowseImage.Size = new System.Drawing.Size(75, 23);
            this.buttBrowseImage.TabIndex = 2;
            this.buttBrowseImage.Text = "Browse";
            this.buttBrowseImage.UseVisualStyleBackColor = true;
            this.buttBrowseImage.Click += new System.EventHandler(this.buttBrowseImage_Click);
            // 
            // inputImageFileName
            // 
            this.inputImageFileName.AutoSize = true;
            this.inputImageFileName.Location = new System.Drawing.Point(30, 383);
            this.inputImageFileName.Name = "inputImageFileName";
            this.inputImageFileName.Size = new System.Drawing.Size(64, 13);
            this.inputImageFileName.TabIndex = 3;
            this.inputImageFileName.Text = "<File name>";
            // 
            // outputImageFileName
            // 
            this.outputImageFileName.AutoSize = true;
            this.outputImageFileName.Location = new System.Drawing.Point(572, 383);
            this.outputImageFileName.Name = "outputImageFileName";
            this.outputImageFileName.Size = new System.Drawing.Size(64, 13);
            this.outputImageFileName.TabIndex = 4;
            this.outputImageFileName.Text = "<File name>";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "PREDICT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // predictURL
            // 
            this.predictURL.Location = new System.Drawing.Point(575, 12);
            this.predictURL.Name = "predictURL";
            this.predictURL.Size = new System.Drawing.Size(400, 20);
            this.predictURL.TabIndex = 6;
            this.predictURL.Text = "https://testobjectdetection.cognitiveservices.azure.com/customvision/v3.0/Predict" +
    "ion/9c1b8666-16df-4862-b44f-f0533e20e928/detect/iterations/Iteration1/image";
            // 
            // predictKEY
            // 
            this.predictKEY.Location = new System.Drawing.Point(575, 38);
            this.predictKEY.Name = "predictKEY";
            this.predictKEY.Size = new System.Drawing.Size(400, 20);
            this.predictKEY.TabIndex = 7;
            this.predictKEY.Text = "1b9697a8c6704cbfafcbb01d6b12d031";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Prediction URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prediction KEY";
            // 
            // responseBox
            // 
            this.responseBox.Location = new System.Drawing.Point(33, 406);
            this.responseBox.Name = "responseBox";
            this.responseBox.Size = new System.Drawing.Size(399, 174);
            this.responseBox.TabIndex = 10;
            this.responseBox.Text = "";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 586);
            this.Controls.Add(this.responseBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.predictKEY);
            this.Controls.Add(this.predictURL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputImageFileName);
            this.Controls.Add(this.inputImageFileName);
            this.Controls.Add(this.buttBrowseImage);
            this.Controls.Add(this.outputImage);
            this.Controls.Add(this.inputImage);
            this.Name = "MainUI";
            this.Text = "Object Detection";
            ((System.ComponentModel.ISupportInitialize)(this.inputImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox inputImage;
        private System.Windows.Forms.PictureBox outputImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttBrowseImage;
        private System.Windows.Forms.Label inputImageFileName;
        private System.Windows.Forms.Label outputImageFileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox predictURL;
        private System.Windows.Forms.TextBox predictKEY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox responseBox;
    }
}

