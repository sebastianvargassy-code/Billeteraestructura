using BilleteraCajaArequipa.Modelos;
using BilleteraCajaArequipa.Nodos;

namespace BilleteraCajaArequipa.Estructuras
{
    public class PilaOperaciones
    {
        public NodoSimple cima;

        public void Poner(Operacion dato)
        {
            NodoSimple nuevo = new NodoSimple();
            nuevo.info = dato;
            nuevo.sgte = cima;
            cima = nuevo;
        }

        public Operacion Sacar()
        {
            if (cima == null)
            {
                return null;
            }

            Operacion aux = cima.info;
            cima = cima.sgte;
            return aux;
        }

        public Operacion VerTope()
        {
            if (cima == null)
            {
                return null;
            }
            return cima.info;
        }

        public bool EstaVacia()
        {
            return cima == null;
        }

        public int Contar()
        {
            NodoSimple p = cima;
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
