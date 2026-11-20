using BilleteraCajaArequipa.Modelos;
using BilleteraCajaArequipa.Nodos;

namespace BilleteraCajaArequipa.Estructuras
{
    public class ColaOperaciones
    {
        public NodoSimple frente;
        public NodoSimple final;

        public void Adicionar(Operacion dato)
        {
            NodoSimple nuevo = new NodoSimple();
            nuevo.info = dato;
            nuevo.sgte = null;

            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.sgte = nuevo;
                final = nuevo;
            }
        }

        public Operacion Atender()
        {
            if (frente == null)
            {
                return null;
            }

            Operacion aux = frente.info;
            frente = frente.sgte;

            if (frente == null)
            {
                final = null;
            }

            return aux;
        }

        public Operacion VerFrente()
        {
            if (frente == null)
            {
                return null;
            }
            return frente.info;
        }

        public bool EstaVacia()
        {
            return frente == null;
        }

        public int Contar()
        {
            NodoSimple p = frente;
            int conta = 0;
            while (p != null)
            {
                conta = conta + 1;
                p = p.sgte;
            }
            return conta;
        }
    }
}
