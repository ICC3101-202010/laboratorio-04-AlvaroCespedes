using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    class Recepcion : AbsMaquina
    {
        public Recepcion(string name, int memoria)
        {
            this.name = name;
            this.memoria = memoria;
        }
        public override void Encendido()
        {
            throw new NotImplementedException();
        }

        public override void Apagado()
        {
            throw new NotImplementedException();
        }
    }
}
