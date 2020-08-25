using System;
using System.Collections.Specialized;
using System.IO;
using System.Text;
using System.Web;

class HtmlHelper
{
    public static async System.Threading.Tasks.Task<string> getHtmlTextAsync(string path)
    {

        var context = await NetHelper.getHttpResponseAsync("http://baidu.com");
        return context;
    }
    // <html></html> -> &lt;html&gt;&lt;/html&gt;
    public static string encodeHtml(string text)
    {
        string myEncodedString = HttpUtility.HtmlEncode(text);

        StringWriter myWriter = new StringWriter();

        // Decode the encoded string.
        HttpUtility.HtmlDecode(myEncodedString, myWriter);

        string decodedString = myWriter.ToString();

        return decodedString;
    }
    // ?ver=1.0&name=zeus
    public static NameValueCollection parseQuery(string currurl)
    {
        string querystring = null;

        // Check to make sure some query string variables
        // exist and if not add some and redirect.
        int iqs = currurl.IndexOf('?');
        if (iqs == -1)
        {
            return null;
        }
        // If query string variables exist, put them in
        // a string.
        else if (iqs >= 0)
        {
            querystring = (iqs < currurl.Length - 1) ? currurl.Substring(iqs + 1) : String.Empty;
        }

        // Parse the query string variables into a NameValueCollection.
        NameValueCollection qscoll = HttpUtility.ParseQueryString(querystring);
        return qscoll;
    }
    public static string encodeUrl(string value){
        // "http://www.google.com/search?q=" + HtmlHelper.encodeUrl(@"泽啊")
        // return HttpUtility.UrlDecode(value);
        return Uri.EscapeUriString(value);
    }
}