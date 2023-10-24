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
using CapaPresentacion.Modales;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmVentas : Form
    {
        private Usuario _Usuario;

        public frmVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            comboBoxTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            comboBoxTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            comboBoxTipoDocumento.DisplayMember = "Texto";
            comboBoxTipoDocumento.ValueMember = "Valor";
            comboBoxTipoDocumento.SelectedIndex = 0;

            textBoxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textBoxIdProducto.Text = "0";

            textBoxPagaCon.Text = "";
            textBoxCambio.Text = "";
            textBoxTotalAPagar.Text= "0.00";
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    textBoxDocumentoCliente.Text = modal._Cliente.Documento;
                    textBoxNombreCompleto.Text = modal._Cliente.NombreCompleto; //textBoxNombreCliente
                    textBoxCodigoProducto.Select();
                }
                else
                {
                    textBoxDocumentoCliente.Select();
                }
            }
        }

        private void buttonBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    textBoxIdProducto.Text = modal._Producto.IdProducto.ToString();
                    textBoxCodigoProducto.Text = modal._Producto.Codigo;
                    textBoxProducto.Text = modal._Producto.Nombre;
                    textBoxPrecio.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    textBoxStock.Text = modal._Producto.Stock.ToString();
                    numericUpDownCantidad.Select();
                }
                else
                {
                    textBoxCodigoProducto.Select();
                }
            }
        }

        private void textBoxCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == textBoxCodigoProducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    textBoxCodigoProducto.BackColor = Color.FromArgb(45, 204, 112);
                    textBoxIdProducto.Text = oProducto.IdProducto.ToString();
                    textBoxProducto.Text = oProducto.Nombre;
                    textBoxPrecio.Text = oProducto.PrecioVenta.ToString("0.00");
                    textBoxStock.Text = oProducto.Stock.ToString();
                    numericUpDownCantidad.Select();
                }
                else
                {
                    textBoxCodigoProducto.BackColor = Color.FromArgb(254, 61, 78);
                    textBoxIdProducto.Text = "0";
                    textBoxProducto.Text = "";
                    textBoxPrecio.Text = "";
                    textBoxStock.Text = "";
                    numericUpDownCantidad.Value = 1;
                }
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool productoExiste = false;

            if (int.Parse(textBoxIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(textBoxPrecio.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxPrecio.Select();
                return;
            }

            if (Convert.ToInt32(textBoxStock.Text) < Convert.ToInt32(numericUpDownCantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puese ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow fila in dataGridViewData.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == textBoxIdProducto.Text)
                {
                    productoExiste = true;
                    break;
                }
            }

            if (!productoExiste)
            {
                dataGridViewData.Rows.Add(new object[]
                {
                    textBoxIdProducto.Text,
                    textBoxProducto.Text,
                    precio.ToString("0.00"),
                    numericUpDownCantidad.Value.ToString(),
                    (numericUpDownCantidad.Value * precio).ToString("0.00")
                });

                calcularTotal();
                limpiarProducto();
                textBoxCodigoProducto.Select();
            }
        }

        private void calcularTotal()
        {
            decimal total = 0;

            if (dataGridViewData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewData.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }
                textBoxTotalAPagar.Text = total.ToString("0.00");
            }
            else if (dataGridViewData.Rows.Count == 0) //Esto lo agregue yo
            {
                total = 0;
                textBoxTotalAPagar.Text = total.ToString("0.00");
            }
        }

        private void limpiarProducto()
        {
            textBoxIdProducto.Text = "0";
            textBoxCodigoProducto.Text = "";
            textBoxCodigoProducto.BackColor = Color.White;
            textBoxProducto.Text = "";
            textBoxPrecio.Text = "";
            textBoxStock.Text = "";
            numericUpDownCantidad.Value = 1;
        }

        private void dataGridViewData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.Trashcan2.Width;
                var h = Properties.Resources.Trashcan2.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Trashcan2, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewData.Columns[e.ColumnIndex].Name == "buttonEliminar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    dataGridViewData.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                // Permitir dígitos
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && textBoxPrecio.Text.Length > 0 && !textBoxPrecio.Text.Contains("."))
            {
                // Permitir un punto si hay al menos un número y no hay punto previamente
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                // Permitir teclas de control como retroceso
                e.Handled = false;
            }
            else
            {
                // Bloquear cualquier otro carácter
                e.Handled = true;
            }
        }

        private void textBoxPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                // Permitir dígitos
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && textBoxPagaCon.Text.Length > 0 && !textBoxPagaCon.Text.Contains("."))
            {
                // Permitir un punto si hay al menos un número y no hay punto previamente
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                // Permitir teclas de control como retroceso
                e.Handled = false;
            }
            else
            {
                // Bloquear cualquier otro carácter
                e.Handled = true;
            }
        }

        private void calcularCambio()
        {
            if (textBoxTotalAPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagaCon;
            decimal total = Convert.ToDecimal(textBoxTotalAPagar.Text);

            if (textBoxPagaCon.Text.Trim() == "")
            {
                textBoxPagaCon.Text = "0.00";
            }

            if (decimal.TryParse(textBoxPagaCon.Text.Trim(), out pagaCon))
            {
                if (pagaCon < total)
                {
                    textBoxCambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagaCon - total;
                    textBoxCambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void textBoxPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                calcularCambio();
            }
        }
    }
}
