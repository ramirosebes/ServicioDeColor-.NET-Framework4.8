﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static ToolStripMenuItem menuActivo = null;
        private static Form formularioActivo;

        public Inicio(Usuario objUsuario = null)
        {
            //Permite registrarse con un usuario nulo para no estar poniendo las credenciales todo el tiempo
            if (objUsuario == null)
            {
                usuarioActual = new Usuario() { nombreCompleto = "ADMIN PREDEFINIDO", idUsuario = 1 };
            } else
            {
                usuarioActual = objUsuario;
            }

            //usuarioActual = objUsuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> listaPermisos = new CNPermiso().Listar(usuarioActual.idUsuario);

            foreach (ToolStripMenuItem menu in menu.Items)
            {
                //"m" es cada elemento que tiene la lista que trea de SQL.
                //m.nombreMenu trae los nombres de la base de datos y en menu.Name estan los nombres que yo coloco en el form Inicio como nombre de los MenuItem en la propiedad (name)
                //Y compara que sean iguales
                bool encontrado = listaPermisos.Any(m => m.nombreMenu == menu.Name);

                if (encontrado == false)
                {
                    menu.Visible = false;
                }
            }

            labelUsuario.Text = usuarioActual.nombreCompleto;
        }

        private void abrirFormulario(ToolStripMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            //formulario.BackColor = Color.FromArgb(45, 204, 112);
            //formulario.BackColor = Color.White; //Color de fondo del formulario al abrirlo
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuUsuario_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem) sender ,new frmUsuarios());
            //abrirFormulario(menuUsuarios, new frmCategoria()); //Es lo mismo que arriba pero de otra forma
        }

        private void subMenuCategoria_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuMantenedor, new frmCategoria());
        }

        private void subMenuProducto_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuMantenedor, new frmProducto());
        }

        private void subMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuVentas, new frmVentas());
        }

        private void subMenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuVentas, new frmDetalleVenta());
        }

        private void subMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmCompras());
        }

        private void subMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmDetalleCompra());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new frmClientes());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new frmProveedores());
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new frmReportes());
        }
    }
}
