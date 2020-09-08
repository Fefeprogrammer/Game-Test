using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;
using Game_Test.Entidades;


namespace Game_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game("Game Teste", 800, 600);

            var scene1 = new Scene();

            Random posX = new Random();
            Random posY = new Random();

            var jogador = new Jogador(500, 300);
            //Inimigo[] inimigo = new Inimigo[10];
            int val;

            int x = 0;

            /*for(x=0; x< inimigo.Length; x++)
            {
                inimigo[x] = new Inimigo(posX.Next(100), 20);
               
            }*/

            var inimigo = new Inimigo(posX.Next(600), posY.Next(10));
            var inimigo1 = new Inimigo(posX.Next(600), posY.Next(10));
            var inimigo2 = new Inimigo(posX.Next(600), posY.Next(10));
            var inimigo3 = new Inimigo(posX.Next(600), posY.Next(10));


            scene1.Add(jogador);
            scene1.Add(inimigo);
            scene1.Add(inimigo1);
            scene1.Add(inimigo2);
            scene1.Add(inimigo3);


            game.Start(scene1);
        }
    }
}
