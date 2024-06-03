using System;
using System.Collections.Generic;
using System.Text;

namespace Clicker
{
    interface ICommand
    {
        void Run();
        char Character { get; }
    }
}