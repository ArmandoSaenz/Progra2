using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Msg = $"Nombre del equipo: {Environment.MachineName} {Environment.NewLine}";
            Msg += $"Usuario: {Environment.UserName} {Environment.NewLine}";
            Msg += $"Carpeta de ejecución: {Environment.CurrentDirectory} {Environment.NewLine}";
        }
    }
}
