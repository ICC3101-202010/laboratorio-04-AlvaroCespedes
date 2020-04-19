using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    class Verificacion : AbsMaquina
    {
        public Verificacion(string name, int memoria)
        {
            this.name = name;
        }
        public override void Encendido()
        {
            Console.WriteLine("Maquina Verificacio Encendida");
        }

        public override void Apagado()
        {
            Console.WriteLine("Maquina Verificacion Apagada");
        }
        public override void Reiniciar()
        {
            Console.WriteLine("Maquina Recepcion Reiniciada");
        }
        public Verificacion()
        {
            Console.WriteLine("Pieza Verificada");
        }
        public override void AgregarMemoria()
        {
            Console.WriteLine("Se ha agregado a la memoria");
        }
    }
}
