using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasModel
{
    public class Programas
    {
        public int tempo { get; set; }
        public int potencia { get; set; }
        /**
         * 
         * Método de validação de tempo
         * verifica se está dentro do máximo e minimo permitido.
         * 
         **/
        public string validaTempo()
        {
            //valida o tempo informado
            if (this.tempo < 1 || this.tempo > 120)
            {
                return "Informar o tempo de aquecimento de 1 segundo até 2 minutos.";
            }
            return " ";
        }

        /**
         * 
         * Método de validação de potência
         * verifica se está dentro do máximo e minimo permitido.
         * 
         **/
        public string validaPotencia()
        {
            //valida o tempo informado
            if (this.potencia > 10)
            {
                return "Informar a potência de aquecimento de 1 até 10.";
            }
            else this.potencia = 10;
            return " ";
        }

        /**
         * 
         * Método de início rápido
         * onde é predefinido 30segundos e potencia 8.
         * 
         **/
        public void InicioRapido()
        {
            this.potencia = 8;
            this.tempo = 30;
            return;
        }

    }
}
