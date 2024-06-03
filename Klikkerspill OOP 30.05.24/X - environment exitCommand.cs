using System;
using System.Collections.Generic;
using System.Text;

namespace Clicker
{
    class ExitCommand : ICommand
    {
        public char Character { get; } = 'X';
        public void Run()
        {
            Environment.Exit(0);
        }
    }
}