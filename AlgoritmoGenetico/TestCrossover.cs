﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgoritmoGenetico.Class;

namespace AlgoritmoGenetico
{
    public partial class TestCrossover : Form
    {
        Populacao pop = new Populacao();

        Class.AlgoritmoGenetico ag = new Class.AlgoritmoGenetico(0.8f, 0.01f); // ( Taxa de crossover , Taxa de Mutação)

        public TestCrossover()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //Class.AlgoritmoGenetico ag = new Class.AlgoritmoGenetico(1f, 0);
            Individuo pai = new Individuo();
            Individuo mae = new Individuo();

            txtPai.Text = pai.PrintIndividuo();
            txtMae.Text = mae.PrintIndividuo();

            Individuo[] filhos = ag.Crossover(pai, mae);

            txtFilho1.Text = filhos[0].PrintIndividuo();
            txtFilho2.Text = filhos[1].PrintIndividuo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pop = ag.executaAG(pop);
            txtPop.Text = pop.printPop();
            lbMedia.Text = pop.getMediaPopulacao().ToString();
        }
    }
}
