using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using ParkingLotApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApiTest.Controllers
{
    public class WeatherForcastControllerTest : TestBase
    {
        HttpClient httpClient;
        public WeatherForcastControllerTest(WebApplicationFactory<Program> factory):base(factory)
        {
            httpClient = GetClient();
        }

        [Fact]
        public async Task Test1Async()
        {
            HttpResponseMessage resp = await httpClient.GetAsync("/WeatherForecast");

            WeatherForecast weatherForecast = new WeatherForecast();
            

            Assert.Equal(HttpStatusCode.OK, resp.StatusCode);
            //List<WeatherForecast>? weatherForecasts = await resp.Content.ReadFromJsonAsync<List<WeatherForecast>>();
            //Assert.Equal(weatherForecast, weatherForecasts[0]);
        }
    }
}
