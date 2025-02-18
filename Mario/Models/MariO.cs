using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario.Models
{
    internal class MariO
    {
        public int LifeCount { get; private set; }
        public int CoinCount { get; private set; }
        public IState state;

        private SmallMario smallMario;
        private SuperMario superMario;
        private FireMario fireMario;
        private CapeMario capeMario;

        public MariO()
        {
            LifeCount = 1;
            CoinCount = 0;

            smallMario = new SmallMario(this);
            superMario = new SuperMario(this);
            fireMario = new FireMario(this);
            capeMario = new CapeMario(this);

            state = smallMario;
        }

        public IState GetState(string stateId)
        {
            switch (stateId)
            {
                case "smallMario":
                    return smallMario;
                case "superMario":
                    return superMario;
                case "fireMario":
                    return fireMario;
                case "capeMario":
                    return capeMario;
                default:
                    return null;
            }
        }

        public void GotMushroom()
        {
            state.GotMushroom();
        }

        public void GotFireFlower()
        {
            state.GotFireFlower();
        }

        public void GotFeather()
        {
            state.GotFeather();
        }

        public void MetMonster()
        {
            state.MetMonster();
        }

        public void GotCoins(int countOfCoins)
        {
            Console.WriteLine($"Got {countOfCoins} Coin(s)!");
            CoinCount += countOfCoins;
            if (CoinCount >= 4000)
            {
                GotLife();
                CoinCount -= 4000;
            }
        }

        public void GotLife()
        {
            Console.WriteLine("Glückwunsch ! Mario got Life!");
            LifeCount += 1;
        }

        public void LostLife()
        {
            Console.WriteLine("Leider Mario lost Life!");
            LifeCount -= 1;
            if (LifeCount <= 0)
                GameOver();
        }

        public void GameOver()
        {
            LifeCount = 0;
            CoinCount = 0;
            Console.WriteLine("Game Over! Mario ist echt tot! Mein Beileid! ");
        }

        public override string ToString()
        {
            return $"Mario's State: {state} | LifeCount: {LifeCount} | CoinsCount: {CoinCount} \n";
        }
    }
}
