using System.Collections.Generic;
using System.Linq;
using School.Data.Interfaces;

namespace School.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly List<T> _context = new List<T>();

        public void Agregar(T entidad)
        {
            _context.Add(entidad);
        }

        public void Actualizar(T entidad)
        {
        }

        public void Remover(T entidad)
        {
            _context.Remove(entidad);
        }

        public T ObtenerPorId(int id)
        {
            return null;
        }

        public List<T> TraerTodos()
        {
            return _context.ToList();
        }
    }
}

