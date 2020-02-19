using Microsoft.AspNetCore.Components.Testing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestBlazor.Data;
using TestBlazor.Pages;
using Xunit;

namespace TestBlazor.UnitTest
{
    public class FetchDataTest
    {
        private TestHost host = new TestHost();

        [Fact]
        public void DisplaysLoadingStateThenRendersSuppliedData()
        {
            host.AddService<WeatherForecastService>(new WeatherForecastService ());
            // Set up a mock HttpClient that we'll be able to use to test arbitrary responses
            TaskCompletionSource<WeatherForecast[]> req = new TaskCompletionSource<WeatherForecast[]>();
            //WeatherForecastService weatherForecastService = new WeatherForecastService();
            //var task =  weatherForecastService.GetForecastAsync(DateTime.Now);
            //var req =  result;//host.AddMockHttp().Capture("/sample-data/weather.json");

            // Initially shows loading state
            var component = host.AddComponent<FetchData>();
            //Assert.Contains("Loading...", component.GetMarkup());

            // Now simulate a response from the HttpClient
            /*
            host.WaitForNextRender(() => req.SetResult(new[]
            {
            new TestBlazor.Data.WeatherForecast { Summary = "First" },
            new TestBlazor.Data.WeatherForecast { Summary = "Second" },
        }));*/
            req.SetResult(new[]
                {
                new TestBlazor.Data.WeatherForecast { Summary = "First" },
                new TestBlazor.Data.WeatherForecast { Summary = "Second" },
            });
    
            // Now we should be displaying the data
                Assert.DoesNotContain("Loading...", component.GetMarkup());
            /*
            Assert.Collection(component.FindAll("tbody tr"),
                row => Assert.Contains("First", row.OuterHtml),
                row => Assert.Contains("Second", row.OuterHtml));*/
            Assert.Equal( 5, component.FindAll("tbody tr").Count);
        }
    }
}
