using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using ParkingLotApi;
using ParkingLotApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApiTest.Controllers
{
    public class ParkingLotController : TestBase
    {
        private const string url = "/parkinglots";
        HttpClient httpClient;
        public ParkingLotController(WebApplicationFactory<Program> factory):base(factory)
        {
            httpClient = GetClient();
        }


        [Fact]
        public async void Should_400_when_capacity_is_0_or_minus()
        {
            ParkingLot newLot = new ParkingLot()
            {
                Name = "1",
                Capacity = 0,
                Location = "1"
            };

            HttpResponseMessage resp = await httpClient.PostAsJsonAsync(url, newLot);

            Assert.Equal(HttpStatusCode.BadRequest,resp.StatusCode);

        }
    }
}
