using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    public abstract class AbsMaquina
    {
        protected string name;
        protected int memoria;
        public abstract void Encendido();
        public abstract void Apagado();
    }
}
