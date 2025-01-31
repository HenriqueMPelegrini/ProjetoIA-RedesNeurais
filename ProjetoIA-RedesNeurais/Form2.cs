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
    public partial class Form2 : Form
    {
        String[] classesSaida;
        int numSaida;
        int numEntradas;
        public Double max, min;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            if (!openFileDialog1.FileName.Equals("openFileDialog1"))
            {


                Double[] pesoOculta = Session.Instance.pesoOculta;
                Double[] pesoSaida = Session.Instance.pesoSaida;
                int[,] mat = Testar.montarTeste(numEntradas, numSaida, Session.Instance.numOculta, openFileDialog1, classesSaida, Session.Instance.funcTransf, pesoOculta, pesoSaida,max,min);
                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "Classes/Saidas";
                dataGridView1.Columns[0].Width = 70;
                for (int i = 1; i < numSaida + 1; i++)
                {
                    dataGridView1.Columns[i].Name = "S" + i;
                    dataGridView1.Columns[i].Width = 70;
                }

                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    String[] rows = new String[numSaida + 1];
                    rows[0] = classesSaida[i];
                    for (int j = 0; j < mat.GetLength(1); j++)
                    {
                        rows[j + 1] = mat[i, j].ToString();
                    }
                    dataGridView1.Rows.Add(rows);
                }
                labelTestar.ForeColor = Color.Green;
                labelTestar.Text = "Teste Concluido!";
               
            }
            else
            {
                labelTestar.Text = "Inserir Arquivo!";
                labelTestar.ForeColor = Color.Red;
            }


        }

        private void nomeArquivo_Click(object sender, EventArgs e)
        {

        }

        private void btnEscolherArq_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV | *.csv";
            openFileDialog1.ShowDialog();
            String[] palavra = openFileDialog1.FileName.Split('\\');
            nomeArquivo.Text = palavra[palavra.Length - 1];
            int qtdClasses = 0, qtdSaidas = 0;
            this.max = Double.MinValue;
            this.min = Double.MaxValue;
            using (StreamReader sr = File.OpenText(openFileDialog1.FileName))
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
                while ((s = sr.ReadLine()) != null)
                {
                    int qtdVirgulas = 0;
                    int i;
                    string[] colunas = s.Split(',');
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
            numEntradas = qtdClasses;
            numSaida = qtdSaidas;
        }


    }
}
