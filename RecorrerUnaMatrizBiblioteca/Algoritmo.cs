namespace RecorrerUnaMatrizBiblioteca
{
    public class Algoritmo
    {
        public int RecorrerMatriz(int k)
        {
            //Creamos una lista
            List<int> matriz = new List<int>();
            matriz.Add(3);
            matriz.Add(8);
            matriz.Add(9);
            matriz.Add(7);
            matriz.Add(6);
            //Recorremos el numero de veces K la matriz
            for (int i = 0; i == k; i++)
            {
                int numeroaRecorrer = matriz[matriz.Count -1];
                matriz.Remove(numeroaRecorrer);
                matriz.Add(numeroaRecorrer);
            }
            return 0;
        }
    }
}