using System;
namespace SimulacionDados
{
    public class Dado
    {
        private int contador = 0;
        private int num;
        public Dado(int num)
        {
            this.num = num;
        }

        public void sumar(){
            contador++;
        }

        public int mostrarNum(){
            return this.num;
        }

        public int mostrarCont(){
            return this.contador;
        }
    }
}
