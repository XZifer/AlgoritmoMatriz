namespace RecorrerUnaMatrizPrueba
{
    [TestClass]
    public class RecorrerUnaMatrizUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void Prueba3Regresa97638()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo algoritmoDistanciaBinaria = new Algoritmo();
            int evaluado = 3;
            int obtenido;
            int esperado = [9,7,6,3,8];
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoDistanciaBinaria.CalculaDistanciaBinaria(evaluado);
            //Assert = Afirmar, verificar que la prueba cumple la condicion N=9 distanciabinaria=2
            Assert.AreEqual(esperado, obtenido);
        }
    }
}