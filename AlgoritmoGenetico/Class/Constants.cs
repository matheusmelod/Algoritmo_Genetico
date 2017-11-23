﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico.Class
{
    public abstract class Constants
    {
        static public int sizeComossomo = 9;                                //Tamanho do individuo
        static public int sizePopulacao = 500;                              //Tamanho da população
        static public int functionXSize = (int)Math.Pow(2, sizeComossomo);  //Função como em 0 até 2 exponencial tamanho do cromossomo
        public static Random random = new Random((int)DateTime.Now.Ticks);  //Objeto Randomico, gera numeros pelo clock do processador

        public static  double function1(double x)
        {
            return (double)(100 + Math.Abs(x * Math.Sin(Math.Sqrt(Math.Abs(x)))));
        }
    }
}
