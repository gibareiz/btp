using System;
using System.Collections.Generic;

namespace Teste1
{
    class Program
    {
        //TODO
        /* 
         * Desenvolva um método que receba a string "abbcbbb". O retorno desse método deverá ser "abcb", 
         * logo o próximo caracter não deverá ser igual ao anterior, o método deve ser capaz de tratar qualquer string.
        */

        static void Main(string[] args)
        {
            String avaliacao = "abbcbbb";
            string resultado = trataString(avaliacao);
            Console.WriteLine(resultado);
        }

        static private string trataString(string texto)
        {
            string resposta = "";
            char[] ch = texto.ToCharArray();
            List<char> resp = new List<char>();

            if (ch.Length > 0)
            {
                resp.Add(ch[0]);

                if (ch.Length > 1)
                {
                    for (var i = 1; i < ch.Length; i++)
                    {
                        if (resp[resp.Count - 1] != ch[i]) resp.Add(ch[i]);
                    }
                }
            }

            foreach (char c in resp) resposta += c.ToString();

            return resposta;
        }

    }
}
