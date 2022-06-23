using System;

namespace App4_curso_Udemy_Csharp                   // abstracts VS interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerConsola = new LoggerConsola();
            testLogger(loggerConsola);
        }

        static void testLogger(LoggerBase logger)
        {
            logger.Log("Probando el logger");
            try
            {
                throw new NotImplementedException("prueba de excepción");
            } catch (NotImplementedException ex)
            {
                logger.LogException(ex);
            }
        }
    }

    public abstract class LoggerBase
    {
        public abstract void Log(string mensaje);
        public virtual void LogException(Exception ex) => Log(ex.Message);
    }

    public class LoggerConsola : LoggerBase
    {
        public override void Log(string mensaje) => Console.WriteLine(mensaje);
        public override void LogException(Exception ex)
        {
            Log($"{ex.Message}: {ex.StackTrace}");
        }
    }
}
