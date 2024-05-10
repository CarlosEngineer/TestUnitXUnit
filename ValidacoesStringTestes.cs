using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.Services;



namespace CalculatorTest
{
    public class ValidacoesStringTestes
    {
        private ValidacoesString _validacoes;

         public ValidacoesStringTestes()
         {
            _validacoes = new ValidacoesString();
         }
        [Fact]

        public void DeveContar3CaractereEmOlaERetornar3()
        {
            //arrange 
            string text = "ola";


            //act 
            int Resultado =  _validacoes.ContarCaracteres(text);


            //assert

            Assert.Equal(3,Resultado);
        }


    }





}