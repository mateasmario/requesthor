using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace requesthor.Services
{
    internal class RequestService
    {
        public static void SendRequest(string method, string url, string headerString, RichTextBox ResponseRichTextBox, Label StatusCodeLabel)
        {
            if (headerString == "") headerString = "{}";
            var headers = JsonConvert.DeserializeObject<Dictionary<string, string>>(headerString);

            if (method == "GET")
                RequestService.GetRequest(url, ResponseRichTextBox, StatusCodeLabel, headers);
        }
        public static async Task GetRequest(string url, RichTextBox ResponseRichTextBox, Label StatusCodeLabel, Dictionary<string, string> headers)
        {
            string response = "";

            var client = new HttpClient();
            client.DefaultRequestHeaders.Clear();

            foreach (var header in headers)
                client.DefaultRequestHeaders.Add(header.Key, header.Value);

            try
            {
                var result = await client.GetAsync(url);
                string content = null;

                using (var sr = new StreamReader(await result.Content.ReadAsStreamAsync(), Encoding.GetEncoding("iso-8859-1")))
                    content = sr.ReadToEnd();

                ResponseRichTextBox.Text = content;

                if (result.IsSuccessStatusCode)
                    StatusCodeLabel.Parent.BackColor = Color.MediumSeaGreen;
                else
                    StatusCodeLabel.Parent.BackColor = Color.Crimson;

                StatusCodeLabel.Text = ((double)result.StatusCode).ToString() + " " + result.StatusCode.ToString();
                StatusCodeLabel.Parent.Show();
            }
            catch (Exception ex)
            {
                StatusCodeLabel.Text = "Error: " + ex.GetType().Name.ToString();
                StatusCodeLabel.Parent.BackColor = Color.Crimson;
                StatusCodeLabel.Parent.Show();
                ResponseRichTextBox.Text = ex.Message;
            }
        }

    }
}
