using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Criação aleatória do individuo do AG
namespace AlgoritmoGenetico.Class
{
    public class Individuo
    {
        private BitArray cromossomo;            //Vetor e bits com apenas 2 estados. Bool
        private double fitness;                 //Nota de aptidao do individuo
        private double fitnessPercent;          //Percentual do individuo, quão apto é para reprodução
        private double[] faixaRoleta = { 0, 0 };//Faixa da pizza em que é provavel sua seleção

        //Contructor of class
        public Individuo()
        {
            //Instancia o cromossomo com a quantidade de bits informado na classe constantes
            this.cromossomo = new BitArray(Constants.sizeCromossomo);

            int i;

            for(i = 0; i < cromossomo.Length; i++)
            {
                //Popula o vetor com bits aleatórios
                this.cromossomo[i] = (Constants.random.NextDouble() > 0.5f) ? true : false;
            }
        }

        public BitArray getComossomo()
        {
            return this.cromossomo;
        }

        //Definir gene de cada cromossomo
        //Inserir valor booleano em um determinado local do vetor do cromossomo
        public void setGene(int position, bool gene)
        {
            this.cromossomo[position] = gene;
        }

        //Pegar bit do vetor cromossomo
        public bool getGene(int position)
        {
            return this.cromossomo[position];
        }

        public void setFitness(double fitness)
        {
            this.fitness = fitness;
        }

        public double getFitness()
        {
            return this.fitness;
        }

         public void setFitnessPercent(double fitnessPercent)
        {
            this.fitnessPercent = fitnessPercent;
        }

        public double getFitnessPercent()
        {
            return this.fitnessPercent;
        }

        //Multar bit referete a List do cromossomo ( bool 0 ou 1 )
        public void mutarBit(int position)
        {
            if(position < cromossomo.Length)
            {
                cromossomo.Set(position, cromossomo[position] == false ? true : false);
            }
        }

        public void setRangeRoleta(double inicio, double fim)
        {
            faixaRoleta[0] = inicio;
            faixaRoleta[1] = fim;
        }

        public double[] getRangeRoleta()
        {
            return this.faixaRoleta;
        }

        //Metodo para etornar inteiro para individuo, array de bits para decimal
        public int getInt()
        {
            if (this.cromossomo.Length > 32)
                throw new ArgumentException("O comprimento do cromossomo deve ser no maximo 32 bits");

            int[] array = new int[1];
            this.cromossomo.CopyTo(array, 0); //Converter todos valores do cromossomo em binário para decimal usando o "CopyTo"
            return array[0];
        }

        //Printar o individuo
        public string PrintIndividuo()
        {

            string result = string.Empty; //Empty, string tpo nula
            result += "\nBits: ";             //Print Array de bits
            for(int i = cromossomo.Length - 1; i >= 0; i--)
            {
                //Converte o bool em base 2 (1 ou 0)
                result = result + (cromossomo[i] == false ? "0" : "1");
            }


            result = result + "   INT:  " + getInt() + "   Aptidão:   " + getFitness() + "   Porcentagem:   " + getFitnessPercent();

            return result;
        }
    }
}
