using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using VxFormGenerator.Core.Render;
using System.Linq;
using VxFormGenerator.Core;

namespace VxFormGeneratorDemoData
{
    public class CityResolver : VxLookupKeyValue
    {
        public override string Name { get; set; } = "CITY_LOOKUP";

        private List<City> Cities;

        public CityResolver()
        {
            Cities = new List<City>();
            Cities.Add(new City{Id = 1, Name = "UDINE"});
            Cities.Add(new City{Id = 2, Name = "ALESSANDRIA"});
            Cities.Add(new City{Id = 3, Name = "BOLOGNA"});
            Cities.Add(new City{Id = 4, Name = "TREVISO"});
            Cities.Add(new City{Id = 5, Name = "PORDENONE"});

        }

        public override Task<VxLookupResult<string>> GetLookupValues(object param)
        {
            CancellationTokenSource source = new CancellationTokenSource();
            var taskResult = this.DataRetriever(source);
            return taskResult;

        }
        
        private async Task<VxLookupResult<string>> DataRetriever(CancellationTokenSource source)
        {
            await Task.Delay(2000, source.Token);

            var CityValues = VxHelpers.ListLookupConverter(Cities,"Id","Name","Name");
      
            var result = new VxLookupResult<string>() { Name = Name, Values = CityValues};

            return result;
        }
        
        
    }
}

public class City
{
    public int Id { get; set; }
    public string Name { get; set; }


}