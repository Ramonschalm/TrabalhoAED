using System;
using System.IO;
using System.Collections.Generic;

namespace TrabalhoAED
{
    internal class LeituraEntrada
    {
        public static (Dictionary<int, Curso>, List<Candidato>) ProcessTxt(string localFile)
        {
            string entrada = $@"{localFile}";
            string[] content = File.ReadAllText(entrada).Replace("\r", "").Split('\n');

            if (content.Length < 1)
                throw new Exception("O arquivo de entrada está vazio ou não possui linhas suficientes.");

            string[] primeiraLinha = content[0].Split(';');
            if (primeiraLinha.Length != 2)
                throw new Exception("Formato da primeira linha inválido.");

            int totalCursos = Convert.ToInt32(primeiraLinha[0]);
            int totalCandidatos = Convert.ToInt32(primeiraLinha[1]);

            Dictionary<int, Curso> cursos = new Dictionary<int, Curso>(totalCursos);
            List<Candidato> candidatos = new List<Candidato>(totalCandidatos);

            for (int i = 1; i < content.Length; i++)
            {
                string[] linha = content[i].Split(';');

                if (linha.Length == 3)
                {
                    int codigo = Convert.ToInt32(linha[0]);
                    string nomeCurso = linha[1];
                    int vagas = Convert.ToInt32(linha[2]);
                    if (!cursos.ContainsKey(codigo))
                    {
                        cursos.Add(codigo, new Curso(nomeCurso, vagas));
                    }
                }
                else if (linha.Length > 3)
                {
                    Candidato candidato = new Candidato(
                        linha[0],
                        Convert.ToDouble(linha[1]),
                        Convert.ToDouble(linha[2]),
                        Convert.ToDouble(linha[3]),
                        Convert.ToInt32(linha[4]),
                        Convert.ToInt32(linha[5])
                    );
                    candidatos.Add(candidato);
                }
            }
            return (cursos, candidatos);
        }
    }
}
