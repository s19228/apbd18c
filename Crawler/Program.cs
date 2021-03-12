using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Crawler
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            var url = args[0];

            // po wykonaniu kodu zwalnia zasoby które zostały przyznane httpClientowi

            using (var httpClient = new HttpClient()) 
            {
                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    var regex = new Regex("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

                    var emailAdresses = regex.Matches(content);


                    foreach (var match in emailAdresses)
                    {
                        System.Console.WriteLine(match.ToString());
                    }

                }
            };





        }
    }
}
 