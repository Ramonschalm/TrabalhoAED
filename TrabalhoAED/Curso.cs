﻿using System.Collections.Generic;

namespace TrabalhoAED
{
    public class Curso
    {
        public string Nome { get; set; }

        public int Vagas { get; set; }

        public double NotaCorte { get; set; }

        public Candidato[] Aprovados { get; set; }

        public Fila ListaEspera { get; set; }

        public int VagasPreenchidas { get; set; }

        public Curso(string nome, int vagas)
        {
            Nome = nome;
            Vagas = vagas;
            Aprovados = new Candidato[vagas];
            ListaEspera = new Fila(10);
            NotaCorte = 0;
            VagasPreenchidas = 0;

        }
    }
}