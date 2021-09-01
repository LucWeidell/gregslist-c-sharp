using System.Collections.Generic;
using gregslist_c_sharp.Models;
using gregslist_c_sharp.Service;
using Microsoft.AspNetCore.Mvc;

namespace gregslist_c_sharp.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly CarsService _carsService;

    public CarsController(CarsService carsService)
    {
      _carsService = carsService;
    }

        public ActionResult <IEnumerable <Car>> Get()
    {
        try
        {
            IEnumerable<Car> jobs = _carsService.Get();
            return Ok(jobs);
        }
        catch (System.Exception err)
        {
            return BadRequest(err.Message);
        }
    }

    [HttpGet("{id}")]
    public ActionResult <Car> Get(string id)
    {
        try
        {
            Car found = _carsService.Get(id);
            return Ok(found);
        }
        catch (System.Exception err)
        {
            return BadRequest(err.Message);
        }
    }

    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car rawCar)
    {
        try
        {
            Car madeCar = _carsService.Create(rawCar);
            return Ok(madeCar);
        }
        catch (System.Exception err)
        {
            return BadRequest(err.Message);
        }
    }

    [HttpDelete("{id}")]
    public ActionResult<string> Delete(string id)
    {
        try
        {
            _carsService.Delete(id);
            return Ok("Deleted Job");
        }
        catch (System.Exception err)
        {
            return BadRequest(err.Message);
        }
    }
  }
}