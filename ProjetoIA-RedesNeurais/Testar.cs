using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIA_RedesNeurais
{
    internal class Testar
    {

        public static int [,] montarTeste(int numEntrada, int numSaida, int numOcultas, FileDialog openFileArqTreino, string[] classesSaidas, string funcTransf, double[] pesoOculta, double[] pesoSaida,Double max , Double min)
        {

            Double[] entrada = new Double[numEntrada];
            
            int[,] mat = new int[numSaida, numSaida]; // Substitua o tamanho da matriz conforme necessário
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = 0;
                }
            }
            int possaidaResult = 0;
            string saidaEsperada;
            StreamReader sr = File.OpenText(openFileArqTreino.FileName);
            sr.ReadLine();
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] colunas = line.Split(',');
                for (int i = 0; i < entrada.Length; i++)
                {
                    entrada[i] = (Double.Parse(colunas[i]) - min) / (max - min);
                }
                saidaEsperada = colunas[colunas.Length - 1];
                //CHAMAR FUNÇÂO DE TREINAMENTO
                possaidaResult = testar(entrada, saidaEsperada, numOcultas, numSaida, classesSaidas, funcTransf, pesoOculta, pesoSaida);
                int pos = 0;
                for (int j = 0; j < classesSaidas.Length; j++)
                {
                    if (saidaEsperada.Equals(classesSaidas[j]))
                        pos = j;
                }
                mat[pos,possaidaResult]++;
        
                line = sr.ReadLine();
               
            }
            return mat;
        }

        public static int testar(Double[] entradas, string saidaEsperada, int numOcultas, int numSaida, string[] classesSaidas, string funcTransf,  double[] pesoOculta, double[] pesoSaida)
        {
            Double[] camOculta = new Double[numOcultas];
            Double[] camSaida = new Double[numSaida];
            //Montando saida de da camada oculta
            double net;
            int i = 0;
            int aux = 0;
            while (i < pesoOculta.Length)
            {
                net = 0;
                for (int j = 0; j < entradas.Length; j++)
                {
                    net = net + (entradas[j] * pesoOculta[i]);
                    i++;
                }
                if (net == 0)
                    camOculta[aux++] = net;
                else
                {
                    //Pegar Funcão de transferencia
                    if (funcTransf.Equals("linear"))
                    {
                        camOculta[aux++] = net *0.1;

                    }
                    else if (funcTransf.Equals("hiperbolica"))
                    {
                        camOculta[aux++] = 1 - Math.Pow(Math.E, -2 * net) / 1 + Math.Pow(Math.E, -2 * net);

                    }
                    else
                    {
                        camOculta[aux++] = 1 / (1 + Math.Pow(Math.E, -net));

                    }

                }

            }
            //Montando saida de da camada saida
            i = 0;
            aux = 0;
            while (i < pesoSaida.Length)
            {
                net = 0;
                for (int j = 0; j < camOculta.Length; j++)
                {
                    net = net + (camOculta[j] * pesoSaida[i]);
                    i++;
                }
                if (net == 0)
                    camSaida[aux++] = net;
                else
                {
                    //Pegar Funcão de transferencia
                    if (funcTransf.Equals("linear"))
                    {
                        camSaida[aux++] = net *0.1;

                    }
                    else if (funcTransf.Equals("hiperbolica"))
                    {
                        camSaida[aux++] = 1 - Math.Pow(Math.E, -2 * net) / 1 + Math.Pow(Math.E, -2 * net);

                    }
                    else
                    {
                        camSaida[aux++] = 1 / (1 + Math.Pow(Math.E, -net));

                    }

                }

            }
            Double comp = camSaida[0];
            int retorno = 0;
            for (int j = 1; j < camSaida.Length; j++)
            {
                if (comp < camSaida[j])
                {
                    comp = camSaida[j];
                    retorno = j;
                }
            }

            return retorno;
            /* // verificando saida
             int pos = 0;
             for (int j = 0; j < classesSaidas.Length; j++)
             {
                 if (saidaEsperada.Equals(classesSaidas[j]))
                     pos = j;
             }*/
        }
    }
}
