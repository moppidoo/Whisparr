using System;
using System.Net.Http;
using Newtonsoft.Json;
using NzbDrone.Core.MetadataSource.Custom.Models;

namespace NzbDrone.Core.MetadataSource.Custom
{
    public class MetadataProviderService
    {
         public InternalScene FetchScene(string term)
         {
            try
            {
               var url = $"http://localhost:3000/api/v1/scene/{term}";
               using var client = new HttpClient();
               var response = client.GetAsync(url).Result;

               if (!response.IsSuccessStatusCode)
               {
                     Console.WriteLine($"[FetchScene] Failed to fetch scene: {response.StatusCode} - {response.ReasonPhrase}");
                     return null;
               }

               var json = response.Content.ReadAsStringAsync().Result;

               // Use Newtonsoft.Json to deserialize
               return JsonConvert.DeserializeObject<InternalScene>(json);
            }
            catch (Exception ex)
            {
               Console.WriteLine($"[FetchScene] Exception: {ex.Message}");
               return null;
            }
         }


    }
}
