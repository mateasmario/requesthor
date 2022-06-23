using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace requesthor.Services
{
    internal class RequestService
    {
        public static string ProcessURL(string url)
        {
            if (url.Length >= 7 && url.Substring(0, 7) == "http://"
                || url.Length >= 8 && url.Substring(0, 8) == "https://")
                return url;

            else return "http://" + url;
        }
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
            url = ProcessURL(url);

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
            var client = CreateClientWithHeaders(authorization, headers);

            try
            {
                var result = await client.GetAsync(url);
                OutputResponse(result, StatusCodeLabel, ResponseRichTextBox);
            }
            catch (Exception ex)
            {
                OutputException(ex, StatusCodeLabel, ResponseRichTextBox);
            }
        }

        public static async Task PostRequest(string url, String authorization, String bodyString, RichTextBox ResponseRichTextBox, Label StatusCodeLabel, Dictionary<string, string> headers)
        {
            var client = CreateClientWithHeaders(authorization, headers);

            try
            {
                string json = JsonConvert.SerializeObject(bodyString);
                var httpContent = new StringContent(bodyString, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, httpContent);
                OutputResponse(result, StatusCodeLabel, ResponseRichTextBox);
            }
            catch (Exception ex)
            {
                OutputException(ex, StatusCodeLabel, ResponseRichTextBox);
            }
        }

        public static async Task PutRequest(string url, String authorization, String bodyString, RichTextBox ResponseRichTextBox, Label StatusCodeLabel, Dictionary<string, string> headers)
        {
            var client = CreateClientWithHeaders(authorization, headers);

            try
            {
                string json = JsonConvert.SerializeObject(bodyString);
                var httpContent = new StringContent(bodyString, Encoding.UTF8, "application/json");
                var result = await client.PutAsync(url, httpContent);
                OutputResponse(result, StatusCodeLabel, ResponseRichTextBox);
            }
            catch (Exception ex)
            {
                OutputException(ex, StatusCodeLabel, ResponseRichTextBox);
            }
        }

        public static async Task DeleteRequest(string url, String authorization, RichTextBox ResponseRichTextBox, Label StatusCodeLabel, Dictionary<string, string> headers)
        {
            var client = CreateClientWithHeaders(authorization, headers);

            try
            {
                var result = await client.DeleteAsync(url);
                OutputResponse(result, StatusCodeLabel, ResponseRichTextBox);
            }
            catch (Exception ex)
            {
                OutputException(ex, StatusCodeLabel, ResponseRichTextBox);
            }
        }

        public static async Task OutputResponse(HttpResponseMessage result, Label StatusCodeLabel, RichTextBox ResponseRichTextBox)
        {
            string content;

            if (result.StatusCode != System.Net.HttpStatusCode.NoContent)
            {
                using (var sr = new StreamReader(await result.Content.ReadAsStreamAsync(), Encoding.GetEncoding("iso-8859-1")))
                    content = sr.ReadToEnd();
            }
            else content = "No content.";

            if (result.IsSuccessStatusCode)
                StatusCodeLabel.Parent.BackColor = Color.MediumSeaGreen;
            else
                StatusCodeLabel.Parent.BackColor = Color.Crimson;

            StatusCodeLabel.Text = "Response: " + ((double)result.StatusCode).ToString() + " " + result.StatusCode.ToString();
            ResponseRichTextBox.Text = "";

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
