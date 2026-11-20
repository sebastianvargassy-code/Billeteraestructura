using BilleteraCajaArequipa.Modelos;
using BilleteraCajaArequipa.Nodos;

namespace BilleteraCajaArequipa.Estructuras
{
    public class ListaDobleOperaciones
    {
        public NodoDoble inicio;
        public NodoDoble fin;

        public void Adicionar(Operacion dato)
        {
            NodoDoble nuevo = new NodoDoble();
            nuevo.info = dato;
            nuevo.sgte = null;
            nuevo.ant = null;

            if (inicio == null)
            {
                inicio = nuevo;
                fin = nuevo;
            }
            else
            {
                fin.sgte = nuevo;
                nuevo.ant = fin;
                fin = nuevo;
            }
        }

        public int Contar()
        {
            NodoDoble p = inicio;
            int conta = 0;
            while (p != null)
            {
                conta = conta + 1;
                p = p.sgte;
            }
            return conta;
        }

        public NodoDoble Buscar(string codigo)
        {
            NodoDoble p = inicio;
            while (p != null)
            {
                if (codigo == p.info.codigo)
                {
                    return p;
                }
                p = p.sgte;
            }
            return null;
        }

        public void Eliminar(NodoDoble actual)
        {
            if (actual == null || inicio == null)
            {
                return;
            }

            if (actual == inicio && actual == fin)
            {
                inicio = null;
                fin = null;
            }
            else if (actual == inicio)
            {
                inicio = actual.sgte;
                inicio.ant = null;
            }
            else if (actual == fin)
            {
                fin = actual.ant;
                fin.sgte = null;
            }
            else
            {
                actual.ant.sgte = actual.sgte;
                actual.sgte.ant = actual.ant;
            }
        }
    }
}
