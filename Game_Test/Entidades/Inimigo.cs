using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;
using Game_Test.Entidades;

namespace Game_Test.Entidades
{
    class Inimigo:Entity
    {
        public float speed;
        public float mov = 5;

        public Inimigo(float x, float y) : base(x, y)
        {
            Graphic = Image.CreateCircle(20, Color.Blue);
            Collider = new CircleCollider(20, Tags.inimigo);

            speed = mov;
        }

        public override void Update()
        {
            base.Update();

            Mov();
        }

        public void Mov()
        {
            Y += speed;
        }
    }
}
