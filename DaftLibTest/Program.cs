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
                .WithAdState(new[] { AdState.Available })
                .WithKeyword("dublin");

            var rslt = await d.Search(sb.Build());
            if(rslt != null)
            {
                //do something with rslt
            }
        }
    }
}
