using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearchTree
{
    public partial class Form1 : Form
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //ATRIBUTOS DE LA CLASE
        BinaryTree arbol = new BinaryTree();


        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR DE LA CLASE
        public Form1()
        {
            InitializeComponent();
        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUTTON ADD CLICK
        private void bttonAdd_Click(object sender, EventArgs e)
        {
            Nodo nuevo = new Nodo(Convert.ToInt32(txtNumero.Text));
            arbol.Add(nuevo);
            txtNumero.Text = string.Empty;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUTTON PRE-ORDEN CLICK
        private void bttonPreOrden_Click(object sender, EventArgs e)
        {
            txtResultado.Text = arbol.PreOrden();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUTTON IN-ORDEN CLICK
        private void bttonInOrder_Click(object sender, EventArgs e)
        {
            txtResultado.Text = arbol.InOrder();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUTTON POST-ORDEN CLICK
        private void bttonPostOrden_Click(object sender, EventArgs e)
        {
            txtResultado.Text = arbol.PostOrden();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUTTON CONTAINS CLICK
        private void bttonContains_Click(object sender, EventArgs e)
        {
            Nodo nodo = new Nodo(Convert.ToInt32(txtBuscar.Text));

            if (arbol.Contains(nodo))
            {
                txtResultado.Text = "Ha sido encontrado";
            }
            else
                txtResultado.Text = "No se encontro";
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUTTON CONTAINS CLICK
        private void bttonCount_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(arbol.Count);
        }
    }
}
