using System;
using System.Collections.Generic;
using System.Linq;
using BankingApp.L0.DataAccess.Domain;
using BankingApp.L0.DataAccess.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.LO.DataAccess.Tests
{
    [TestClass]
    public class UnitTestComptesRepositoryImpl_EF
    {
        [TestMethod()]
        public void TestCreate()
        {
            // arrange
            var nouveau = new Compte { Numero = "C5000", Proprietaire = "Chams", Solde = 4000M };
            var underTest = new ComptesRepositoryImpl_EF();

            // act
            underTest.Create(nouveau);

            // assert
        }

        [TestMethod()]
        public void TestFindByIdDegrade()
        {
            // arrange
            var underTest = new ComptesRepositoryImpl_EF();
            var numero = "NNNNN";

            // act
            var actual = underTest.FindById(numero);

            // assert
            Assert.IsNull(actual);
        }

        [TestMethod()]
        public void TestFindAll()
        {
            // arrange
            var underTest = new ComptesRepositoryImpl_EF();

            // act
            var actual = (List<Compte>)underTest.FindAll();

            // assert
            Assert.AreEqual(actual.Count, 5);
        }
    }
}
