using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace ProjetoIA_RedesNeurais
{
    internal class Treinar
    {/*
        private int _capacity = 10;

        public Treinar(){  }*/
        public static void montarTreino(int numEntrada, int numSaida,int numOcultas, FileDialog openFileArqTreino, string[] classesSaidas,string funcTransf,double valorErroRede, double txAprend ,int numInter,double[] pesoOculta, double[] pesoSaida,double max, double min)
        {
            //_capacity = 1;
            for (int i = 0; i < pesoOculta.Length; i++)
            {
                pesoOculta[i] = GerarNumeroAleatorio();
            }

            for (int i = 0; i < pesoSaida.Length; i++)
            {
                pesoSaida[i] = GerarNumeroAleatorio();
            }

            Double[] entrada = new Double[numEntrada];
            int interacoes = 0;
            Double erroRede = 1000;
            string saidaEsperada;
            StreamReader sr = File.OpenText(openFileArqTreino.FileName);
            sr.ReadLine();
            string line = sr.ReadLine();
            while (erroRede> valorErroRede &&interacoes<numInter)
            {
                string[] colunas = line.Split(',');
                for (int i = 0; i < entrada.Length; i++)
                {
                    entrada[i] = (Double.Parse(colunas[i])-min)/(max-min);
                    
                }
                saidaEsperada = colunas[colunas.Length - 1];
                //CHAMAR FUNÇÂO DE TREINAMENTO
                erroRede =treinamento(entrada,saidaEsperada,numOcultas, numSaida,classesSaidas, funcTransf, valorErroRede,txAprend,pesoOculta, pesoSaida);
                line = sr.ReadLine();
                if (line == null)
                {
                    sr = File.OpenText(openFileArqTreino.FileName);
                    sr.ReadLine();
                    line = sr.ReadLine();
                }
                interacoes++;
            }
        }
       private static double GerarNumeroAleatorio()
        {
            // Criar uma instância da classe Random
            Random random = new Random();
            // Gerar um número aleatório entre 0 (inclusive) e 1 (exclusivo)
             return Math.Round((random.NextDouble() * 2 - 1),8);

        }

        private static Double treinamento(Double[] entradas,string saidaEsperada,int numOcultas, int numSaida, string[] classesSaidas, string funcTransf, double valorErroRede, double txAprend, double[] pesoOculta, double[] pesoSaida)
        {
            Double[] camOculta = new Double[numOcultas];
            Double[] camSaida = new Double[numSaida];
            Double[] geOculta = new Double[numOcultas];
            Double[] geSaida = new Double[numSaida];
            Double erroRede;
            int i = 0, aux = 0,interacoes=0;
            double fnet, faposnet;

          

         
            //Montando saida de da camada oculta
            double net;
            i = 0;
            aux = 0;
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
                        camOculta[aux++] = net / 10;

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
                        camSaida[aux++] = net / 10;

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
            // verificando saida
            int pos = 0;
            for (int j = 0; j < classesSaidas.Length; j++)
            {
                if (saidaEsperada.Equals(classesSaidas[j]))
                    pos = j;
            }

            //Calcular o gradiente de erro Saida
            double erro = 0;
            erroRede = 0;
            if (camSaida[pos] != 1)
            {
                for (int j = 0; j < geSaida.Length; j++)
                {
                    if (j == pos)
                        erro = 1 - camSaida[j];
                    else
                        erro = 0 - camSaida[j];
                    //Erro Rede
                    erroRede = erroRede + Math.Pow(erro, 2);
                    
                    //Pegar Funcão de transferencia f'net
                    if (funcTransf.Equals("linear"))
                    {
                        geSaida[j] = 0.1 * erro;

                    }
                    else if (funcTransf.Equals("hiperbolica"))
                    {
                        geSaida[j] = (1 - Math.Pow(camSaida[j], 2)) * erro;

                    }
                    else
                    {
                        geSaida[j] = (camSaida[j] * (1 - camSaida[j])) * erro;

                    }
                }
                erroRede = erroRede * 0.5;
                if (erroRede.ToString().Equals("NaN"))
                {
                    erroRede = erroRede;
                }
                //Calcular o gradiente de erro Oculta

                for (int j = 0; j < geOculta.Length; j++)
                {
                    erro = 0;
                    aux = 0;
                    for (int k = j; k < pesoSaida.Length; k += numOcultas)
                    {
                        erro = erro + (pesoSaida[k] * geSaida[aux]);
                        aux++;
                    }

                    //Pegar Funcão de transferencia f'net
                    if (funcTransf.Equals("linear"))
                    {
                        geOculta[j] =0.1 * erro;

                    }
                    else if (funcTransf.Equals("hiperbolica"))
                    {
                        geOculta[j] = (1 - Math.Pow(camOculta[j], 2)) * erro;

                    }
                    else
                    {
                        geOculta[j] = (camOculta[j] * (1 - camOculta[j])) * erro;

                    }
                }


            }
            else
            {
                //ERRO REDE = 0
                erroRede = 0;
            }

            //calcular novos pesos
            if (erroRede > valorErroRede)
            {
                i = 0;
                aux = 0;
                //Calcula peso da camada oculta
                while (i < pesoOculta.Length)
                {
                    for (int j = 0; j < entradas.Length; j++)
                    {
                        pesoOculta[i] = pesoOculta[i] + (txAprend * geOculta[aux] * entradas[j]);
                        i++;
                    }
                    aux++;
                }

                i = 0;
                aux = 0;
                //Calcula peso da camada saida
                while (i < pesoSaida.Length)
                {
                    for (int j = 0; j < camOculta.Length; j++)
                    {
                        pesoSaida[i] = pesoSaida[i] + (txAprend * geSaida[aux] * camOculta[j]);
                        i++;
                    }
                    aux++;
                }
            }

            return erroRede;
        }
    }
}
