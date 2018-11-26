using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulClassesAndPatterns.Classes.StarWars.Solders;
using UsefulClassesAndPatterns.Patterns.AbstractFactory;

namespace UsefulClassesAndPatterns.Classes.StarWars.Client
{
    class Client
    {
        public List<AbstractSolder> SoldersList = new List<AbstractSolder>();

        private AbstractFactory AssaultFactory = new AssaultFartory();
        private AbstractFactory GunnerFactory = new GunnerFactory();
        private AbstractFactory ReconFactory = new ReconFactory();
        private AbstractFactory SniperFactory = new SniperFactory();

        public void CreateAssault()
        {
            SoldersList.Add(AssaultFactory.CreateSolder());
        }
        public void CreateGunner()
        {
            SoldersList.Add(GunnerFactory.CreateSolder());
        }
        public void CreateRecon()
        {
            SoldersList.Add(ReconFactory.CreateSolder());
        }
        public void CreateSniper()
        {
            SoldersList.Add(SniperFactory.CreateSolder());
        }
    }
}
