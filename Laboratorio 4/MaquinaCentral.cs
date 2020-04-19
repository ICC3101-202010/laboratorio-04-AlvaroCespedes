using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    class MaquinaCentral : IAviso
    {
        public void Aviso() // Creo que reiniciar es una interfaz
        {
            Console.WriteLine("Una Maquina se ha quedado sin memoria");
        }
        public void ApagarOrden()
        {
              
        }
    }
}
