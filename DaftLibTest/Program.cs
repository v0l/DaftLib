using DaftLib;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace DaftLibTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var q = "dublin";

            var d = new Daft();

            var sb = new SearchBuilder()
                .WithAddState(new[] { AdState.Available })
                .WithKeyword(q);

            var rslt = await d.Search(sb.Build());
            if(rslt != null)
            {
                Console.WriteLine(JsonSerializer.Serialize(rslt, options: new JsonSerializerOptions()
                {
                    WriteIndented = true
                }));
            }
        }
    }
}
