using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcceptedAssignment.Litedb;
using AcceptedAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcceptedAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IAssignmentService _storeService;
        public BookController(IAssignmentService storeService)
        {
            _storeService = storeService;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _storeService.GetAll();
        }

        [HttpGet("{Id}", Name = "FindOne")]
        public ActionResult<Book> Get(int Id)
        {
            Book result = _storeService.GetById(Id);
            if (result != null && result != default) return Ok(result);
            return NotFound();
        }

        [HttpPost]
        public ActionResult<Book> Insert([FromBody]Book b)
        {
            var id = _storeService.Insert(b);
            if (id!=default) return Ok(b);
            return BadRequest();
        }

        [HttpPut]
        public ActionResult<Book> Update(Book b)
        {
            var result = _storeService.Updatedb(b);
            if (result)
                return NoContent();
            else
                return NotFound();
        }

    }
}