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
            HttpWebResponse response;
            response = (HttpWebResponse) request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream responseStream = response.GetResponseStream();
                string responseStr = new StreamReader(responseStream).ReadToEnd();
                return responseStr;
            }

            return null;
        }

        public TResponse GetService<TResponse>(TRequest request)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                const string url = "https://hebrew-nlp.co.il/registration";
                var message =$@"Please set HebrewNLP.Password property with your password before using this method.
 To get a password register at {url} .
(The program will open the browser automaticaly)";
                var messageException =
                    $@"Cannot use the service without initialising HebrewNLP.Password property with your password.
 To get a password register at {url} .";
                Console.Error.WriteLine(message);
                Console.Error.WriteLine();
                new Process
                {
                    // true is the default, but it is important not to set it to false
                    StartInfo = {UseShellExecute = true, FileName = url}
                }.Start();
                throw new InvalidOperationException(messageException);
            }

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