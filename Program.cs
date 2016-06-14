using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maldivas.Entities.Main;
using Microsoft.EntityFrameworkCore;

namespace Ef7Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(@"Data Source=.\SqlExpress;Initial Catalog=Geimex;Integrated Security=True;MultipleActiveResultSets=True");

            using (MaldivasMainContext mmc = new MaldivasMainContext(optionsBuilder.Options))
            {
                var query = mmc.Clientes_zonas.Select(s => new { s.Codigo, s.Nombre }).OrderBy(o => o.Nombre);
                foreach (var data in query)
                {
                    Console.Write(string.Format(CultureInfo.CurrentCulture, "Codigo: {0} Nombre: {1}{2}", data.Codigo, data.Nombre, Environment.NewLine));
                }
                Console.Write(sw.ElapsedMilliseconds);
            }

            Console.ReadLine();

        }
    }
}
