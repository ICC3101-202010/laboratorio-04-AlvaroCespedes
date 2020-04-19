using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    class MaquinaCentral : IAviso
    {
        public void Aviso()
        {
            Console.WriteLine("Una Maquina se ha quedado sin memoria");
        }
    }
}
