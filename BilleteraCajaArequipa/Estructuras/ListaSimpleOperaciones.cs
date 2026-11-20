using BilleteraCajaArequipa.Modelos;
using BilleteraCajaArequipa.Nodos;

namespace BilleteraCajaArequipa.Estructuras
{
    public class ListaSimpleOperaciones
    {
        public NodoSimple inicio;

        public NodoSimple RetornarUltimo()
        {
            NodoSimple p = inicio;
            while (p.sgte != null)
            {
                p = p.sgte;
            }
            return p;
        }

        public NodoSimple RetornarAnterior(NodoSimple x)
        {
            NodoSimple p = inicio;
            while (p.sgte != x)
            {
                p = p.sgte;
            }
            return p;
        }

        public void Adicionar(Operacion dato)
        {
            NodoSimple nuevo = new NodoSimple();
            nuevo.info = dato;
            nuevo.sgte = null;

            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                NodoSimple ult = RetornarUltimo();
                ult.sgte = nuevo;
            }
        }

        public int Contar()
        {
            NodoSimple p = inicio;
            int conta = 0;
            while (p != null)
            {
                conta = conta + 1;
                p = p.sgte;
            }
            return conta;
        }

        public NodoSimple Buscar(string codigo)
        {
            NodoSimple p = inicio;
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

        public void Eliminar(NodoSimple actual)
        {
            if (actual == null || inicio == null)
            {
                return;
            }

            if (actual == inicio)
            {
                inicio = actual.sgte;
            }
            else
            {
                NodoSimple ant = RetornarAnterior(actual);
                ant.sgte = actual.sgte;
            }
        }
    }
}
