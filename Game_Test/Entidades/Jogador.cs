using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;
using Game_Test.Entidades;

namespace Game_Test.Entidades
{
    class Jogador : Entity
    {
        public float speed;
        public const float mov = 5;
        public bool vivo;
        public int healph;

        public Jogador(float x, float y) : base(x, y)
        {
            Graphic = Image.CreateCircle(20, Color.Red);
            Collider = new CircleCollider(20, Tags.jogador);

            this.speed = mov;
            vivo = true;
            healph = 10;
        }

        public override void Update()
        {
            base.Update();

            Movimentar();

            Colisao();
        }

        public void Movimentar()
        {
            if(Input.KeyDown(Key.A) || Input.KeyDown(Key.Left))
            {
                X -= speed;
            }

            if(Input.KeyDown(Key.D) || Input.KeyDown(Key.Right))
            {
                X += speed;
            }
        }

        public void Colisao()
        {
            var collision = Collider.CollideEntities(X, Y, Tags.inimigo);
            if (collision.Count > 0)
            {
                healph--;
                speed = 0;
            }
        }
    }
}