using System;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;

class NetHelper
{
    static readonly HttpClient client = new HttpClient();
    public static async System.Threading.Tasks.Task<string> getHttpResponseAsync(string uri_path)
    {
        HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        return responseBody;
    }

    // https://docs.microsoft.com/en-us/dotnet/api/system.net.networkinformation.ping?view=netcore-3.1
    public static bool ping(string host){
          Ping pingSender = new Ping ();
            PingOptions options = new PingOptions ();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes (data);
            int timeout = 120;
            PingReply reply = pingSender.Send (host, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                // Console.WriteLine ("Address: {0}", reply.Address.ToString ());
                // Console.WriteLine ("RoundTrip time: {0}", reply.RoundtripTime);
                // Console.WriteLine ("Time to live: {0}", reply.Options.Ttl);
                // Console.WriteLine ("Don't fragment: {0}", reply.Options.DontFragment);
                // Console.WriteLine ("Buffer size: {0}", reply.Buffer.Length);
                
                return true;
            }
            return false;
    }
}