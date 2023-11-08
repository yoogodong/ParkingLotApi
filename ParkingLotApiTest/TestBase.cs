using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApiTest
{

    public class TestBase : IClassFixture<WebApplicationFactory<Program>>
    {
        public TestBase(WebApplicationFactory<Program> factory)
        {
            this.Factory = factory;
        }

        private protected WebApplicationFactory<Program> Factory { get; }

        private protected HttpClient GetClient() => Factory.CreateClient();
    }
}
