﻿namespace BinarySearchTree
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.bttonAdd = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.bttonContains = new System.Windows.Forms.Button();
            this.bttonPreOrder = new System.Windows.Forms.Button();
            this.bttonCount = new System.Windows.Forms.Button();
            this.bttonInOrder = new System.Windows.Forms.Button();
            this.bttonPostOrder = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(12, 12);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 26);
            this.txtNumero.TabIndex = 0;
            // 
            // bttonAdd
            // 
            this.bttonAdd.AutoSize = true;
            this.bttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonAdd.Location = new System.Drawing.Point(13, 44);
            this.bttonAdd.Name = "bttonAdd";
            this.bttonAdd.Size = new System.Drawing.Size(99, 30);
            this.bttonAdd.TabIndex = 1;
            this.bttonAdd.Text = "Add";
            this.bttonAdd.UseVisualStyleBackColor = true;
            this.bttonAdd.Click += new System.EventHandler(this.bttonAdd_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(13, 200);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(224, 26);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TabStop = false;
            // 
            // bttonContains
            // 
            this.bttonContains.AutoSize = true;
            this.bttonContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonContains.Location = new System.Drawing.Point(13, 128);
            this.bttonContains.Name = "bttonContains";
            this.bttonContains.Size = new System.Drawing.Size(99, 30);
            this.bttonContains.TabIndex = 3;
            this.bttonContains.Text = "Buscar";
            this.bttonContains.UseVisualStyleBackColor = true;
            this.bttonContains.Click += new System.EventHandler(this.bttonContains_Click);
            // 
            // bttonPreOrder
            // 
            this.bttonPreOrder.AutoSize = true;
            this.bttonPreOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonPreOrder.Location = new System.Drawing.Point(133, 10);
            this.bttonPreOrder.Name = "bttonPreOrder";
            this.bttonPreOrder.Size = new System.Drawing.Size(104, 30);
            this.bttonPreOrder.TabIndex = 5;
            this.bttonPreOrder.Text = "PreOrder";
            this.bttonPreOrder.UseVisualStyleBackColor = true;
            this.bttonPreOrder.Click += new System.EventHandler(this.bttonPreOrder_Click);
            // 
            // bttonCount
            // 
            this.bttonCount.AutoSize = true;
            this.bttonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonCount.Location = new System.Drawing.Point(13, 82);
            this.bttonCount.Name = "bttonCount";
            this.bttonCount.Size = new System.Drawing.Size(99, 30);
            this.bttonCount.TabIndex = 2;
            this.bttonCount.Text = "Count";
            this.bttonCount.UseVisualStyleBackColor = true;
            this.bttonCount.Click += new System.EventHandler(this.bttonCount_Click);
            // 
            // bttonInOrder
            // 
            this.bttonInOrder.AutoSize = true;
            this.bttonInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonInOrder.Location = new System.Drawing.Point(133, 46);
            this.bttonInOrder.Name = "bttonInOrder";
            this.bttonInOrder.Size = new System.Drawing.Size(104, 30);
            this.bttonInOrder.TabIndex = 6;
            this.bttonInOrder.Text = "InOrder";
            this.bttonInOrder.UseVisualStyleBackColor = true;
            this.bttonInOrder.Click += new System.EventHandler(this.bttonInOrder_Click);
            // 
            // bttonPostOrder
            // 
            this.bttonPostOrder.AutoSize = true;
            this.bttonPostOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonPostOrder.Location = new System.Drawing.Point(133, 82);
            this.bttonPostOrder.Name = "bttonPostOrder";
            this.bttonPostOrder.Size = new System.Drawing.Size(104, 30);
            this.bttonPostOrder.TabIndex = 7;
            this.bttonPostOrder.Text = "PostOrder";
            this.bttonPostOrder.UseVisualStyleBackColor = true;
            this.bttonPostOrder.Click += new System.EventHandler(this.bttonPostOrder_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(133, 130);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(40, 26);
            this.txtBuscar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 251);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.bttonCount);
            this.Controls.Add(this.bttonContains);
            this.Controls.Add(this.bttonPostOrder);
            this.Controls.Add(this.bttonInOrder);
            this.Controls.Add(this.bttonPreOrder);
            this.Controls.Add(this.bttonAdd);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button bttonAdd;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button bttonContains;
        private System.Windows.Forms.Button bttonPreOrder;
        private System.Windows.Forms.Button bttonCount;
        private System.Windows.Forms.Button bttonInOrder;
        private System.Windows.Forms.Button bttonPostOrder;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}

