using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.Linq;
using TodoApi.Models;

namespace TodoApi.Controllers
{

    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        static readonly List<TodoItem> _items = new List<TodoItem>()
        {
            new TodoItem { Id = 1, Title = "First Item" }
        };

        [HttpGet]
        public IEnumerable<TodoItem> GetAll()
        {
            return _items;
        }

        [HttpGet("{id:int}", Name = "GetByIdRoute")]
        public IActionResult GetById (int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return HttpNotFound();
            }

            return new ObjectResult(item);
        }

        [HttpPost]
        public void CreateTodoItem([FromBody] TodoItem item)
        {
            if (!ModelState.IsValid)
            {
                Context.Response.StatusCode = 400;
            }
            else
            {
                item.Id = 1+ _items.Max(x => (int?)x.Id) ?? 0;
                _items.Add(item);

                string url = Url.RouteUrl("GetByIdRoute", new { id = item.Id }, 
                    Request.Scheme, Request.Host.ToUriComponent());

                Context.Response.StatusCode = 201; //201 Created
                Context.Response.Headers["Location"] = url;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteItem(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return HttpNotFound();
            }
            _items.Remove(item);
            return new HttpStatusCodeResult(204); // 204 No Content
        }
    }
}