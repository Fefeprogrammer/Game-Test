using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;
using Game_Test.Entidades;

namespace Game_Test.Entidades
{
    class Vida : Entity
    {
        public Text vida;

        public Vida(float x, float y) : base(x, y)
        {
            vida = new Text();
        }
    }
}
