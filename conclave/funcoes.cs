using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conclave
{
    internal class funcoes
    {
        public static int Length(string[][] vetor)
        {
            int q = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != null)
                {
                    q++;
                }
            }
            return q;
        }
        public static int buscar(string[][]vetor, string nome)
        {
            int indice;
            for (indice = 0; indice < Length(vetor) && vetor[indice][0] != nome; indice++) ;
            if (indice < Length(vetor))
                return indice;
            return -1;
        }
    }
}
