using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIA_RedesNeurais
{
    public partial class Form1 : Form
    {
        String[] classesSaida;
        public Double[] pesoOculta;
        public Double[] pesoSaida;
        public Double max, min;
        public Form1()
        {
            InitializeComponent();
            // Console.WriteLine("AAA");

        }

        private void btnTreinar_Click(object sender, EventArgs e)
        {
            pesoOculta = new Double[(int)numEntradas.Value * (int)numOculta.Value];
            pesoSaida = new Double[(int)numOculta.Value * (int)numSaida.Value];
            string funcaoTransf;
            if (rbLinear.Checked)
            {
                funcaoTransf = "linear";
            }
            else if (rbHiperbolica.Checked)
            {
                funcaoTransf = "hiperbolica";
            }
            else
            {
                funcaoTransf = "logistica";
            }
            Treinar.montarTreino((int)numEntradas.Value, (int)numSaida.Value, (int)numOculta.Value, openFileArqTreino, classesSaida, funcaoTransf, (double)numValorErro.Value, (double)txApren.Value, (int)numInteracoes.Value, pesoOculta, pesoSaida, this.max, this.min);
            // Console.WriteLine("AAA");
            Session.Instance.pesoOculta = pesoOculta;
            Session.Instance.pesoSaida = pesoSaida;
            Session.Instance.numOculta = (int)numOculta.Value;
            Session.Instance.funcTransf = funcaoTransf;
            labelConcluido.Text = "Treinamento Realizado com Sucesso !!!";

        }

        private void btnEscArq_Click(object sender, EventArgs e)
        {
            openFileArqTreino.Filter = "CSV | *.csv";
            openFileArqTreino.ShowDialog();
            String[] palavra = openFileArqTreino.FileName.Split('\\');
            nomeArq.Text = palavra[palavra.Length - 1];
            int qtdClasses = 0, qtdSaidas = 0;
            this.max = Double.MinValue;
            this.min = Double.MaxValue;
            using (StreamReader sr = File.OpenText(openFileArqTreino.FileName))
            {

                string s, ant = "", at;
                s = s = sr.ReadLine();
                for (int i = 0; i < s.Length; i++)
                {
                    // quantidade de classes = quantidade de virgulas
                    if (s[i] == ',')
                        qtdClasses++;
                }
                Console.WriteLine(s);
                classesSaida = new string[5];
                string[] colunas;
                int j = 0;
                while ((s = sr.ReadLine()) != null)
                {

                    int qtdVirgulas = 0;
                    int i;
                    colunas = s.Split(',');
                    for (i = 0; qtdVirgulas < qtdClasses; i++)
                    {
                        if (s[i] == ',')
                            qtdVirgulas++;
                        if (i < colunas.Length - 1 && this.max < Convert.ToDouble(colunas[i]))
                        {
                            max = Double.Parse(colunas[i]);
                        }
                        if (i < colunas.Length - 1 && this.min > Convert.ToDouble(colunas[i]))
                        {
                            min = Double.Parse(colunas[i]);
                        }
                    }
                    at = "";
                    while (i < s.Length)
                        at += s[i++];
                    if (!at.Equals(ant))
                    {
                        classesSaida[qtdSaidas] = at;
                        qtdSaidas++;
                    }

                    ant = at;
                    Console.WriteLine(s);
                }




            }
            numEntradas.Value = qtdClasses;
            numSaida.Value = qtdSaidas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
