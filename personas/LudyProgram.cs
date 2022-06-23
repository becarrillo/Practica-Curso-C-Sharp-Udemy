using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class LudyProgram
    {
        static void Main(string[] args)
        {
            var repositorio = ObtenerRepositorio(TipoRepositorio.Memoria);
            ProcesarRepositorio(repositorio);       // Se usa valor "memoria" guardada en variable repositorio
            
            ProcesarRepositorio(new RepositorioPersonaBD());
            ProcesarRepositorio(new RepositorioPersonasEnMemoria());
        }

        public static void ProcesarRepositorio(IRepositorioPersonas repositorio)
        {
            repositorio.ObtenerPersonas();
        }

        enum TipoRepositorio { Memoria = 1, BD = 2 }

        static IRepositorioPersonas ObtenerRepositorio(TipoRepositorio tipoRepositorio)
        {
            switch (tipoRepositorio)
            {
                case TipoRepositorio.Memoria:
                    return new RepositorioPersonasEnMemoria();
                case TipoRepositorio.BD:
                    return new RepositorioPersonaBD();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}