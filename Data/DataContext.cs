using payroll_api.Models;
using Microsoft.EntityFrameworkCore;

namespace payroll_api.Data
{
    public class DataContext : DbContext
    {
        // Entity Framework - Code First
        // Construtor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //Lista de propriedades que vão virar tabelas no banco
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<FolhaDePagamento> FolhaDePagamento { get; set; }
    }
}