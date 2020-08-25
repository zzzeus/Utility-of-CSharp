using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web;

namespace Utility_CSharp
{
    class Program
    {

        static void Main(string[] args)
        {

            // var collection = HtmlHelper.parseQuery(@"https://web.vortex.data.microsoft.com/collect/v1/t.js?ver=%272.1%27&name=%27Ms.Webi.PageAction%27&time=%272020-08-25T12%3A03%3A48.662Z%27&os=%27Windows%27&appId=%27JS%3ADocs%27&-ver=%271.0%27&-impressionGuid=%27213aa894-a40a-4c82-af12-4fa5bbb2f0af%27&-pageName=%27ee8e516e-17bf-acb8-1921-ca29a663fa97%27&-uri=%27https%3A%2F%2Fdocs.microsoft.com%2Fzh-cn%2Fdotnet%2Fapi%2Fmicrosoft.activities.build.debugger%3Fview%3Dnetframework-4.7.1%27&-pageTags=%27%7B%22translationtype%22%3A%22MT%22%2C%22lasthandoff%22%3A%2208%2F24%2F2018%22%2C%22locfileid%22%3A%2230724931%22%2C%22author%22%3A%22dotnet-bot%22%2C%22pgauth%22%3A%22dotnetcontent%22%2C%22pgtop%22%3A%22managed-reference%22%2C%22date%22%3A%2204%2F30%2F2018%22%2C%22technology%22%3A%22microsoft.activities%22%2C%22product%22%3A%22dotnet-api%22%2C%22depotname%22%3A%22VS.dotnet-api-docs%22%2C%22publishtime%22%3A%222020-07-02%2009%3A23%20AM%22%2C%22document_version_independent_id%22%3A%22790c9813-7d2d-7fa5-fc51-eedbed3332ee%22%2C%22giturl%22%3A%22https%3A%2F%2Fgithub.com%2Fdotnet%2Fdotnet-api-docs.zh-cn%2Fblob%2Flive-sxs%2Fxml%2Fns-Microsoft.Activities.Build.Debugger.xml%22%2C%22asst%22%3A%22Microsoft.Activities.Build.Debugger%22%2C%22contentlocale%22%3A%22zh-cn%22%2C%22highContrast%22%3A%22false%22%2C%22metaTags%22%3A%7B%7D%7D%27&-contentVer=%272.0%27&-market=%27zh-cn%27&-pageType=%27dotnet%27&-behavior=0&-content=%27%5B%7B%22event%22%3A%22user-is-signed-in%22%7D%5D%27&*baseType=%27Ms.Content.PageAction%27&*timeToAction=641&*cookieEnabled=true&*isJs=true&*title=%27Microsoft.Activities.Build.Debugger%20Namespace%20%7C%20Microsoft%20Docs%27&*isLoggedIn=false&*isManual=true&*referrerUri=%27https%3A%2F%2Fdocs.microsoft.com%2Fzh-cn%2Fdotnet%2Fapi%2F%3Fview%3Dnetframework-4.7.1%27&ext-javascript-ver=%271.1%27&ext-javascript-libVer=%274.2.14%27&ext-javascript-domain=%27docs.microsoft.com%27&ext-javascript-msfpc=%27GUID%3D7fb7065c94b9475c86688f06a04dd764%26HASH%3D7fb7%26LV%3D201910%26V%3D4%26LU%3D1571894665779%27&ext-javascript-userConsent=true&ext-javascript-anid=%27A%3D07324BC935C6C47A1B642638FFFFFFFF%27&ext-user-localId=%27t%3A24BA59268F66667C2AED54D08B6665DF%27&ext-app-userId=%27c%3A33810698-6568-43bf-9463-c6de40fa97fd%27&$mscomCookies=false");
            // // Console.WriteLine(text);
            // if (collection!=null)
            // {
            //     foreach (var item in collection.AllKeys)
            //     {
            //         Console.WriteLine("{0}: {1}",item,collection[item]);
            //     }
            // }
            // Console.WriteLine(HtmlHelper.encodeUrl(@"https://docs.microsoft.com?q=泽啊"));

            // var dat1 = new DateTime();
            // // The following method call displays 1/1/0001 12:00:00 AM.
            // Console.WriteLine(dat1.ToString(System.Globalization.CultureInfo.InvariantCulture));
            // // The following method call displays True.
            // Console.WriteLine(dat1.Equals(DateTime.MinValue));

            // var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            // Console.WriteLine(date1);

            // var now = DateTime.Now;
            // Console.WriteLine(now);
            
            var status = NetHelper.ping("216.58.199.228");
            // if (status)
            // {
                
            // }
        }
    }
}
