using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    public abstract class AbsMaquina
    {
        protected string name;
        protected List<string> memoria; // De esta manera las maquinas se les ira acabando la memoria.
        // En la clase program se vera.

        public abstract void AgregarMemoria();
        public abstract void Encendido();
        public abstract void Apagado();
        public abstract void Reiniciar();
    }
}
