using System;
using System.Threading.Tasks;
using AulaRepositoryPattern.Data.Repositories.Abstractions;
using AulaRepositoryPattern.Domain;
using Microsoft.AspNetCore.Mvc;

namespace AulaRepositoryPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddCar()
        {
            var car = new Car(Guid.NewGuid(), "Etios", 400);
            await _carRepository.AddAsync(car);
            return Ok(car);
        }
    }
}