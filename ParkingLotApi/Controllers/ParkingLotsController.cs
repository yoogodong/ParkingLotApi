using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ParkingLotApi.Models;
using ParkingLotApi.Services;
using System.Net;

namespace ParkingLotApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParkingLotsController : ControllerBase
    {
        private ParkingLotService service;

        public ParkingLotsController(ParkingLotService service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<ActionResult> Create(ParkingLot parkingLot)
        {
                string id = await service.Create(parkingLot);
                return new CreatedResult(nameof(Create), id);
        }
    }
}
