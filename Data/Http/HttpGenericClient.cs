using BlazorRazden.App.Properties;
using System.Net.Http.Headers;
using System.Text;


namespace BlazorRazden.App.Data.Http
{
    internal class HttpGenericClient<T>
    {
        // GET Bitcoin price from CoinLore API, Use model CoinModel as generic type
        public async Task<T?> GetAsync(string requestUri, string hostHeader, Dictionary<string, string>? contentsParams = null, string token = "")
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
                    client.DefaultRequestHeaders.Add("Host", hostHeader);
                    client.DefaultRequestHeaders.Add("Connection", "keep-alive");
                    if (token.Length > 0)
                        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                    if (contentsParams is not null)
                    {
                        var content = new FormUrlEncodedContent(contentsParams);
                        string paramAsJSON = System.Text.Json.JsonSerializer.Serialize(content);
                        var contents = new StringContent(paramAsJSON, Encoding.UTF8, "application/json");
                    }

                    HttpResponseMessage response = await client.GetAsync(requestUri);
                    if (response.IsSuccessStatusCode && response.Content is object)
                    {
                        try
                        {
                            var contentStream = await response.Content.ReadAsStreamAsync();
                            if(contentStream is not null)
                                return await System.Text.Json.JsonSerializer.DeserializeAsync<T>(contentStream);
                            else
                                return default(T);
                        }
                        catch (Exception ex2)
                        {
                            Console.WriteLine(ex2.Message);
                            return default(T);
                        }
                    }
                    else
                    {
                        return default(T);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default(T);
            }
        }
    }
}
