﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CapaEntidad;
using CapaPresentacion.Modales;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmCompras : Form
    {
        private Usuario _Usuario;

        public frmCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            comboBoxTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            comboBoxTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            comboBoxTipoDocumento.DisplayMember = "Texto";
            comboBoxTipoDocumento.ValueMember = "Valor";
            comboBoxTipoDocumento.SelectedIndex = 0;

            textBoxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            textBoxIdProveedor.Text = "0";
            textBoxIdProducto.Text = "0";
        }

        private void buttonBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    textBoxIdProveedor.Text = modal._Proveedor.IdProveedor.ToString();
                    textBoxDocumentoProveedor.Text = modal._Proveedor.Documento;
                    textBoxRazonSocial.Text = modal._Proveedor.RazonSocial; //textBoxNombreProveedor
                }
                else
                {
                    textBoxDocumentoProveedor.Select();
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
                    textBoxPrecioCompra.Select();
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
                    textBoxPrecioCompra.Select();
                }
                else
                {
                    textBoxCodigoProducto.BackColor = Color.FromArgb(254, 61, 78);
                    textBoxIdProducto.Text = "0";
                    textBoxProducto.Text = "";
                }
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            decimal precioCompra = 0;
            decimal precioVenta = 0;
            bool productoExiste = false;

            if (int.Parse(textBoxIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(textBoxPrecioCompra.Text, out precioCompra))
            {
                MessageBox.Show("Precio compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxPrecioCompra.Select();
                return;
            }

            if (!decimal.TryParse(textBoxPrecioVenta.Text, out precioVenta))
            {
                MessageBox.Show("Precio venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxPrecioVenta.Select();
                return;
            }

            //Este foreach debe estar arriba de  if (!productoExiste), si no retornara null la fila.
            //Si coloco en el if (fila != null && fila.Cells["IdProducto"].Value != null && fila.Cells["IdProducto"].Value.ToString() == textBoxIdProducto.Text) puedo dejar el foreach arriba
            //Si coloco en el if (fila.Cells["IdProducto"].Value.ToString() == textBoxIdProducto.Text) debo colocar el foreach abajo
            foreach (DataGridViewRow fila in dataGridViewData.Rows)
            {
                //CODIGO ESTUDIANTE
                if (fila.Cells["IdProducto"].Value.ToString() == textBoxIdProducto.Text)
                {
                    productoExiste = true;
                    break;
                }

                //CHAT GPT
                //if (fila != null && fila.Cells["IdProducto"].Value != null && fila.Cells["IdProducto"].Value.ToString() == textBoxIdProducto.Text)
                //{
                //    productoExiste = true;
                //    break;
                //}
            }

            //Esta validacion debe estar arriba de foreach (DataGridViewRow fila in dataGridViewData.Rows), si no retornara null la fila
            if (!productoExiste)
            {
                dataGridViewData.Rows.Add(new object[]
                {
                    textBoxIdProducto.Text,
                    textBoxProducto.Text,
                    precioCompra.ToString("0.00"),
                    precioVenta.ToString("0.00"),
                    numericUpDownCantidad.Value.ToString(),
                    (numericUpDownCantidad.Value * precioCompra).ToString("0.00")
                });

                calcularTotal();
                limpiarProducto();
                textBoxCodigoProducto.Select();
            }
        }

        private void limpiarProducto()
        {
            textBoxIdProducto.Text = "0";
            textBoxCodigoProducto.Text = "";
            textBoxCodigoProducto.BackColor = Color.White;
            textBoxProducto.Text = "";
            textBoxPrecioCompra.Text = "";
            textBoxPrecioVenta.Text = "";
            numericUpDownCantidad.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;

            if (dataGridViewData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewData.Rows)
                {
                    //CODIGO ESTUDIANTE
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString()); //--> No funcionaba ya que lo toma como null, de una para otras funciona

                    //CHAT GPT
                    //if (row != null && row.Cells["SubTotal"].Value != null)
                    //{
                    //    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                    //}
                }
                textBoxTotalAPagar.Text = total.ToString("0.00");
            }
            else if (dataGridViewData.Rows.Count == 0) //Esto lo agregue yo
            {
                total = 0;
                textBoxTotalAPagar.Text = total.ToString("0.00");
            }
        }

        private void dataGridViewData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.Papelera.Width;
                var h = Properties.Resources.Papelera.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Papelera, new Rectangle(x, y, w, h));
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

        private void textBoxPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CODIGO ESTUDIANTE
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    if (textBoxPrecioCompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
            //    {
            //        e.Handled = true;
            //    }
            //    else
            //    {
            //        if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
            //        {
            //            e.Handled = false;
            //        }
            //        else
            //        {
            //             e.Handled = true;
            //        }
            //    }
            //}

            //CHAT GPT
            if (Char.IsDigit(e.KeyChar))
            {
                // Permitir dígitos
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && textBoxPrecioCompra.Text.Length > 0 && !textBoxPrecioCompra.Text.Contains("."))
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

        private void textBoxPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CODIGO ESTUDIANTE
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    if (textBoxPrecioVenta.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
            //    {
            //        e.Handled = true;
            //    }
            //    else
            //    {
            //        if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
            //        {
            //            e.Handled = false;
            //        }
            //        else
            //        {
            //             e.Handled = true;
            //        }
            //    }
            //}

            //CHAT GPT
            if (Char.IsDigit(e.KeyChar))
            {
                // Permitir dígitos
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && textBoxPrecioVenta.Text.Length > 0 && !textBoxPrecioVenta.Text.Contains("."))
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

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxIdProveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dataGridViewData.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalleCompra = new DataTable();

            detalleCompra.Columns.Add("IdProducto", typeof(int));
            detalleCompra.Columns.Add("PrecioCompra", typeof(decimal));
            detalleCompra.Columns.Add("PrecioVenta", typeof(decimal));
            detalleCompra.Columns.Add("Cantidad", typeof(int));
            detalleCompra.Columns.Add("MontoTotal", typeof(decimal));

            foreach (DataGridViewRow row in dataGridViewData.Rows)
            {
                detalleCompra.Rows.Add (
                    new object[]
                    {
                        Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()), //No hace falta el Convert.ToInt32
                        row.Cells["PrecioCompra"].Value.ToString(),
                        row.Cells["PrecioVenta"].Value.ToString(),
                        row.Cells["Cantidad"].Value.ToString(),
                        row.Cells["SubTotal"].Value.ToString()
                    });
            }

            int idCorrelativo = new CN_Compra().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idCorrelativo);

            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(textBoxIdProveedor.Text) },
                TipoDocumento = ((OpcionCombo)comboBoxTipoDocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                MontoTotal = Convert.ToDecimal(textBoxTotalAPagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCompra, detalleCompra, out mensaje);

            if(respuesta)
            {
                var result = MessageBox.Show("Numero de compra generado:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(numeroDocumento);
                }

                textBoxIdProveedor.Text = "0";
                textBoxDocumentoProveedor.Clear();
                textBoxRazonSocial.Clear();
                dataGridViewData.Rows.Clear();
                calcularTotal();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
