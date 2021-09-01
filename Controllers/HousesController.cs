using System.Collections.Generic;
using gregslist_c_sharp.Models;
using gregslist_c_sharp.Service;
using Microsoft.AspNetCore.Mvc;

namespace gregslist_c_sharp.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class HousesController : ControllerBase
    {
    private readonly HousesService _housesService;

    public HousesController(HousesService housesService)
    {
      _housesService = housesService;
    }

    [HttpGet]
    public ActionResult <IEnumerable <House>> Get()
    {
        try
        {
            IEnumerable<House> jobs = _housesService.Get();
            return Ok(jobs);
        }
        catch (System.Exception err)
        {
            return BadRequest(err.Message);
        }
    }

    [HttpGet("{id}")]
    public ActionResult <House> Get(string id)
    {
        try
        {
            House found = _housesService.Get(id);
            return Ok(found);
        }
        catch (System.Exception err)
        {
            return BadRequest(err.Message);
        }
    }

    [HttpPost]
    public ActionResult<House> Create([FromBody] House rawHouse)
    {
        try
        {
            House madeHouse = _housesService.Create(rawHouse);
            return Ok(madeHouse);
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
            _housesService.Delete(id);
            return Ok("Deleted Job");
        }
        catch (System.Exception err)
        {
            return BadRequest(err.Message);
        }
    }
    }
}