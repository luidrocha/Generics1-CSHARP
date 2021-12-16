using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1_Csharp.Service
{
    class PrintService
    {
        private int[] _valor = new int[10];
        private int _contador = 0;


        public void AddValor(int valor)
        {
            if (_contador == 10)
            {
                throw new InvalidOperationException("Serviço de impressão esta cheio, somente 10 Elementos");
            }

            _valor[_contador] = valor;
            _contador++;

        }

        public int Primeiro()
        {
            if (_contador == 0)

            {
                new InvalidOperationException("Serviço de impressão está Vazio!!");

            }
            return _valor[0];
        }

        public void Print()
        {
            Console.WriteLine("Valores armazenados no Vetor");

            Console.Write("[");
            
            for (int i = 0; i < _contador; i++)
            {

                Console.Write(_valor[i] + ", ");
            }
            Console.Write("]");



        }
    }
}
