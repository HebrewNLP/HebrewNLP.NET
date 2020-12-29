using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace HebrewNLP
{
    public class Service<TRequest> where TRequest : BaseRequest
    {
        private readonly string EndPoint;

        public Service(string endPoint)
        {
            EndPoint = endPoint;
        }

        public const string API_DOMAIN = "https://hebrew-nlp.co.il";

        private string PostJSONData(string url, string data)
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(API_DOMAIN + url);
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            request.ContentType = "application/json; encoding='utf-8'";
            request.ContentLength = bytes.Length;
            request.Method = "POST";
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();
            var response = (HttpWebResponse) request.GetResponse();
            var responseStream = response.GetResponseStream();
            string responseStr = null;
            if (responseStream != null)
                responseStr = new StreamReader(responseStream).ReadToEnd();
            if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception($"Error in server. respone: " +
                                    JsonConvert.SerializeObject(new {response.StatusCode, response = responseStr}));
            return responseStr;
        }

        public TResponse GetService<TResponse>(TRequest request)
        {
            request.token = HebrewNLP.Password;
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = PostJSONData(EndPoint, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                ErrorResponse error = JsonConvert.DeserializeObject<ErrorResponse>(responseJson);
                throw new Exception(error.error);
            }

            return JsonConvert.DeserializeObject<TResponse>(responseJson);
        }
    }
}