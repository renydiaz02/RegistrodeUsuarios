using Microsoft.EntityFrameworkCore;
using RegistrodeUsuarios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrodeUsuarios.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging().UseSqlite(@"Data Source = DATA\RegistroDeUsuairios.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                Usuarioid = 1,
                Nombres = "Reny",
                Apellidos = "Diaz",
                NombreDeUsuario = "profesor",
                Contrasena = "cffa965d9faa1d453f2d336294b029a7f84f485f75ce2a2c723065453b12b03b"
                //Contrasena: profesor123
            });
        }
    }
}