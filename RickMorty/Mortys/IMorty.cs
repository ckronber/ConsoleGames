using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickMorty.Mortys
{
    public interface IMorty
    {
        int Health {get;}
        void Scream();
        void Hurt(Attack attack);
        Attack Attack();
    }
}
