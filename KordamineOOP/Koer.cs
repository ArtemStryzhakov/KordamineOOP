using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordamineOOP
{
    class Koer: Koduloom
    {
        public enum toug { Mops, Buldog, ShibaInu}; //tõug - порода
        public toug loomaToug;
        public Koer(toug toug, string nimi, string varv, sugu loomaSugu, double kaal, int vanus, bool elav = false) : base(nimi, varv, loomaSugu, kaal, vanus, elav)
        {
            this.loomaToug = toug;
        }   

        public Koer(Koer koer) //kloonimiseks
        {
            this.nimi = koer.nimi;
            this.varv = koer.varv;
            this.loomaSugu = koer.loomaSugu;
            this.kaal = koer.kaal;
            this.vanus = koer.vanus;
            this.elav = koer.elav;
            this.loomaToug = koer.loomaToug;
        }

        public override void print_Haal()
        {
            Console.WriteLine("KuKu");
        }
        
        public override void print_Info()
        {
            Console.WriteLine($"{loomaToug} {varv} {nimi} ta on {loomaSugu} ja tema kaal on {kaal} ja ta on {vanus} aastat vana");
        }

        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
        public void muudaVarv(string uusVarv) { varv = uusVarv; }
        public void muudaSugu(sugu uusSugu) { loomaSugu = uusSugu; }
        public void muudaKaal(double uusKaal) { kaal = uusKaal; }
        public void muudaVanus(int uusVanus) { vanus = uusVanus; }
    }
}
