namespace BilleteraCajaArequipa.Estructuras
{
    public class GrafoAgencias
    {
        public const int INF = 9999;
        public string[] agencias;
        public int[,] matriz;
        public int n;

        public GrafoAgencias(int cantidad)
        {
            n = cantidad;
            agencias = new string[n];
            matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = (i == j) ? 0 : INF;
                }
            }
        }

        public void AgregarEnlace(int origen, int destino, int peso)
        {
            matriz[origen, destino] = peso;
            matriz[destino, origen] = peso;
        }

        public void CortarEnlace(int origen, int destino)
        {
            matriz[origen, destino] = INF;
            matriz[destino, origen] = INF;
        }

        // Algoritmo de Floyd-Warshall: ruta mínima entre origen y destino
        public string RutaMinimaFloyd(int origen, int destino)
        {
            int[,] dist = new int[n, n];
            int[,] sig = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dist[i, j] = matriz[i, j];
                    sig[i, j] = (i != j && matriz[i, j] < INF) ? j : -1;
                }
            }

            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (dist[i, k] + dist[k, j] < dist[i, j])
                        {
                            dist[i, j] = dist[i, k] + dist[k, j];
                            sig[i, j] = sig[i, k];
                        }
                    }
                }
            }

            if (origen == destino)
            {
                return agencias[origen] + " (0 ms)";
            }

            if (sig[origen, destino] == -1 || dist[origen, destino] >= INF)
            {
                return "Sin conexión disponible entre estas agencias.";
            }

            string ruta = agencias[origen];
            int actual = origen;
            while (actual != destino)
            {
                actual = sig[actual, destino];
                ruta = ruta + " -> " + agencias[actual];
            }

            return ruta + "  (Total: " + dist[origen, destino] + " ms)";
        }

        // Algoritmo de Prim: árbol de expansión mínima (MST)
        public string[] ArbolMinimoPrim(out int total)
        {
            int[] padre = new int[n];
            int[] clave = new int[n];
            bool[] visitado = new bool[n];

            for (int i = 0; i < n; i++)
            {
                clave[i] = INF;
                padre[i] = -1;
                visitado[i] = false;
            }

            clave[0] = 0;

            for (int paso = 0; paso < n; paso++)
            {
                int u = -1;
                int menor = INF;

                for (int v = 0; v < n; v++)
                {
                    if (!visitado[v] && clave[v] < menor)
                    {
                        menor = clave[v];
                        u = v;
                    }
                }

                if (u == -1)
                {
                    break;
                }

                visitado[u] = true;

                for (int v = 0; v < n; v++)
                {
                    if (!visitado[v] && matriz[u, v] < clave[v])
                    {
                        padre[v] = u;
                        clave[v] = matriz[u, v];
                    }
                }
            }

            string[] resultado = new string[n];
            int pos = 0;
            total = 0;

            for (int i = 1; i < n; i++)
            {
                if (padre[i] != -1)
                {
                    resultado[pos] = agencias[padre[i]] + " <-> " + agencias[i] + " (" + clave[i] + " ms)";
                    total = total + clave[i];
                    pos = pos + 1;
                }
            }

            return resultado;
        }
    }
}
