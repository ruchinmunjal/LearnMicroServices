using System.Collections.Generic;

namespace LearnService.Api
{
    public class Hero
    {
        public string Name { get; set; }
        public string HeroName { get; set; }

        public IEnumerable<SuperPower> SuperPowers { get; set; }
    }

    public class SuperPower
    {
        public string Name { get; set; }
       
        public SuperPowerType SuperPowerType { get; set; }
        public int Strength { get; set; }
    }

    public enum SuperPowerType
    {
        Natural,
        SuperNatural,
        Alien
    }
}