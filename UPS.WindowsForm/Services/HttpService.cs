using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UPS.WindowsForm.Models;

namespace UPS.WindowsForm.Services
{
    public class HttpService
    {
        //*******************************************************************************************************
        //Variables:

        //*******************************************************************************************************
        //Todo: ensure the exception has handled.
        private static async Task ValidateResponse(HttpResponseMessage httpResponseMessage)
        {
            if (httpResponseMessage.IsSuccessStatusCode)
                return;
            throw new BusinessException(await httpResponseMessage.Content.ReadAsStringAsync());
        }
        //*******************************************************************************************************
        /// <summary>
        /// Post
        /// </summary>
        /// <typeparam name="Tinput"></typeparam>
        /// <typeparam name="TOutPut"></typeparam>
        /// <param name="httpClinet"></param>
        /// <param name="url"></param>
        /// <param name="contentValue"></param>
        /// <returns></returns>
        public static async Task<TOutPut> PostAsync<Tinput, TOutPut>(string url, Tinput contentValue, string authorization = "", int timeoutSec = 60)
        {
            HttpClient httpClinet = GetHttpClient(authorization, timeoutSec);
            var content = new StringContent(JsonConvert.SerializeObject(contentValue), Encoding.UTF8, "application/json");
            var response = await httpClinet.PostAsync(url, content);
            await ValidateResponse(response);
            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TOutPut>(result);
        }
        //*******************************************************************************************************
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="httpClinet"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static async Task DeleteAsync(string url, string authorization = "", int timeoutSec = 60)
        {
            HttpClient httpClinet = GetHttpClient(authorization, timeoutSec);
            var result = await httpClinet.DeleteAsync(url);
            await ValidateResponse(result);
        }
        //*******************************************************************************************************
        /// <summary>
        /// Put
        /// </summary>
        /// <typeparam name="Tinput"></typeparam>
        /// <typeparam name="TOutPut"></typeparam>
        /// <param name="httpClinet"></param>
        /// <param name="url"></param>
        /// <param name="stringValue"></param>
        /// <returns></returns>
        public static async Task<TOutPut> PutAsync<Tinput, TOutPut>(string url, Tinput stringValue, string authorization = "", int timeoutSec = 60)
        {
            HttpClient httpClinet = GetHttpClient(authorization, timeoutSec);
            var content = new StringContent(JsonConvert.SerializeObject(stringValue), Encoding.UTF8, "application/json");
            var response = await httpClinet.PutAsync(url, content);
            await ValidateResponse(response);
            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TOutPut>(result);

        }
        //*******************************************************************************************************
        /// <summary>
        /// Get
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="httpClinet"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static async Task<T> GetAsync<T>(string url, Dictionary<string, object> parameters = null, string authorization = "", int timeoutSec = 60)
        {
            HttpClient httpClinet = GetHttpClient(authorization, timeoutSec);
            url += "?" + ParseQueryString(parameters);
            var result = await httpClinet.GetAsync(url);
            await ValidateResponse(result);
            string resultContentString = await result.Content.ReadAsStringAsync();
            if (typeof(T) == typeof(string)) return (T)(object)resultContentString;
            T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
            return resultContent;
        }
        //*******************************************************************************************************
        /// <summary>
        /// Create query string from parameters.
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private static string ParseQueryString(Dictionary<string, object> parameters)
        {
            if (parameters == null)
                return string.Empty;
            var result = new List<string>();
            foreach (var dic in parameters)
            {
                result.Add(dic.Key + "=" + dic.Value);
            }

            return string.Join("&", result);
        }
        //*******************************************************************************************************
        /// <summary>
        /// Get a HttpClient instance.
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="timeoutSec"></param>
        /// <returns></returns>
        private static HttpClient GetHttpClient(string authorization = "", int timeoutSec = 60)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(timeoutSec);
            if (!string.IsNullOrEmpty(authorization))
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", authorization);
            return httpClient;
        }
        //*******************************************************************************************************
    }
}
