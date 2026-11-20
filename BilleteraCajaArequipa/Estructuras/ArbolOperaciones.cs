using System;
using BilleteraCajaArequipa.Modelos;
using BilleteraCajaArequipa.Nodos;

namespace BilleteraCajaArequipa.Estructuras
{
    public class ArbolOperaciones
    {
        public NodoArbol raiz;

        private int Comparar(string a, string b)
        {
            int numA, numB;
            if (int.TryParse(a, out numA) && int.TryParse(b, out numB))
            {
                return numA.CompareTo(numB);
            }
            return string.Compare(a, b);
        }

        public void Insertar(Operacion dato)
        {
            NodoArbol nuevo = new NodoArbol();
            nuevo.info = dato;
            nuevo.izq = null;
            nuevo.der = null;

            if (raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                NodoArbol actual = raiz;
                NodoArbol padre = null;

                while (actual != null)
                {
                    padre = actual;
                    int cmp = Comparar(dato.codigo, actual.info.codigo);
                    if (cmp == 0)
                    {
                        return;
                    }
                    if (cmp < 0)
                    {
                        actual = actual.izq;
                    }
                    else
                    {
                        actual = actual.der;
                    }
                }

                if (Comparar(dato.codigo, padre.info.codigo) < 0)
                {
                    padre.izq = nuevo;
                }
                else
                {
                    padre.der = nuevo;
                }
            }
        }

        public NodoArbol Buscar(string codigo)
        {
            NodoArbol p = raiz;
            while (p != null)
            {
                int cmp = Comparar(codigo, p.info.codigo);
                if (cmp == 0)
                {
                    return p;
                }
                if (cmp < 0)
                {
                    p = p.izq;
                }
                else
                {
                    p = p.der;
                }
            }
            return null;
        }

        public void Eliminar(string codigo)
        {
            raiz = EliminarNodo(raiz, codigo);
        }

        private NodoArbol EliminarNodo(NodoArbol p, string codigo)
        {
            if (p == null)
            {
                return null;
            }

            int cmp = Comparar(codigo, p.info.codigo);
            if (cmp < 0)
            {
                p.izq = EliminarNodo(p.izq, codigo);
            }
            else if (cmp > 0)
            {
                p.der = EliminarNodo(p.der, codigo);
            }
            else
            {
                if (p.izq == null)
                {
                    return p.der;
                }
                if (p.der == null)
                {
                    return p.izq;
                }

                NodoArbol sucesor = p.der;
                while (sucesor.izq != null)
                {
                    sucesor = sucesor.izq;
                }
                p.info = sucesor.info;
                p.der = EliminarNodo(p.der, sucesor.info.codigo);
            }
            return p;
        }

        public int Contar()
        {
            return ContarNodos(raiz);
        }

        private int ContarNodos(NodoArbol p)
        {
            if (p == null)
            {
                return 0;
            }
            return 1 + ContarNodos(p.izq) + ContarNodos(p.der);
        }
    }
}
