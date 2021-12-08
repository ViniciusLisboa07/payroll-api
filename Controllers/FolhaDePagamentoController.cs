using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using payroll_api.Data;
using payroll_api.Models;
using Microsoft.Extensions.Logging;

namespace payroll_api.Controllers
{
    [ApiController]
    [Route("api/folhaDePagamento")]
    public class FolhaDePagamentoController : Controller
    {
        private readonly DataContext _context;

        public FolhaDePagamentoController(DataContext context) => _context = context;
        
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] FolhaDePagamento folhaDePagamento)
        {
            _context.FolhaDePagamento.Add(folhaDePagamento);
            _context.SaveChanges();
            return Ok(folhaDePagamento);
        }

        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.FolhaDePagamento.ToList());
    }
}