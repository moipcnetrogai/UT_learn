using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NomerWPF.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void A111AA11_ok()
        {
            Proverka pv = new Proverka();

            string dano = "А111АА11";
            string otvet = "ОК";

            string poluseno = pv.proverkaCAR(dano);
            Assert.AreEqual(otvet, poluseno);
        }


        [TestMethod]
        public void A221AA11_ok()
        {
            Proverka pv = new Proverka();
            string dano = "А221АА11";
            string otvet = "ОК";

            string poluseno = pv.proverkaCAR(dano);
            Assert.AreEqual(otvet, poluseno);
        }

        [TestMethod]
        public void _3321AA11_ok()
        {
            Proverka pv = new Proverka();
            string dano = "3321АА11";
            string otvet = "ОК";

            string poluseno = pv.proverkaCAR(dano);
            Assert.AreEqual(otvet, poluseno);
        }

        [TestMethod]
        public void НК02277_ok()
        {
            Proverka pv = new Proverka();
            string dano = "НК02277";
            string otvet = "ОК";

            string poluseno = pv.proverkaCAR(dano);
            Assert.AreEqual(otvet, poluseno);
        }
       
        [TestMethod]
        public void mailmailru_ok()
        {
            Proverka pv = new Proverka();
            string dano = "mail@mail.ru";
            string otvet = "ОК";

            string poluseno = pv.proverkaEMAIL(dano);
            Assert.AreEqual(otvet, poluseno);
        }

        [TestMethod]
        public void checkru_He_ok()
        {
            Proverka pv = new Proverka();
            string dano = "@mail@gmail.com";
            string otvet = "НЕ ОК";

            string poluseno = pv.proverkaEMAIL(dano);
            Assert.AreEqual(otvet, poluseno);
        }

        [TestMethod]
        public void _abc_ok()
        {
            Proverka pv = new Proverka();
            string dano = "_abc@yandex.ru";
            string otvet = "ОК";

            string poluseno = pv.proverkaEMAIL(dano);
            Assert.AreEqual(otvet, poluseno);
        }

        [TestMethod]
        public void Vasec_ok()
        {
            Proverka pv = new Proverka();
            string dano = "Vasekc@yahoo.com";
            string otvet = "ОК";

            string poluseno = pv.proverkaEMAIL(dano);
            Assert.AreEqual(otvet, poluseno);
        }
    }
}
