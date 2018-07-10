using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace HebrewNLP
{
    public class Util
    {

        public const string API_DOMAIN = "https://hebrew-nlp.co.il";

        public static string PostJSONData(string url, string data)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(API_DOMAIN + url);
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            request.ContentType = "application/json; encoding='utf-8'";
            request.ContentLength = bytes.Length;
            request.Method = "POST";
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();
            HttpWebResponse response;
            response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream responseStream = response.GetResponseStream();
                string responseStr = new StreamReader(responseStream).ReadToEnd();
                return responseStr;
            }
            return null;
        }


    }
}
