using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GolfBackEnd.Repository;
using GolfBackEnd;
using Microsoft.Practices.Unity;
using GolfBackEnd.Model;
using System.Collections.Generic;

namespace GolfBackEndTest
{
    [TestClass]
    public class UnitTest1
    {
        private static IReservaRepository _sutRepository;
        [ClassInitialize]
        public static void TestInitialize(TestContext textContext)
        {
            using (var db = new GolfDropCreateDB(false))
            {
                db.Reservas.Find(1);
            }
            UnityContainerFactory factoria = new UnityContainerTestingFactory();
            IUnityContainer container = factoria.GetInstance();
            _sutRepository = container.Resolve<IReservaRepository>();
        }
        [TestMethod]
        public void TestMethod1()
        {
            ReservaDTO reserva = new ReservaDTO { Partido = new PartidoDTO { Campo = new CampoDTO() } };
            reserva = _sutRepository.Create(reserva);
            Assert.AreNotEqual(-1, reserva.ReservaId);
            ReservaDTO leida = _sutRepository.Read(reserva.ReservaId);
            Assert.IsNull(leida.Partido);
            ReservaDTO reserva1 = new ReservaDTO { Partido = new PartidoDTO { Campo = new CampoDTO() } };
            ReservaDTO reserva2 = new ReservaDTO { Partido = new PartidoDTO { Campo = new CampoDTO() } };
            _sutRepository.Create(reserva1);
            _sutRepository.Create(reserva2);
            IList<ReservaDTO> lista = _sutRepository.List();
            Assert.AreEqual(3, lista.Count);
            ReservaDTO toUpdate = _sutRepository.Read(2);
            PartidoDTO partido = new PartidoDTO();
            toUpdate.Partido = partido;
            ReservaDTO updated = _sutRepository.Update(toUpdate);
            Assert.AreNotEqual(updated, toUpdate);
            Assert.AreEqual(partido, updated.Partido);
            ReservaDTO deleted = _sutRepository.Delete(1);
            Assert.IsNotNull(deleted);
            ReservaDTO tryToRead = _sutRepository.Read(1);
            Assert.IsNull(tryToRead);
        }
    }
}
