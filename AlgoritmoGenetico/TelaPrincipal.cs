using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgoritmoGenetico.Class;
using ZedGraph;

namespace AlgoritmoGenetico
{
    public partial class TelaPrincipal : Form
    {

        private Populacao pop;

        //Utilizando a classe ZedGraph
        private GraphPane panePop;
        private GraphPane paneMedia;

        private PointPairList curvaGrafico = new PointPairList();
        private PointPairList populacaoGrafico = new PointPairList();
        private PointPairList mediaPopulacao = new PointPairList();
        
        public TelaPrincipal()
        {
            InitializeComponent();

            btnIniciarAG.Enabled = false;

            //panePop (Painel do zedgraph População) 
            panePop = zedPopulacao.GraphPane;
            panePop.Title.Text = "Evolução";
            panePop.XAxis.Title.Text = "Gerações";
            panePop.YAxis.Title.Text = "Individuos";
            zedPopulacao.Refresh();

            paneMedia = zedMediaPopulacao.GraphPane;
            paneMedia.Title.Text = "Média População";
            paneMedia.XAxis.Title.Text = "Gerações";
            paneMedia.YAxis.Title.Text = "Média Fitness";
            zedMediaPopulacao.Refresh();

            for(int i = 0; i < Constants.functionXSize; i++)
            {
                curvaGrafico.Add(i, Constants.function1(i));
            }

            LineItem func = panePop.AddCurve("Função", curvaGrafico, Color.Red, SymbolType.None);

            zedPopulacao.AxisChange();
            zedPopulacao.Invalidate();
            zedPopulacao.Refresh();

            zedMediaPopulacao.AxisChange();
            zedMediaPopulacao.Invalidate();
            zedMediaPopulacao.Refresh();
        }

        private void btnCriarPop_Click(object sender, EventArgs e)
        {
            btnIniciarAG.Enabled = true;
            pop = new Populacao();
            populacaoGrafico = new PointPairList();

            for (int j = 0; j < Constants.sizePopulacao; j++)
            {
                //Eixo X é o valor inteiro do Individuo (Bool convertido para decimal
                //Eixo Y é o valor decimal já convertido
                populacaoGrafico.Add(pop.getPopulacao()[j].getInt(), pop.getPopulacao()[j].getFitness());
            }

            LineItem inds = panePop.AddStick("Individuos", populacaoGrafico, Color.Blue);
            zedPopulacao.AxisChange();
            zedPopulacao.Invalidate();
            zedPopulacao.Refresh();
        }

        private void btnIniciarAG_Click(object sender, EventArgs e)
        {
            //Variaveis enriquecidas com os dados do txt
            double taxaMutacao = double.Parse(txtTaxaMutacao.Text);
            double taxaCrossover = double.Parse(txtTaxaMutacao.Text);
            int iteracoes = int.Parse(txtIteracoes.Text);

            //Criar Algoritmo Genetico
            Class.AlgoritmoGenetico ag = new Class.AlgoritmoGenetico(taxaCrossover, taxaMutacao);

            for(int i = 0; i < iteracoes; i++)
            {
                pop = ag.executaAG(pop);

                mediaPopulacao.Add(i, pop.getMediaPopulacao());

                zedMediaPopulacao.GraphPane.CurveList.Clear(); //Limpar zed toda vez que o for é executado
                zedMediaPopulacao.GraphPane.GraphObjList.Clear();

                zedPopulacao.GraphPane.CurveList.Clear();
                zedPopulacao.GraphPane.GraphObjList.Clear();

                populacaoGrafico = new PointPairList();

                for(int j=0; j < Constants.sizePopulacao; j++)
                {
                    populacaoGrafico.Add(pop.getPopulacao()[j].getInt(), pop.getPopulacao()[j].getFitness());
                }

                //Incluindo no gráfico
                LineItem media = paneMedia.AddCurve("Média", mediaPopulacao, Color.Red, SymbolType.None);
                LineItem func = panePop.AddCurve("Função", curvaGrafico, Color.Red, SymbolType.None);
                LineItem indv = panePop.AddStick("Individuo", populacaoGrafico, Color.Red);

                //Atualizar Valores
                zedPopulacao.AxisChange();
                zedPopulacao.Invalidate();
                zedPopulacao.Refresh();

                zedMediaPopulacao.AxisChange();
                zedMediaPopulacao.Invalidate();
                zedMediaPopulacao.Refresh();
            }
        }
    }
}
