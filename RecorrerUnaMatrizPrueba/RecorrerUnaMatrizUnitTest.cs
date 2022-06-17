using RecorrerUnaMatrizBiblioteca;

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
            Algoritmo algoritmoRecorrerMatriz = new Algoritmo();
            int evaluado = 3;
            int obtenido;
            int esperado = [9,7,6,3,8];
            //Act = Actuar o realizar la prueba
            obtenido = algoritmoRecorrerMatriz.RecorrerMatriz(evaluado);
            //Assert = Afirmar, verificar que la prueba cumple la condicion k=3 RecorrerMatriz=[9,7,6,3,8]
            Assert.AreEqual(esperado, obtenido);
        }
    }
}