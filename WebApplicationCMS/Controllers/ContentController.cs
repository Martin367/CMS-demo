using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCMS.Models;

namespace WebApplicationCMS.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content contents;
        public ContentController(Microsoft.Extensions.Options.IOptions<Content> option)
        {
            contents = option.Value;
        }
        public IActionResult Index()
        {
            //var contents = new List<Content>();
            //for (int i = 0; i < 11; i++)
            //{
            //    contents.Add(new Content { Id = i, TextTitle = $"Title {i}", TextContent = $"Content {i}",
            //        TextStatus = 1, CreateTime = DateTime.Now.AddDays(-i) });
            //}
            return View(new Contents { ContentList = new List<Content> { contents } });
        }
    }
}
