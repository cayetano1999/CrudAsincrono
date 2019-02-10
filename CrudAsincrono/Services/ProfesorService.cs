using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudAsincrono.Interfaz;
using CrudAsincrono.Models;


namespace CrudAsincrono.Services
{
    //Esta clase debe implementar todos los metodos de la Interfaz IProfesor
    public class ProfesorService : IProfesor
    {

        private ApplicationDbContext _db;

        public ProfesorService(ApplicationDbContext db)
        {
            _db = db;
        }



        public bool Add(Profesor entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AddAsync(Profesor profesor)
        {
            if (profesor!=null)
            {
                _db.Add(profesor);
               await _db.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(Profesor entity)
        {
            if (entity != null)
            {
                var profe = _db.Profesores.SingleOrDefault(p => p.Id == entity.Id);
                if (profe != null)
                {
                    _db.Profesores.Remove(profe);
                    _db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public Profesor Get(int? Id)
        {
            if (Id != null)
            {

                var profe = _db.Profesores.SingleOrDefault(p => p.Id == Id);
                if (profe != null)
                {


                    return profe;
                }
                else
                {
                    return null;
                }

            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Profesor> GetAll()
        {
            var profesores = new List<Profesor>();

            profesores = _db.Profesores.ToList();

            return profesores;
        }

        public bool Update(Profesor entity)
        {
            if (entity != null)
            {

                var profeeditar = _db.Profesores.SingleOrDefault(p => p.Id == entity.Id);
                if (profeeditar != null)
                {
                    profeeditar.Nombre = entity.Nombre;
                    profeeditar.Direccion = entity.Direccion;
                    profeeditar.Cedula = entity.Cedula;
                    profeeditar.Telefono = entity.Telefono;
                    _db.SaveChanges();
                    return true;
                }

                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
