using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ObjectDetection
{
    public partial class MainUI : Form
    {
        private async Task<string> MakePredictionRequest(string imageFilePath, string url, string apiKey)
        {

            var client = new HttpClient();

            // Request headers - replace this example key with your valid Prediction-Key.
            client.DefaultRequestHeaders.Add("Prediction-Key", apiKey);

            // Prediction URL - replace this example URL with your valid Prediction URL.
            //string url = apiURL;

            HttpResponseMessage response;

            // Request body. Try this sample with a locally stored image.
            byte[] byteData = GetImageAsByteArray(imageFilePath);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                response = await client.PostAsync(url, content);
                //Console.WriteLine(await response.Content.ReadAsStringAsync());
                return await response.Content.ReadAsStringAsync();
            }
        }
        private static byte[] GetImageAsByteArray(string imageFilePath)
        {
            FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            return binaryReader.ReadBytes((int)fileStream.Length);
        }
        public MainUI()
        {
            InitializeComponent();
        }

        private void buttBrowseImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputImage.Image = new Bitmap(openFileDialog1.FileName);
                inputImageFileName.Text = openFileDialog1.FileName;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string resp = await MakePredictionRequest(openFileDialog1.FileName, predictURL.Text, predictKEY.Text);
            //responseBox.AppendText(resp);
            PredictResponse predictObject = JsonConvert.DeserializeObject<PredictResponse>(resp);
            string maxTag = "";
            float maxProb = 0;
            Boundingbox maxBound = new Boundingbox();
            foreach (Prediction preObj in predictObject.predictions) 
            {
                if(preObj.probability > maxProb)
                {
                    maxTag = preObj.tagName;
                    maxProb = preObj.probability;
                    maxBound = preObj.boundingBox;
                }
            }
            responseBox.Text = "";
            Image outImage = (Image)inputImage.Image.Clone();
            responseBox.AppendText("Tag :" + maxTag + System.Environment.NewLine);
            responseBox.AppendText("Prob:" + maxProb + System.Environment.NewLine);
            responseBox.AppendText("Left:" + (maxBound.left * outImage.Width) + System.Environment.NewLine);
            responseBox.AppendText("Left:" + (maxBound.top * outImage.Height) + System.Environment.NewLine);
            responseBox.AppendText("Left:" + (maxBound.width * outImage.Width) + System.Environment.NewLine);
            responseBox.AppendText("Left:" + (maxBound.height * outImage.Height) + System.Environment.NewLine);
            Graphics gr = Graphics.FromImage(outImage);
            gr.DrawRectangle(new Pen(Color.White,10), maxBound.left*outImage.Width, maxBound.top * outImage.Height, maxBound.width * outImage.Width, maxBound.height * outImage.Height);
            outputImage.Image = outImage;
        }
    }
}
