using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BumblebeeAndroid.Exentions
{
    internal static class InnerConvenience
    {
        internal static WebResponse ExecutePost(string uriString, string jsonBody)
        {
            var req = WebRequest.Create(uriString);

            req.Method = "POST";
            req.ContentType = "application/json";
            if (jsonBody != null)
            {
                byte[] requestData = new ASCIIEncoding().GetBytes(jsonBody);
                req.ContentLength = requestData.Length;
                req.GetRequestStream().Write(requestData, 0, requestData.Length);
                req.GetRequestStream().Close();
            }

            return req.GetResponse();
        }
    }
}
