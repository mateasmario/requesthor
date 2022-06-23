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
using TheArtOfDev.HtmlRenderer.WinForms;

namespace requesthor.Services
{
    internal class RequestService
    {
        public static HttpClient CreateClientWithHeaders(string authorization, Dictionary<string, string> headers)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Clear();

            if (authorization != "")
                client.DefaultRequestHeaders.Add("Authorization", authorization);

            foreach (var header in headers)
                client.DefaultRequestHeaders.Add(header.Key, header.Value);

            return client;
        }
        public static void SendRequest(string method, string url, string headerString, string bodyString, string authorization, RichTextBox ResponseRichTextBox, Label StatusCodeLabel)
        {
            if (headerString == "") headerString = "{}";

            try
            {
                var headers = JsonConvert.DeserializeObject<Dictionary<string, string>>(headerString);

                if (method == "GET")
                    RequestService.GetRequest(url, authorization, ResponseRichTextBox, StatusCodeLabel, headers);
                else if (method == "POST")
                    RequestService.PostRequest(url, authorization, bodyString, ResponseRichTextBox, StatusCodeLabel, headers);                
                else if (method == "PUT")
                    RequestService.PutRequest(url, authorization, bodyString, ResponseRichTextBox, StatusCodeLabel, headers);                
                else if (method == "DELETE")
                    RequestService.DeleteRequest(url, authorization, ResponseRichTextBox, StatusCodeLabel, headers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to deserialize JSON header.");
            }
        }

        public static async Task GetRequest(string url, string authorization, RichTextBox ResponseRichTextBox, Label StatusCodeLabel, Dictionary<string, string> headers)
        {
            string response = "";

            var client = CreateClientWithHeaders(authorization, headers);


            try
            {
                var result = await client.GetAsync(url);
                string content = null;

                using (var sr = new StreamReader(await result.Content.ReadAsStreamAsync(), Encoding.GetEncoding("iso-8859-1")))
                    content = sr.ReadToEnd();

                OutputResponse(result, content, StatusCodeLabel, ResponseRichTextBox);

            }
            catch (Exception ex)
            {
                OutputException(ex, StatusCodeLabel, ResponseRichTextBox);
            }
        }

        public static async Task PostRequest(string url, String authorization, String bodyString, RichTextBox ResponseRichTextBox, Label StatusCodeLabel, Dictionary<string, string> headers)
        {
            string response = "";

            var client = CreateClientWithHeaders(authorization, headers);

                try
                {
                    string json = JsonConvert.SerializeObject(bodyString);
                    var httpContent = new StringContent(bodyString, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(url, httpContent);
                    string content = null;

                    using (var sr = new StreamReader(await result.Content.ReadAsStreamAsync(), Encoding.GetEncoding("iso-8859-1")))
                        content = sr.ReadToEnd();

                    OutputResponse(result, content, StatusCodeLabel, ResponseRichTextBox);

                }
                catch (Exception ex)
                {
                    OutputException(ex, StatusCodeLabel, ResponseRichTextBox);
                }
        }

        public static async Task PutRequest(string url, String authorization, String bodyString, RichTextBox ResponseRichTextBox, Label StatusCodeLabel, Dictionary<string, string> headers)
        {
            string response = "";

            var client = CreateClientWithHeaders(authorization, headers);

            try
            {
                string json = JsonConvert.SerializeObject(bodyString);
                var httpContent = new StringContent(bodyString, Encoding.UTF8, "application/json");
                var result = await client.PutAsync(url, httpContent);
                string content = null;

                using (var sr = new StreamReader(await result.Content.ReadAsStreamAsync(), Encoding.GetEncoding("iso-8859-1")))
                    content = sr.ReadToEnd();

                OutputResponse(result, content, StatusCodeLabel, ResponseRichTextBox);

            }
            catch (Exception ex)
            {
                OutputException(ex, StatusCodeLabel, ResponseRichTextBox);
            }
        }

        public static async Task DeleteRequest(string url, String authorization, RichTextBox ResponseRichTextBox, Label StatusCodeLabel, Dictionary<string, string> headers)
        {
            string response = "";

            var client = CreateClientWithHeaders(authorization, headers);

            try
            {
                var result = await client.DeleteAsync(url);
                string content = null;

                using (var sr = new StreamReader(await result.Content.ReadAsStreamAsync(), Encoding.GetEncoding("iso-8859-1")))
                    content = sr.ReadToEnd();

                OutputResponse(result, content, StatusCodeLabel, ResponseRichTextBox);

            }
            catch (Exception ex)
            {
                OutputException(ex, StatusCodeLabel, ResponseRichTextBox);
            }
        }

        public static void OutputResponse(HttpResponseMessage result, string content, Label StatusCodeLabel, RichTextBox ResponseRichTextBox)
        {
            if (result.IsSuccessStatusCode)
                StatusCodeLabel.Parent.BackColor = Color.MediumSeaGreen;
            else
                StatusCodeLabel.Parent.BackColor = Color.Crimson;

            StatusCodeLabel.Text = "Response: " + ((double)result.StatusCode).ToString() + " " + result.StatusCode.ToString();

            if (FormatService.GetFormat(content) == "HTML")
            {
                ResponseRichTextBox.Text = content;
                FormatService.HighlightHtmlInRichTextBox(ResponseRichTextBox);
            }
            else if (FormatService.GetFormat(content) == "Json")
                ResponseRichTextBox.Text = FormatService.JsonFormat(content);
            else ResponseRichTextBox.Text = content;
        }

        public static void OutputException(Exception ex, Label StatusCodeLabel, RichTextBox ResponseRichTextBox)
        {
            StatusCodeLabel.Text = "Error: " + ex.GetType().Name.ToString();
            StatusCodeLabel.Parent.BackColor = Color.Crimson;

            ResponseRichTextBox.Text = ex.Message;
        }
    }
}
