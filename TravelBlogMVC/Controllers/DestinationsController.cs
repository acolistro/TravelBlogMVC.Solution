using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelBlog.Controllers
{
  // [Route("api/[controller]")]
  // [ApiController]
  public class DestinationsController : ControllerBase
  {
    private TravelBlogContext _db;
    public DestinationsController(TravelBlogContext db)
    {
      _db = db;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Destination>> Get(string location, int year)
    {
      var query = _db.Destinations.AsQueryable();

      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }

      if (year != 0)
      {
        query = query.Where(entry => entry.Year == year);
      }
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Destination destination)
    {
      _db.Destinations.Add(destination);
      _db.SaveChanges();
    }
    [HttpGet("{id}")]
    public ActionResult<Destination> Get(int id)
    {
      return _db.Destinations.FirstOrDefault(entry => entry.DestinationId == id);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Destination destination)
    {
      destination.DestinationId = id;
      _db.Entry(destination).State = EntityState.Modified;
      _db.SaveChanges();
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var destinationDelete = _db.Destinations.FirstOrDefault(entry => entry.DestinationId == id);
      _db.Destinations.Remove(destinationDelete);
      _db.SaveChanges();
    }
  }
}