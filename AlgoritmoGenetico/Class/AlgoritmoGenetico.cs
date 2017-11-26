using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico.Class
{
    public class AlgoritmoGenetico          //Classe elaborada para a aplicação do Algoritmo Genético
    {
        private double taxaCrossover;
        private double taxaMutacao;
        static int PAI = 0;
        static int MAE = 1;

        public AlgoritmoGenetico(double taxaCrossover, double taxaMutacao)
        {
            this.taxaCrossover = taxaCrossover;
            this.taxaMutacao = taxaMutacao;
        }


        //Método qual aplica a operação genética
        public Populacao executaAG(Populacao pop)
        {

            //Inicio do AG
            //Avaliação da População
            Populacao novaPopulacao = new Populacao();
            List<Individuo> popBuffer = new List<Individuo>(); 

            for(int i = 0; i < (Constants.sizePopulacao / 2); i++)
            {
                //Selecionar os pais para cruzamento
                Individuo pai = Roleta(pop);
                Individuo mae = Roleta(pop);

                //Realizar o Cruzamento 
                Individuo[] filhos = Crossover(pai, mae);

                //Aplicar a mutação (Se necessario)
                Individuo filhoA = Mutacao(filhos[0]);
                Individuo filhoB = Mutacao(filhos[1]);

                popBuffer.Add(filhoA);
                popBuffer.Add(filhoB);


            }
            
            //Apagar velhos membros da população
            //Inserir novos membros
            for(int i = 0; i < Constants.sizePopulacao; i++)
            {
                novaPopulacao.setIndividuo(i, popBuffer[i]);
            }
            popBuffer = null;

            //Re-avalizar a pop
            novaPopulacao.atualizarValores();


            return novaPopulacao;
        }

        //Método Crossover. Envia como parametro um pai e uma mãe e retorna 2 filhos
        public Individuo[] Crossover(Individuo pai, Individuo mae)
        {
            Individuo[] novoInd = new Individuo[2];
            int pontodeCorte = Constants.random.Next(0, Constants.sizeCromossomo - 1);

            Individuo paiBuffer = new Individuo();
            Individuo maeBuffer = new Individuo();

            novoInd[PAI] = new Individuo();
            novoInd[MAE] = new Individuo();

            for(int i = 0; i < Constants.sizeCromossomo; i++) //Inserir dados passados por parâmetro para as variaveis *Buffer, já fazendo o crossover 
            {
                paiBuffer.setGene(i, pai.getGene(i));
                maeBuffer.setGene(i, mae.getGene(i));

                //Enviando caracteristicas do pai e mae para o novo individuo
                novoInd[PAI].setGene(i, pai.getGene(i));
                novoInd[MAE].setGene(i, mae.getGene(i));
            }

            //Verificar ponto de crossover e alterar o genes. Verificar se individuo cai na taxa de crossover
            //Se a condição para crossover aceita, executa o If e faz o crossover, senão, mantem as propriedades já inseridas acima 
            if(Constants.random.NextDouble() < taxaCrossover)
            {
                //Console.Write("Caiu na taxa de Crossover! Ponto de Corte: " + pontodeCorte + "\n");
                for(int i = pontodeCorte; i < Constants.sizeCromossomo; i++) //De forma randomica, define a posição do corte para mutação
                {
                    //A partir do pontodeCorte
                    //Crossover do novoInd com genes do pai com cross da mãe no pontodeCorte
                    novoInd[PAI].setGene(i, maeBuffer.getGene(i));
                    novoInd[MAE].setGene(i, paiBuffer.getGene(i));
                }
            }

            //else
            //{
            //    for (int i = pontodeCorte; i < Constants.sizeComossomo; i++) //De forma randomica, define a posição do corte para mutação
            //    {
            //        //A partir do pontodeCorte
            //        //Crossover do novoInd com genes do pai com cross da mãe no pontodeCorte
            //        novoInd[PAI].setGene(i, paiBuffer.getGene(i));
            //        novoInd[MAE].setGene(i, maeBuffer.getGene(i));
            //    }
            //}

            return novoInd;
            //Método retorna a lista com os individuos já aplicado o crossover
        }

        //Método de mutação. Passa o individuo como parametro e retorna o individuo já mutado
        public Individuo Mutacao(Individuo ind)
        {
            if(Constants.random.NextDouble() <= taxaMutacao)
            {
                int genePosition = Constants.random.Next(0, Constants.sizeCromossomo);
                ind.mutarBit(genePosition);
                //Localiza a posição no genePosition e altera seu bit ( true para false ou false para true
                return ind;
            }

            //Se a condição não for atendida, retorna o ind sem mutação
            return ind;
        }

        public Individuo Roleta(Populacao pop)
        {
            //Numero sorteado randomico gerado
            double numSorteado = (Constants.random.NextDouble() * 100);

            foreach (Individuo ind in pop.getPopulacao())
            {
                if (numSorteado >= ind.getRangeRoleta()[0] && numSorteado <= ind.getRangeRoleta()[1]) 
                {
                    //Se ele estiver entre a posição inicial e final da pizza, retorne
                    return ind;
                }
            }
            //Nunca vai acontecer
            return null;
        }
    }
}
