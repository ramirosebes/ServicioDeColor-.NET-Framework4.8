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
using CapaPresentacion.Modales;

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
            //if (objUsuario == null)
            //{
            //    usuarioActual = new Usuario() { NombreCompleto = "ADMIN PREDEFINIDO", IdUsuario = 1 };
            //} else
            //{
            //    usuarioActual = objUsuario;
            //}

            usuarioActual = objUsuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //Mostrar o no Modulos por permisos
            //List<Permiso> listaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            //foreach (ToolStripMenuItem menu in menu.Items)
            //{
            //    //"m" es cada elemento que tiene la lista que trea de SQL.
            //    //m.nombreMenu trae los nombres de la base de datos y en menu.Name estan los nombres que yo coloco en el form Inicio como nombre de los MenuItem en la propiedad (name)
            //    //Y compara que sean iguales
            //    bool encontrado = listaPermisos.Any(m => m.NombreMenu == menu.Name);

            //    if (encontrado == false)
            //    {
            //        menu.Visible = false;
            //    }
            //}

            labelUsuario.Text = usuarioActual.NombreCompleto;
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

        private void subMenuUsuarios_Click(object sender, EventArgs e)
        {
            //abrirFormulario((ToolStripMenuItem) sender ,new frmUsuarios());
            abrirFormulario(menuSeguridad, new frmUsuarios());
        }

        private void subMenuGrupos_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuSeguridad, new frmGrupos());
        }

        private void subMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuVentas, new frmVentas(usuarioActual));
        }

        private void subMenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuVentas, new frmDetalleVenta());
        }

        private void subMenuClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuVentas, new frmClientes());
        }

        private void subMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmCompras(usuarioActual));
        }

        private void subMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmDetalleCompra());
        }

        private void subMenuCategorias_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmCategoria());
        }

        private void subMenuProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmProducto());
        }

        private void subMenuProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmProveedores());
        }

        private void subMenuReporteCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuReportes, new frmReporteCompras());
        }

        private void subMenuReporteVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuReportes, new frmReporteVentas());
        }

        private void datosDelNegocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuConfiguracion, new frmNegocio());
        }

        private void acerdaDeServicioDeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdAcercaDe md = new mdAcercaDe();
            md.ShowDialog();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Mensaje", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
