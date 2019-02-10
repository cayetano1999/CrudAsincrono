using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudAsincrono.Repositorio;
using CrudAsincrono.Models;

namespace CrudAsincrono.Interfaz
{
    //Esta interfaz hereda los metodos del repositorio al igual que cualquier otra clase que herede de esta; 

   public interface IProfesor: IReporitorioCrud<Profesor>
    {
         Task<bool> AddAsync(Profesor profesor);

    }
}
