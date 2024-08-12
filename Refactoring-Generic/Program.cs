using System;
using School.Data.Entities;
using School.Data.Repository;

namespace BusManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var asientoRepo = new AsientoRepository();

            var nuevoAsiento = new Asiento
            {
                AsientoId = 1,
                BusId = 123,
                NumeroPiso = 1,
                NumeroAsiento = 45,
                FechaCreacion = DateTime.Now
            };
            asientoRepo.Agregar(nuevoAsiento);

            var asiento = asientoRepo.ObtenerPorId(1);
            if (asiento != null)
            {
                asiento.NumeroAsiento = 46;
                asientoRepo.Actualizar(asiento);
            }

            var todosAsientos = asientoRepo.TraerTodos();
            foreach (var a in todosAsientos)
            {
                Console.WriteLine($"Asiento ID: {a.AsientoId}, Número: {a.NumeroAsiento}");
            }
        }
    }
}
