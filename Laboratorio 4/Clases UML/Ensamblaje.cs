using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    class Ensamblaje : AbsMaquina
    {
        public Ensamblaje(string name)
        {
            this.name = name;
        }
        public override void Encendido()
        {
            Console.WriteLine("Maquina Ensamblaje Encendida");
        }
        public override void Apagado()
        {
            Console.WriteLine("Maquina Ensamblaje Apagada");
        }
        public override void Reiniciar()
        {
            Console.WriteLine("Maquina Ensamblaje Reiniciada");
        }
        public Ensamblaje()
        {
            Console.WriteLine("Pieza Ensamblada");
        }
        public override void AgregarMemoria()
        {
            Console.WriteLine("Se ha agregado a la memoria");
        }
    }
}
