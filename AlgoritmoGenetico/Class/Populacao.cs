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
            calcularFitness();
            calcularFitnessPercent();
            calcularRangeRoleta();

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

        public void calcularFitnessPercent()
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

        //Calcula o range da roleta em que o individuo faz parte 
        public void calcularRangeRoleta()
        {
            //Primeiramente deve-se ordenar a população em ordem crescente
            //Chamar método para ordenar a população
            OrdenarPopulacao();

            double somatoria = 0;
            
            for(int i = 0; i < Constants.sizePopulacao; i++)
            {
                if(i == 0)
                {
                    somatoria += populacao[i].getFitnessPercent();
                    populacao[i].setRangeRoleta(0, somatoria);
                }

                else if(i == (Constants.sizePopulacao - 1))
                {
                    populacao[i].setRangeRoleta(somatoria, 100f);
                }

                else
                {
                    populacao[i].setRangeRoleta(somatoria, somatoria + populacao[i].getFitnessPercent());
                    somatoria += populacao[i].getFitnessPercent();
                }
            }
        }

        //Método para atualização dos valores
        public void atualizarValores()
        {
            //Calcular o Fitness 
            calcularFitness();

            //Calcular o FitnessPercent
            calcularFitnessPercent();

            //Calcular o range da roleta
            calcularRangeRoleta();
        }

        //Get individuo da população
        public Individuo[] getPopulacao()
        {
            return this.populacao;
        }

        //Settar individuo da população
        public void setIndividuo(int posicao, Individuo individuo)
        {
            this.populacao[posicao] = individuo;
        }

        //Método para retornar média da população
        public double getMediaPopulacao()
        {
            double sum = 0;
            foreach(Individuo ind in populacao)
            {
                sum += ind.getFitness();
            }

            return sum / Constants.sizePopulacao;
        }



        //Método para ordenar a população
        public void OrdenarPopulacao()
        {
            Individuo aux = new Individuo();
            
            for (int i = 0; i < Constants.sizePopulacao; i++)
            {
                for (int j = 0; j < Constants.sizePopulacao; j++)
                {
                    if (populacao[i].getFitnessPercent() < populacao[j].getFitnessPercent())
                    {
                        aux = populacao[i];
                        populacao[i] = populacao[j];
                        populacao[j] = aux;
                    }
                }
            }
        }


        //Printar resultados
        public string printPop()
        {

            string result = string.Empty;

            for(int i=0; i < Constants.sizePopulacao; i++ )
            {
                result = result + populacao[i].PrintIndividuo() + "   |   "
                                + populacao[i].getInt().ToString() + "   |   "
                                + populacao[i].getFitness().ToString() + "   |   "
                                + populacao[i].getFitnessPercent().ToString() + "   |   "
                                + populacao[i].getRangeRoleta()[0].ToString() + ";"  
                                + populacao[i].getRangeRoleta()[1].ToString();
            }
            return result;
        }

    }   
}
