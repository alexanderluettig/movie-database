using System.Net.Http.Json;
using System.Text;
using MovieDatabase.Backend.Controllers.Authentication;
using Newtonsoft.Json;

namespace MovieDatabase.Backend.Tests
{
    public static class HttpClientAuthExtension
    {

        public static async Task<string> LoginAsync(this HttpClient client, string email, string password)
        {
            var response = await client.PostAsync("/auth/login", new StringContent(
                JsonConvert.SerializeObject(new
                {
                    email,
                    password
                }), Encoding.UTF8, "application/json"));

            response.EnsureSuccessStatusCode();

            var authResponse = await response.Content.ReadFromJsonAsync<AuthenticationResponse>();

            if (authResponse == null)
            {
                throw new Exception("Failed to deserialize authentication response");
            }

            return authResponse.Token;
        }
    }
}
