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
    [Route("api/funcionario")]
    public class FuncionarioController : Controller
    {
        private readonly DataContext _context;

        public FuncionarioController(DataContext context) => _context = context;
        
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Funcionario funcionario)
        {
            _context.Funcionario.Add(funcionario);
            _context.SaveChanges();
            return Ok(funcionario);
        }

        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Funcionario.ToList());
    }
}