using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //ATRIBUTOS DE LA CLASE
        private Nodo _raiz;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //PROPIEDADES DE LA CLASE
        private int _count;
        public int Count { get { return _count; } }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR DE LA CLASE
        public BinaryTree()
        {
            this._raiz = null;
            this._count = 0;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO ADD
        public void Add(Nodo nuevo)
        {
            if (_raiz == null)
                _raiz = nuevo;
            else
                Add(nuevo, _raiz);

            _count++;
        }
        private void Add(Nodo nuevo, Nodo raiz)
        {
            if (nuevo.Valor < raiz.Valor)
            {
                if (raiz.H_left == null)
                    raiz.H_left = nuevo;
                else
                    Add(nuevo, raiz.H_left);
            }
            else //if (nuevo.Valor > raiz.Valor)
            {
                if (raiz.H_right == null)
                    raiz.H_right = nuevo;
                else
                    Add(nuevo, raiz.H_right);
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO CONTAINS
        public bool Contains(Nodo nodo)
        {
            if (_raiz == null)
                return false;
            else
            {
                return Contains(nodo, _raiz) == true;
            }
        }
        private bool Contains(Nodo nodo, Nodo raiz)
        {
            bool res = false;

            if (raiz != null)
            {
                if (nodo.Valor != raiz.Valor)
                {
                    if (nodo.Valor < raiz.Valor)
                        res = Contains(nodo, raiz.H_left);
                    else
                        res = Contains(nodo, raiz.H_right);
                }
                else
                    res = true;
            }
            return res;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO PRE-ORDER
        public string PreOrder()
        {
            if (_raiz != null)
                return PreOrder(_raiz);

            return string.Empty;
        }
        private string PreOrder(Nodo raiz)
        {
            string res = string.Empty;

            if(raiz != null)
            {
                res += raiz.ToString();

                if (raiz.H_left != null)
                    res += PreOrder(raiz.H_left);

                if (raiz.H_right != null)
                    res += PreOrder(raiz.H_right);
            }
            return res;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO IN-ORDER
        public string InOrder()
        {
            if (_raiz != null)
                return InOrder(_raiz);

            return string.Empty;
        }
        private string InOrder(Nodo raiz)
        {
            string res = string.Empty;

            if(raiz != null)
            {
                if (raiz.H_left != null)
                    res += InOrder(raiz.H_left);

                res += raiz.ToString();

                if (raiz.H_right != null)
                    res += InOrder(raiz.H_right);
            }
            return res;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO POST-ORDER
        public string PostOrder()
        {
            if (_raiz != null)
                return PostOrder(_raiz);

            return string.Empty;
        }
        private string PostOrder(Nodo raiz)
        {
            string res = string.Empty;

            if(raiz != null)
            {
                if (raiz.H_left != null)
                    res += PostOrder(raiz.H_left);

                if (raiz.H_right != null)
                    res += PostOrder(raiz.H_right);

                res += raiz.ToString();
            }
            return res;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO CLEAR
        public void Clear()
        {
            _raiz = null;
            _count = 0;
        }
    }
}
