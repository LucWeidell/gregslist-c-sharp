using System.Collections.Generic;
using gregslist_c_sharp.Models;
using gregslist_c_sharp.Service;
using Microsoft.AspNetCore.Mvc;

namespace gregslist_c_sharp.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]

    public class JobsController : ControllerBase
    {
        private readonly JobsService jobsService;

    public JobsController(JobsService jobsService)
    {
      this.jobsService = jobsService;
    }

    [HttpGet]
    public ActionResult <IEnumerable <Job>> Get()
    {
        try
        {
            IEnumerable<Job> jobs = jobsService.Get();
            return Ok(jobs);
        }
        catch (System.Exception err)
        {
            return BadRequest(err.Message);
        }
    }

    [HttpGet("{id}")]
    public ActionResult <Job> Get(string id)
    {
        try
        {
            Job found = jobsService.Get(id);
            return Ok(found);
        }
        catch (System.Exception err)
        {
            return BadRequest(err.Message);
        }
    }

    [HttpPost]
    public ActionResult<Job> Create([FromBody] Job rawJob)
    {
        try
        {
            Job madeJob = jobsService.Create(rawJob);
            return Ok(madeJob);
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
            jobsService.Delete(id);
            return Ok("Deleted Job");
        }
        catch (System.Exception err)
        {
            return BadRequest(err.Message);
        }
    }
  }
}