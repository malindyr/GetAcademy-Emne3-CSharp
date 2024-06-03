using System;
using System.Collections.Generic;
using System.Text;

namespace Clicker
{
    class SuperUpgradeCommand : ICommand
    {
        private ClickerGame _game;
        public char Character { get; } = 'S';


        public SuperUpgradeCommand(ClickerGame game)
        {
            _game = game;
        }
        public void Run()
        {
            _game.SuperUpgrade();
        }

    }
}