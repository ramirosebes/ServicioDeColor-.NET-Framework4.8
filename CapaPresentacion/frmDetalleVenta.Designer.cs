﻿namespace CapaPresentacion
{
    partial class frmDetalleVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleVenta));
            this.buttonLimpiarBuscardor = new System.Windows.Forms.Button();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelDetalleVenta = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxTipoDocumento = new System.Windows.Forms.TextBox();
            this.labelTipoDocumento = new System.Windows.Forms.Label();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.labelFehca = new System.Windows.Forms.Label();
            this.textBoxNumeroDocumento = new System.Windows.Forms.TextBox();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.groupBoxInformacionVenta = new System.Windows.Forms.GroupBox();
            this.textBoxDocumentoCliente = new System.Windows.Forms.TextBox();
            this.labelMontoTotal = new System.Windows.Forms.Label();
            this.groupBoxInformacionCliente = new System.Windows.Forms.GroupBox();
            this.labelDocumentoCliente = new System.Windows.Forms.Label();
            this.labelNumeroDocumento = new System.Windows.Forms.Label();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.textBoxMontoTotal = new System.Windows.Forms.TextBox();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDetalleVenta = new System.Windows.Forms.Panel();
            this.textBoxMontoCambio = new System.Windows.Forms.TextBox();
            this.labelMontoCambio = new System.Windows.Forms.Label();
            this.textBoxMontoPago = new System.Windows.Forms.TextBox();
            this.labelMontoPago = new System.Windows.Forms.Label();
            this.groupBoxInformacionVenta.SuspendLayout();
            this.groupBoxInformacionCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.panelDetalleVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLimpiarBuscardor
            // 
            this.buttonLimpiarBuscardor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonLimpiarBuscardor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiarBuscardor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiarBuscardor.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiarBuscardor.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonLimpiarBuscardor.Image = global::CapaPresentacion.Properties.Resources.Escoba;
            this.buttonLimpiarBuscardor.Location = new System.Drawing.Point(742, 57);
            this.buttonLimpiarBuscardor.Name = "buttonLimpiarBuscardor";
            this.buttonLimpiarBuscardor.Size = new System.Drawing.Size(75, 30);
            this.buttonLimpiarBuscardor.TabIndex = 55;
            this.buttonLimpiarBuscardor.Text = "Limpiar";
            this.buttonLimpiarBuscardor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLimpiarBuscardor.UseVisualStyleBackColor = false;
            this.buttonLimpiarBuscardor.Click += new System.EventHandler(this.buttonLimpiarBuscardor_Click);
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBusqueda.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxBusqueda.Location = new System.Drawing.Point(455, 57);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(200, 30);
            this.textBoxBusqueda.TabIndex = 53;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonBuscar.Image = global::CapaPresentacion.Properties.Resources.Lupa;
            this.buttonBuscar.Location = new System.Drawing.Point(661, 57);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 30);
            this.buttonBuscar.TabIndex = 54;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelDetalleVenta
            // 
            this.labelDetalleVenta.AutoSize = true;
            this.labelDetalleVenta.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalleVenta.Location = new System.Drawing.Point(13, 12);
            this.labelDetalleVenta.Name = "labelDetalleVenta";
            this.labelDetalleVenta.Size = new System.Drawing.Size(161, 33);
            this.labelDetalleVenta.TabIndex = 1;
            this.labelDetalleVenta.Text = "Detalle de venta";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(372, 45);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.ReadOnly = true;
            this.textBoxUsuario.Size = new System.Drawing.Size(200, 27);
            this.textBoxUsuario.TabIndex = 7;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(368, 23);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(53, 19);
            this.labelUsuario.TabIndex = 6;
            this.labelUsuario.Text = "Usuario:";
            // 
            // textBoxTipoDocumento
            // 
            this.textBoxTipoDocumento.Location = new System.Drawing.Point(166, 45);
            this.textBoxTipoDocumento.Name = "textBoxTipoDocumento";
            this.textBoxTipoDocumento.ReadOnly = true;
            this.textBoxTipoDocumento.Size = new System.Drawing.Size(200, 27);
            this.textBoxTipoDocumento.TabIndex = 5;
            // 
            // labelTipoDocumento
            // 
            this.labelTipoDocumento.AutoSize = true;
            this.labelTipoDocumento.Location = new System.Drawing.Point(162, 23);
            this.labelTipoDocumento.Name = "labelTipoDocumento";
            this.labelTipoDocumento.Size = new System.Drawing.Size(109, 19);
            this.labelTipoDocumento.TabIndex = 4;
            this.labelTipoDocumento.Text = "Tipo de documento:";
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(10, 45);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(150, 27);
            this.textBoxFecha.TabIndex = 3;
            // 
            // labelFehca
            // 
            this.labelFehca.AutoSize = true;
            this.labelFehca.Location = new System.Drawing.Point(6, 23);
            this.labelFehca.Name = "labelFehca";
            this.labelFehca.Size = new System.Drawing.Size(44, 19);
            this.labelFehca.TabIndex = 2;
            this.labelFehca.Text = "Fecha:";
            // 
            // textBoxNumeroDocumento
            // 
            this.textBoxNumeroDocumento.Location = new System.Drawing.Point(742, 45);
            this.textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            this.textBoxNumeroDocumento.Size = new System.Drawing.Size(50, 27);
            this.textBoxNumeroDocumento.TabIndex = 7;
            this.textBoxNumeroDocumento.Visible = false;
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(216, 45);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.ReadOnly = true;
            this.textBoxNombreCliente.Size = new System.Drawing.Size(200, 27);
            this.textBoxNombreCliente.TabIndex = 5;
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Location = new System.Drawing.Point(212, 23);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(110, 19);
            this.labelNombreCliente.TabIndex = 4;
            this.labelNombreCliente.Text = "Nombre del cliente:";
            // 
            // groupBoxInformacionVenta
            // 
            this.groupBoxInformacionVenta.Controls.Add(this.textBoxUsuario);
            this.groupBoxInformacionVenta.Controls.Add(this.labelUsuario);
            this.groupBoxInformacionVenta.Controls.Add(this.textBoxTipoDocumento);
            this.groupBoxInformacionVenta.Controls.Add(this.labelTipoDocumento);
            this.groupBoxInformacionVenta.Controls.Add(this.textBoxFecha);
            this.groupBoxInformacionVenta.Controls.Add(this.labelFehca);
            this.groupBoxInformacionVenta.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformacionVenta.Location = new System.Drawing.Point(19, 97);
            this.groupBoxInformacionVenta.Name = "groupBoxInformacionVenta";
            this.groupBoxInformacionVenta.Size = new System.Drawing.Size(798, 84);
            this.groupBoxInformacionVenta.TabIndex = 58;
            this.groupBoxInformacionVenta.TabStop = false;
            this.groupBoxInformacionVenta.Text = "Informacion de la venta";
            // 
            // textBoxDocumentoCliente
            // 
            this.textBoxDocumentoCliente.Location = new System.Drawing.Point(10, 45);
            this.textBoxDocumentoCliente.Name = "textBoxDocumentoCliente";
            this.textBoxDocumentoCliente.ReadOnly = true;
            this.textBoxDocumentoCliente.Size = new System.Drawing.Size(200, 27);
            this.textBoxDocumentoCliente.TabIndex = 3;
            // 
            // labelMontoTotal
            // 
            this.labelMontoTotal.AutoSize = true;
            this.labelMontoTotal.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoTotal.Location = new System.Drawing.Point(15, 579);
            this.labelMontoTotal.Name = "labelMontoTotal";
            this.labelMontoTotal.Size = new System.Drawing.Size(84, 23);
            this.labelMontoTotal.TabIndex = 8;
            this.labelMontoTotal.Text = "Monto total:";
            // 
            // groupBoxInformacionCliente
            // 
            this.groupBoxInformacionCliente.Controls.Add(this.textBoxNumeroDocumento);
            this.groupBoxInformacionCliente.Controls.Add(this.textBoxNombreCliente);
            this.groupBoxInformacionCliente.Controls.Add(this.labelNombreCliente);
            this.groupBoxInformacionCliente.Controls.Add(this.textBoxDocumentoCliente);
            this.groupBoxInformacionCliente.Controls.Add(this.labelDocumentoCliente);
            this.groupBoxInformacionCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInformacionCliente.Location = new System.Drawing.Point(19, 187);
            this.groupBoxInformacionCliente.Name = "groupBoxInformacionCliente";
            this.groupBoxInformacionCliente.Size = new System.Drawing.Size(798, 84);
            this.groupBoxInformacionCliente.TabIndex = 59;
            this.groupBoxInformacionCliente.TabStop = false;
            this.groupBoxInformacionCliente.Text = "Informacion del cliente";
            // 
            // labelDocumentoCliente
            // 
            this.labelDocumentoCliente.AutoSize = true;
            this.labelDocumentoCliente.Location = new System.Drawing.Point(6, 23);
            this.labelDocumentoCliente.Name = "labelDocumentoCliente";
            this.labelDocumentoCliente.Size = new System.Drawing.Size(129, 19);
            this.labelDocumentoCliente.TabIndex = 2;
            this.labelDocumentoCliente.Text = "Numero de documento:";
            // 
            // labelNumeroDocumento
            // 
            this.labelNumeroDocumento.AutoSize = true;
            this.labelNumeroDocumento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNumeroDocumento.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.labelNumeroDocumento.Location = new System.Drawing.Point(320, 62);
            this.labelNumeroDocumento.Name = "labelNumeroDocumento";
            this.labelNumeroDocumento.Size = new System.Drawing.Size(129, 19);
            this.labelNumeroDocumento.TabIndex = 56;
            this.labelNumeroDocumento.Text = "Numero de documento:";
            // 
            // buttonExportar
            // 
            this.buttonExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(12)))), ((int)(((byte)(0)))));
            this.buttonExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportar.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonExportar.Location = new System.Drawing.Point(667, 576);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(150, 30);
            this.buttonExportar.TabIndex = 84;
            this.buttonExportar.Text = "Descargar PDF";
            this.buttonExportar.UseVisualStyleBackColor = false;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // textBoxMontoTotal
            // 
            this.textBoxMontoTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMontoTotal.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontoTotal.Location = new System.Drawing.Point(105, 579);
            this.textBoxMontoTotal.Name = "textBoxMontoTotal";
            this.textBoxMontoTotal.Size = new System.Drawing.Size(75, 27);
            this.textBoxMontoTotal.TabIndex = 8;
            this.textBoxMontoTotal.Text = "0.00";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewData.Location = new System.Drawing.Point(19, 277);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewData.Size = new System.Drawing.Size(798, 293);
            this.dataGridViewData.TabIndex = 60;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 305;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 150;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 150;
            // 
            // panelDetalleVenta
            // 
            this.panelDetalleVenta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDetalleVenta.Controls.Add(this.textBoxMontoCambio);
            this.panelDetalleVenta.Controls.Add(this.labelMontoCambio);
            this.panelDetalleVenta.Controls.Add(this.textBoxMontoPago);
            this.panelDetalleVenta.Controls.Add(this.buttonExportar);
            this.panelDetalleVenta.Controls.Add(this.labelMontoPago);
            this.panelDetalleVenta.Controls.Add(this.textBoxMontoTotal);
            this.panelDetalleVenta.Controls.Add(this.dataGridViewData);
            this.panelDetalleVenta.Controls.Add(this.labelMontoTotal);
            this.panelDetalleVenta.Controls.Add(this.groupBoxInformacionCliente);
            this.panelDetalleVenta.Controls.Add(this.groupBoxInformacionVenta);
            this.panelDetalleVenta.Controls.Add(this.buttonLimpiarBuscardor);
            this.panelDetalleVenta.Controls.Add(this.textBoxBusqueda);
            this.panelDetalleVenta.Controls.Add(this.buttonBuscar);
            this.panelDetalleVenta.Controls.Add(this.labelNumeroDocumento);
            this.panelDetalleVenta.Controls.Add(this.labelDetalleVenta);
            this.panelDetalleVenta.Location = new System.Drawing.Point(169, 12);
            this.panelDetalleVenta.Name = "panelDetalleVenta";
            this.panelDetalleVenta.Size = new System.Drawing.Size(835, 613);
            this.panelDetalleVenta.TabIndex = 1;
            // 
            // textBoxMontoCambio
            // 
            this.textBoxMontoCambio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMontoCambio.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontoCambio.Location = new System.Drawing.Point(466, 579);
            this.textBoxMontoCambio.Name = "textBoxMontoCambio";
            this.textBoxMontoCambio.Size = new System.Drawing.Size(75, 27);
            this.textBoxMontoCambio.TabIndex = 87;
            this.textBoxMontoCambio.Text = "0.00";
            // 
            // labelMontoCambio
            // 
            this.labelMontoCambio.AutoSize = true;
            this.labelMontoCambio.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoCambio.Location = new System.Drawing.Point(359, 579);
            this.labelMontoCambio.Name = "labelMontoCambio";
            this.labelMontoCambio.Size = new System.Drawing.Size(101, 23);
            this.labelMontoCambio.TabIndex = 88;
            this.labelMontoCambio.Text = "Monto cambio:";
            // 
            // textBoxMontoPago
            // 
            this.textBoxMontoPago.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMontoPago.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMontoPago.Location = new System.Drawing.Point(278, 579);
            this.textBoxMontoPago.Name = "textBoxMontoPago";
            this.textBoxMontoPago.Size = new System.Drawing.Size(75, 27);
            this.textBoxMontoPago.TabIndex = 85;
            this.textBoxMontoPago.Text = "0.00";
            // 
            // labelMontoPago
            // 
            this.labelMontoPago.AutoSize = true;
            this.labelMontoPago.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoPago.Location = new System.Drawing.Point(186, 579);
            this.labelMontoPago.Name = "labelMontoPago";
            this.labelMontoPago.Size = new System.Drawing.Size(86, 23);
            this.labelMontoPago.TabIndex = 86;
            this.labelMontoPago.Text = "Monto pago:";
            // 
            // frmDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1157, 637);
            this.Controls.Add(this.panelDetalleVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDetalleVenta";
            this.Text = "frmDetalleVenta";
            this.Load += new System.EventHandler(this.frmDetalleVenta_Load);
            this.groupBoxInformacionVenta.ResumeLayout(false);
            this.groupBoxInformacionVenta.PerformLayout();
            this.groupBoxInformacionCliente.ResumeLayout(false);
            this.groupBoxInformacionCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.panelDetalleVenta.ResumeLayout(false);
            this.panelDetalleVenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLimpiarBuscardor;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelDetalleVenta;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxTipoDocumento;
        private System.Windows.Forms.Label labelTipoDocumento;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label labelFehca;
        private System.Windows.Forms.TextBox textBoxNumeroDocumento;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.GroupBox groupBoxInformacionVenta;
        private System.Windows.Forms.TextBox textBoxDocumentoCliente;
        private System.Windows.Forms.Label labelMontoTotal;
        private System.Windows.Forms.GroupBox groupBoxInformacionCliente;
        private System.Windows.Forms.Label labelDocumentoCliente;
        private System.Windows.Forms.Label labelNumeroDocumento;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.TextBox textBoxMontoTotal;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Panel panelDetalleVenta;
        private System.Windows.Forms.TextBox textBoxMontoCambio;
        private System.Windows.Forms.Label labelMontoCambio;
        private System.Windows.Forms.TextBox textBoxMontoPago;
        private System.Windows.Forms.Label labelMontoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}