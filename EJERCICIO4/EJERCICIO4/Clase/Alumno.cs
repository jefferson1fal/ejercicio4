using EJERCICIO4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO4.Clase
{
    internal class IAlumno : IPersona
    {
        public string Name => throw new NotImplementedException();

        public int Edad => throw new NotImplementedException();

        public void CumplirAnios()
        {

            Console.WriteLine($"Hola mi nombre es {Name}");
        }

        public void Saludar()
        {
            int AniosA = Edad + 1;
            Console.WriteLine($"{Name} a Cumplido anios!!!\n{Name} ahora tiene {AniosA}");
        }
    }
}
