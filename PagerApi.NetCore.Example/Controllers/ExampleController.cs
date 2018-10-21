using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PagerApi.NetCore.Example.DB;
using PagerApi.NetCore;
using AutoMapper;

namespace PagerApi.NetCore.Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        readonly TestContext _context;

        public ExampleController(TestContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            var list = await _context.Test.ToListPagedAsync();
            return Ok(list);
        }

        [HttpGet]
        [Route("GetMepped")]
        public async Task<IActionResult> GetMepped()
        {
            var list = await _context.Test.Where(x => x.Id > 0).OrderBy(x => x.Id).ToListPagedAsync();
            return Ok(list.Cast(x => x.Select(p => Mapper.Map<TestDTO>(p))));
        }
    }
}
