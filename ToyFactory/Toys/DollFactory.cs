using System;
using System.Collections.Generic;
using System.Text;
using ToyFactory.Interfaces;

namespace ToyFactory.Toys
{
    public class DollFactory : IFactory<Doll>
    {
        public Doll MakeElement() => new Doll();
    }
}
