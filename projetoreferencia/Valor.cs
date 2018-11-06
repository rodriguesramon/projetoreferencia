using System;
using System.Collections.Generic;
using System.Text;

namespace projetoreferencia
{
    public class Valor
    {
        public void passagemPorValor(int a){
            a = 10;
        }

        public void passagemPorReferencia(ref int a){
            a = 10;
        }
    }
}
