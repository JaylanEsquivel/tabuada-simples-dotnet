using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tabuada.Models
{
    public class Tabuada
    {
        public void Montar(int x){

            for(int cont = 1;cont <= 10; cont++ ){
                int result = x * cont;
                Console.WriteLine($"{x} * {cont} = {result}");
            }

        }

        public void MontarCompleta(){
            int auxiliar = 1;
            for(int cont = 1;cont <= 10; cont++ ){
                Console.WriteLine($"Tabuada do {cont}");

                while(auxiliar <= 10){
                    int result = cont * auxiliar;
                    Console.WriteLine($"{cont} * {auxiliar} = {result}");
                    auxiliar++;
                }
                auxiliar = 1;
                Console.WriteLine("_____________");
            }

        }


    }
}