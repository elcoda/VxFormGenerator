using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using VxFormGenerator.Core.Render;

namespace VxFormGeneratorDemoData
{
    public class CountryResolver : VxLookupKeyValue
    {
        public override string Name { get; set; } = "COUNTRY_LOOKUP";

        public override Task<VxLookupResult<string>> GetLookupValues(object param)
        {
            CancellationTokenSource source = new CancellationTokenSource();
            var taskResult = this.DataRetriever(source);
            return taskResult;

        }
        
        private async Task<VxLookupResult<string>> DataRetriever(CancellationTokenSource source)
        {
            await Task.Delay(2000, source.Token);
            var result = new VxLookupResult<string>() { Name = Name, Values = new Dictionary<string, string>()
                {
                    { "NL", "Netherlands" }, { "DE", "Germany" }, {"IT", "Italy"}, {"US", "United States"}
                } 
            };
            return result;
        }
    }
}