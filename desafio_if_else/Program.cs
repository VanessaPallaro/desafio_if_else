using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace desafio_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Foi-lhe solicitado que adicionasse uma funcionalidade ao software da sua empresa.//
            //A funcionalidade destina-se a melhorar a taxa de renovação de subscrições do software.//
            //A sua tarefa consiste em apresentar uma mensagem de renovação quando um utilizador//
            //iniciar sessão no sistema de software e for notificado de que a subscrição irá terminar em breve.//
            //Precisará de adicionar algumas instruções de decisão para adicionar corretamente a lógica de ramificação à aplicação//
            //de forma a corresponder às condições.//
            //Regra 1: o código só deve apresentar uma mensagem.//
            //Regra 2: se a subscrição do utilizador expirar dentro de 10 dias ou menos utilize a msg: Sua assinatura expirará em breve. Renovar agora!//
            //Regra 3: se a subscrição do utilizador expirar dentro de cinco dias ou menos, apresente as mesg: Sua assinatura expira em _ dias.Renove agora e economize 10 % //
            //Regra 4: se a subscrição do utilizador expirar dentro de um dia, apresente as msg:Sua assinatura expira em um dia! Renove agora e economize 20 % //
            //Regra 5: se a subscrição do utilizador tiver expirado, apresente a msg:Sua assinatura expirou.//
            //Regra 6: se a subscrição do utilizador não expirar dentro de 10 dias ou menos, não apresentará nada.//


            //Obrigatório o uso//
            Random random = new Random();
            int dataEspira = random.Next(12);
            int desconto = 0;

            if (dataEspira == 0)
            {
                Console.WriteLine("Sua assinatura expirou");
            }
            else if (dataEspira == 1)
            {
                Console.WriteLine("Sua assinatura expira em um dia!");
                desconto = 20;
            }
            else if (dataEspira <= 5)
            {
                Console.WriteLine($"Sua assinatura expira em {dataEspira} dias.");
                desconto = 10;
            }
            else if (dataEspira <= 10)
            {
                Console.WriteLine($"Sua assinatura expirará em breve. Renovar agora!");
            }
            
            if (desconto > 0)
            {
                Console.WriteLine($"Renove e ganhe {desconto}%");
            }
           
        }
    }
}
