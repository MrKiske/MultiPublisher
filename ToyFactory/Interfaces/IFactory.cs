using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ToyFactory.Interfaces
{
    public interface IFactory<T>
    {
        T MakeElement();
    }
}
