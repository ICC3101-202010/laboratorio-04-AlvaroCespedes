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
        }
        public override void Encendido()
        {
            Console.WriteLine("Maquina Recepcion Encendida");
        }

        public override void Apagado()
        {
            Console.WriteLine("Maquina Recepcion Apagada");
        }
        public override void Reiniciar()
        {
            Console.WriteLine("Maquina Recepcion Reiniciada");
        }
        public Recepcion()
        {
            Console.WriteLine("Pieza recepcionada");
        }
        public override void AgregarMemoria()
        {
            Console.WriteLine("Se ha agregado a la memoria");
        }
    }
}
