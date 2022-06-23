using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace requesthor.Services
{
    internal class FormatService
    {
        public static string GetFormat(string content)
        {
            if (content[0] == '{' || content[0] == '[')
                return "Json";
            else if (content[0] == '<')
                return "HTML";
            else return "Text";
        }

        public static string JsonFormat(String content)
        {
            dynamic parsedJson = JsonConvert.DeserializeObject(content);
            return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
        }

        public static void HighlightHtmlInRichTextBox(RichTextBox ResponseRichTextBox)
        {
        }
    }
}
