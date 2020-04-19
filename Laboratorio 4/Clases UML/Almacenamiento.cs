using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    class Almacenamiento : AbsMaquina
    {
        public Almacenamiento(string name)
        {
            this.name = name;
        }
        public override void Encendido()
        {
            Console.WriteLine("Maquina Almacenamiento Encendida");
        }

        public override void Apagado()
        {
            Console.WriteLine("Maquina Almacenaiento Apagada");
        }
        public override void Reiniciar()
        {
            Console.WriteLine("Maquina Almacenamiento Reiniciada");
        }
        public Almacenamiento()
        {
            Console.WriteLine("Pieza Almacenada");
        }
        public override void AgregarMemoria()
        {
            Console.WriteLine("Se ha agregado a la memoria");
        }

    }
}
