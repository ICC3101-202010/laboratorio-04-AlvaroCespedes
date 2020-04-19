using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    class Empaque :  AbsMaquina
    {
        public Empaque(string name, int memoria)
        {
            this.name = name;
        }
        public override void Encendido()
        {
            Console.WriteLine("Maquina Empaque Encendida");
        }

        public override void Apagado()
        {
            Console.WriteLine("Maquina Empaque Apagada");
        }
        public override void Reiniciar()
        {
            Console.WriteLine("Maquina Empaque Reiniciada");
        }
        public Empaque()
        {
            Console.WriteLine("Se ha empadado la pieza");
        }
        public override void AgregarMemoria()
        {
            Console.WriteLine("Se ha agregado a la memoria");
        }
    }
}
