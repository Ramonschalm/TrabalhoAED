using System;

namespace TrabalhoAED
{
    internal class Mergesort
    {
        public static void MergeSort(Candidato[] array, int esq, int dir)
        {
            if (esq < dir)
            {
                int meio = (esq + dir) / 2;
                MergeSort(array, esq, meio);
                MergeSort(array, meio + 1, dir);
                Intercalar(array, esq, meio, dir);
            }
        }

        private static void Intercalar(Candidato[] array, int esq, int meio, int dir)
        {
            int nEsq = meio - esq + 1;
            int nDir = dir - meio;
            Candidato[] arrayEsq = new Candidato[nEsq];
            Candidato[] arrayDir = new Candidato[nDir];

            for (int i = 0; i < nEsq; i++)
                arrayEsq[i] = array[esq + i];
            for (int j = 0; j < nDir; j++)
                arrayDir[j] = array[meio + 1 + j];

            int iEsq = 0, iDir = 0, k = esq;
            while (iEsq < nEsq && iDir < nDir)
            {
                if (CompararCandidatos(arrayEsq[iEsq], arrayDir[iDir]) <= 0)
                    array[k++] = arrayEsq[iEsq++];
                else
                    array[k++] = arrayDir[iDir++];
            }

            while (iEsq < nEsq)
                array[k++] = arrayEsq[iEsq++];

            while (iDir < nDir)
                array[k++] = arrayDir[iDir++];
        }

        private static int CompararCandidatos(Candidato c1, Candidato c2)
        {
            if (c1.Media != c2.Media)
                return c2.Media.CompareTo(c1.Media);
            if (c1.NotaRedacao != c2.NotaRedacao)
                return c2.NotaRedacao.CompareTo(c1.NotaRedacao);
            if (c1.NotaMatematica != c2.NotaMatematica)
                return c2.NotaMatematica.CompareTo(c1.NotaMatematica);
            return c2.NotaLinguagens.CompareTo(c1.NotaLinguagens);
        }
    }
}
