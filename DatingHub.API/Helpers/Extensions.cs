using Microsoft.AspNetCore.Http;

namespace DatingHub.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Applcation-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}