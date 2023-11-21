using api.Context;
using api.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace api.test
{
    public class CategoriasControllerTest
    {
        private readonly IAppDBContext _context;

        public CategoriasControllerTest()
        {

            string connectionString = "Server=127.0.0.1,14333;Database=API;user id=sa;password=M1sterPassw0rd!;Encrypt=true;TrustServerCertificate=true";

            var contextOptions = new DbContextOptionsBuilder<AppDBContext>().UseSqlServer(connectionString).Options;

            _context = new AppDBContext(contextOptions);
        }

        [Fact]
        public async Task GetAllCategorias_Ok()
        {
            var res = await _context.Categorias.Where(w => w.Habilitado == true).ToListAsync();
            Assert.True(res != null);
            //cambio para la rama dev
        }
    }
}