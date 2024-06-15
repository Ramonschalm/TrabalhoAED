using System;
using System.Linq;

namespace TrabalhoAED
{
    public class Fila
    {
        public Candidato[] candidatos;
        public int primeiro, ultimo;

        public Fila(int tamanho)
        {
            candidatos = new Candidato[tamanho + 1];
            primeiro = ultimo = 0;
        }

        public void Inserir(Candidato x)
        {
            if (((ultimo + 1) % candidatos.Length) == primeiro)
                return;

            candidatos[ultimo] = x;
            ultimo = (ultimo + 1) % candidatos.Length;
        }

        /*public void Remover(Candidato x)
        {
            if (primeiro == ultimo)
                throw new Exception("Erro!");

            int resp = candidatos[primeiro];
            primeiro = (primeiro + 1) % candidatos.Length;
            return;
        }*/
    }
}