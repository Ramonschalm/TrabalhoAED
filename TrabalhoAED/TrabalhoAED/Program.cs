using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (Dictionary<int, Curso> cursos, List<Candidato> candidatos) = LeituraEntrada.ProcessTxt("../../Base.txt");
        }
    }
}
