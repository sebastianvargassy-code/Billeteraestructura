using BilleteraCajaArequipa.Modelos;
using BilleteraCajaArequipa.Nodos;

namespace BilleteraCajaArequipa.Estructuras
{
    public class ListaCircularReintentos
    {
        public NodoCircular inicio;
        public NodoCircular fin;

        public void Adicionar(Operacion dato)
        {
            NodoCircular nuevo = new NodoCircular();
            nuevo.info = dato;

            if (inicio == null)
            {
                inicio = nuevo;
                fin = nuevo;
                nuevo.sgte = inicio;
            }
            else
            {
                fin.sgte = nuevo;
                nuevo.sgte = inicio;
                fin = nuevo;
            }
        }

        public int Contar()
        {
            if (inicio == null)
            {
                return 0;
            }

            NodoCircular p = inicio;
            int conta = 0;
            do
            {
                conta = conta + 1;
                p = p.sgte;
            } while (p != inicio);

            return conta;
        }

        public NodoCircular Buscar(string codigo)
        {
            if (inicio == null)
            {
                return null;
            }

            NodoCircular p = inicio;
            do
            {
                if (codigo == p.info.codigo)
                {
                    return p;
                }
                p = p.sgte;
            } while (p != inicio);

            return null;
        }

        public void Eliminar(NodoCircular actual)
        {
            if (actual == null || inicio == null)
            {
                return;
            }

            if (inicio == fin && actual == inicio)
            {
                inicio = null;
                fin = null;
            }
            else
            {
                NodoCircular p = inicio;
                while (p.sgte != actual)
                {
                    p = p.sgte;
                }

                if (actual == inicio)
                {
                    inicio = actual.sgte;
                    fin.sgte = inicio;
                }
                else if (actual == fin)
                {
                    fin = p;
                    fin.sgte = inicio;
                }
                else
                {
                    p.sgte = actual.sgte;
                }
            }
        }
    }
}
