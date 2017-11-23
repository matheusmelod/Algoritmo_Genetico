using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico.Class
{
    public class Populacao
    {
        private Individuo[] populacao;          //Grupo de individuos, vetor com N individuos

        //Construtor da classe população
        public Populacao()
        {
            this.populacao = new Individuo[Constants.sizePopulacao];
            int i;
            for( i = 0; i < Constants.sizePopulacao; i++ )
            {
                //Geração aleatória do individuo na constante "Individuo", onde é adicionado a população
                populacao[i] = new Individuo();
            }


            //Avaliação da população

        }

        //Método para calculo do fitness de cada individuo
        public void calcularFitness()
        {
            int i;

            for(i = 0; i < Constants.sizePopulacao; i++)
            {
                //Para calcular, aplique o valor inteiro do individuo na função de aptidão
                this.populacao[i].setFitness(Constants.function1(this.populacao[i].getInt()));
            }
        }

        public void CalcularFitnessPercent()
        {
            double somatoriaFitness = 0;

            //Somatoria de todos os valores de aptidão
            for(int i = 0; i < Constants.sizePopulacao; i++ )
            {
                somatoriaFitness += populacao[i].getFitness();
            }

            for(int i = 0; i < Constants.sizePopulacao; i++)
            {
                //Atribuir valor do FitnessPercent para um determinado individuo da população "populacao"
                populacao[i].setFitnessPercent((populacao[i].getFitness() * 100) / somatoriaFitness);
        
                    //somatoriaFitness --------- 100%
                    //ind(i) ------------------- X?
                    //Calculo = ( x / somatoria fitness ) * 100
            }
        }

    }   
}
