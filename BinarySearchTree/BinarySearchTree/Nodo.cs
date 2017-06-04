﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Nodo
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //PROPIEDADES DE LA CLASE
        private int _valor;
        public int Valor { get { return _valor; } }

        private Nodo _h_left;
        public Nodo H_left { get { return _h_left; } set { _h_left = value; } }

        private Nodo _h_right;
        public Nodo H_right { get { return _h_right; } set { _h_right = value; } }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR DE LA CLASE
        public Nodo(int valor)
        {
            this._valor = valor;
            this._h_left = null;
            this._h_right = null;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO TO STRING 
        public override string ToString()
        {
            return Convert.ToInt32(_valor) + " ";
        }
    }
}
