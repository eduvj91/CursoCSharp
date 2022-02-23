using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    class Mamiferos : Animales
    {
        public override void GetNombre()
        {
            throw new NotImplementedException();
        }


        // Constructor
        public Mamiferos(string nombre)
        {
            this.nombre = nombre;
        }


        // Campos de clase encapsuladas
        string nombre;
    }
}
