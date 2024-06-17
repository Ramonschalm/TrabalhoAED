using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TrabalhoAED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (Dictionary<int, Curso> cursos, List<Candidato> candidatos) = LeituraEntrada.ProcessTxt("../../Base.txt");

            Candidato[] candidatosArray = candidatos.ToArray();
            Mergesort.MergeSort(candidatosArray, 0, candidatosArray.Length - 1);

            Dictionary<int, Curso> selecao = SelecionarCandidatos(candidatosArray, cursos);

            SalvarTxt(selecao, "../../saida.txt");
        }

        public static Dictionary<int, Curso> SelecionarCandidatos(Candidato[] candidatos, Dictionary<int, Curso> cursos)
        {
            foreach (var candidato in candidatos)
            {
                Curso curso1 = cursos[candidato.PrimeiroCurso];
                Curso curso2 = cursos[candidato.SegundoCurso];

                bool selecionadoPrimeiraOpcao = AdicionarCandidatoAoCurso(candidato, curso1);
                bool selecionadoSegundaOpcao = false;

                if (!selecionadoPrimeiraOpcao)
                {
                    selecionadoSegundaOpcao = AdicionarCandidatoAoCurso(candidato, curso2);
                }

                if (!selecionadoPrimeiraOpcao && !selecionadoSegundaOpcao)
                {
                    AdicionarCandidatoNaFilaEspera(candidato, curso1);
                    AdicionarCandidatoNaFilaEspera(candidato, curso2);
                }
                else if (selecionadoSegundaOpcao)
                {
                    AdicionarCandidatoNaFilaEspera(candidato, curso1);
                }
            }

            return cursos;
        }

        private static bool AdicionarCandidatoAoCurso(Candidato candidato, Curso curso)
        {
            if (curso.VagasPreenchidas < curso.Vagas)
            {
                curso.Aprovados[curso.VagasPreenchidas++] = candidato;
                curso.NotaCorte = candidato.Media;
                return true;
            }
            return false;
        }

        private static void AdicionarCandidatoNaFilaEspera(Candidato candidato, Curso curso)
        {
                curso.ListaEspera.Inserir(candidato);
        }

        public static void SalvarTxt(Dictionary<int, Curso> dados, string caminhoArquivo)
        {
            using (StreamWriter writer = new StreamWriter(caminhoArquivo))
            {
                foreach (var cursoEntry in dados)
                {
                    Curso curso = cursoEntry.Value;

                    writer.WriteLine($"{curso.Nome} {curso.NotaCorte}");
                    writer.WriteLine("Selecionados");

                    foreach (var candidato in curso.Aprovados)
                    {
                        if (candidato != null)
                        {
                            writer.WriteLine($"{candidato.Nome} {candidato.Media:F2} {candidato.NotaRedacao} {candidato.NotaMatematica} {candidato.NotaLinguagens}");
                        }
                    }

                    writer.WriteLine("Fila de Espera");

                    foreach (var candidato in curso.ListaEspera.candidatos)
                    {
                        if (candidato != null)
                        {
                            writer.WriteLine($"{candidato.Nome} {candidato.Media:F2} {candidato.NotaRedacao} {candidato.NotaMatematica} {candidato.NotaLinguagens}");
                        }
                    }

                    writer.WriteLine();
                }
            }
        }
    }
}
