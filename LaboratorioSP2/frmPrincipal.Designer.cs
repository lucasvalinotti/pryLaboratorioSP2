namespace LaboratorioSP2
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.gbDistancia = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.gbDias = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.lblPrecioNeto = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.gbDistancia.SuspendLayout();
            this.gbDias.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDistancia
            // 
            this.gbDistancia.Controls.Add(this.txtDistancia);
            this.gbDistancia.Controls.Add(this.lblDistancia);
            this.gbDistancia.Location = new System.Drawing.Point(58, 59);
            this.gbDistancia.Name = "gbDistancia";
            this.gbDistancia.Size = new System.Drawing.Size(238, 100);
            this.gbDistancia.TabIndex = 0;
            this.gbDistancia.TabStop = false;
            this.gbDistancia.Text = "Distancia";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(40, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(293, 37);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Organización Ferro";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(18, 45);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(51, 13);
            this.lblDistancia.TabIndex = 2;
            this.lblDistancia.Text = "Distancia";
            // 
            // gbDias
            // 
            this.gbDias.Controls.Add(this.txtDias);
            this.gbDias.Controls.Add(this.lblDias);
            this.gbDias.Location = new System.Drawing.Point(58, 165);
            this.gbDias.Name = "gbDias";
            this.gbDias.Size = new System.Drawing.Size(238, 100);
            this.gbDias.TabIndex = 3;
            this.gbDias.TabStop = false;
            this.gbDias.Text = "Dias de Estancia";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(99, 42);
            this.txtDias.MaxLength = 2;
            this.txtDias.Name = "txtDias";
            this.txtDias.ShortcutsEnabled = false;
            this.txtDias.Size = new System.Drawing.Size(133, 20);
            this.txtDias.TabIndex = 2;
            this.txtDias.Text = "1";
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDias_KeyPress);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(18, 45);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(75, 13);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "Dias (Máx. 30)";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(99, 42);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.ShortcutsEnabled = false;
            this.txtDistancia.Size = new System.Drawing.Size(133, 20);
            this.txtDistancia.TabIndex = 4;
            this.txtDistancia.Text = "0";
            this.txtDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistancia_KeyPress);
            // 
            // lblPrecioNeto
            // 
            this.lblPrecioNeto.AutoSize = true;
            this.lblPrecioNeto.Location = new System.Drawing.Point(88, 306);
            this.lblPrecioNeto.Name = "lblPrecioNeto";
            this.lblPrecioNeto.Size = new System.Drawing.Size(75, 13);
            this.lblPrecioNeto.TabIndex = 3;
            this.lblPrecioNeto.Text = "Precio Neto: $";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(88, 332);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(71, 13);
            this.lblDescuento.TabIndex = 4;
            this.lblDescuento.Text = "Descuento: $";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(88, 359);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total: $";
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Location = new System.Drawing.Point(133, 271);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(75, 23);
            this.cmdCalcular.TabIndex = 6;
            this.cmdCalcular.Text = "Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 390);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblPrecioNeto);
            this.Controls.Add(this.gbDias);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbDistancia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferro";
            this.gbDistancia.ResumeLayout(false);
            this.gbDistancia.PerformLayout();
            this.gbDias.ResumeLayout(false);
            this.gbDias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDistancia;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbDias;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblPrecioNeto;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button cmdCalcular;
    }
}

