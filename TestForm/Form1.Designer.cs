namespace TestForm
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
			this.PanelContenedor = new System.Windows.Forms.Panel();
			this.BtnImportar = new System.Windows.Forms.Button();
			this.BtnExportar = new System.Windows.Forms.Button();
			this.TbLink = new System.Windows.Forms.TextBox();
			this.TbParametros = new System.Windows.Forms.TextBox();
			this.NupConsultas = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.TbTiempo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.BtnParar = new System.Windows.Forms.Button();
			this.BtnIniciar = new System.Windows.Forms.Button();
			this.LbConsultas = new System.Windows.Forms.Label();
			this.TbRespuesta = new System.Windows.Forms.TextBox();
			this.CbMetodoConsulta = new System.Windows.Forms.ComboBox();
			this.TablaParametros = new System.Windows.Forms.DataGridView();
			this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Aleatorio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.TbURL = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PanelContenedor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NupConsultas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TablaParametros)).BeginInit();
			this.SuspendLayout();
			// 
			// PanelContenedor
			// 
			this.PanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PanelContenedor.Controls.Add(this.BtnImportar);
			this.PanelContenedor.Controls.Add(this.BtnExportar);
			this.PanelContenedor.Controls.Add(this.TbLink);
			this.PanelContenedor.Controls.Add(this.TbParametros);
			this.PanelContenedor.Controls.Add(this.NupConsultas);
			this.PanelContenedor.Controls.Add(this.label3);
			this.PanelContenedor.Controls.Add(this.TbTiempo);
			this.PanelContenedor.Controls.Add(this.label2);
			this.PanelContenedor.Controls.Add(this.BtnParar);
			this.PanelContenedor.Controls.Add(this.BtnIniciar);
			this.PanelContenedor.Controls.Add(this.LbConsultas);
			this.PanelContenedor.Controls.Add(this.TbRespuesta);
			this.PanelContenedor.Controls.Add(this.CbMetodoConsulta);
			this.PanelContenedor.Controls.Add(this.TablaParametros);
			this.PanelContenedor.Controls.Add(this.TbURL);
			this.PanelContenedor.Controls.Add(this.label1);
			this.PanelContenedor.Location = new System.Drawing.Point(12, 12);
			this.PanelContenedor.Name = "PanelContenedor";
			this.PanelContenedor.Size = new System.Drawing.Size(860, 576);
			this.PanelContenedor.TabIndex = 0;
			// 
			// BtnImportar
			// 
			this.BtnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnImportar.Location = new System.Drawing.Point(203, 544);
			this.BtnImportar.Name = "BtnImportar";
			this.BtnImportar.Size = new System.Drawing.Size(190, 29);
			this.BtnImportar.TabIndex = 15;
			this.BtnImportar.Text = "Importar configuración";
			this.BtnImportar.UseVisualStyleBackColor = true;
			this.BtnImportar.Click += new System.EventHandler(this.BtnImportar_Click);
			// 
			// BtnExportar
			// 
			this.BtnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnExportar.Location = new System.Drawing.Point(7, 544);
			this.BtnExportar.Name = "BtnExportar";
			this.BtnExportar.Size = new System.Drawing.Size(190, 29);
			this.BtnExportar.TabIndex = 14;
			this.BtnExportar.Text = "Exportar configuración";
			this.BtnExportar.UseVisualStyleBackColor = true;
			this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
			// 
			// TbLink
			// 
			this.TbLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TbLink.Location = new System.Drawing.Point(7, 321);
			this.TbLink.Multiline = true;
			this.TbLink.Name = "TbLink";
			this.TbLink.ReadOnly = true;
			this.TbLink.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TbLink.Size = new System.Drawing.Size(850, 59);
			this.TbLink.TabIndex = 13;
			// 
			// TbParametros
			// 
			this.TbParametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TbParametros.Location = new System.Drawing.Point(551, 85);
			this.TbParametros.Multiline = true;
			this.TbParametros.Name = "TbParametros";
			this.TbParametros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TbParametros.Size = new System.Drawing.Size(306, 221);
			this.TbParametros.TabIndex = 12;
			// 
			// NupConsultas
			// 
			this.NupConsultas.Location = new System.Drawing.Point(425, 46);
			this.NupConsultas.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
			this.NupConsultas.Name = "NupConsultas";
			this.NupConsultas.Size = new System.Drawing.Size(162, 26);
			this.NupConsultas.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(256, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(163, 20);
			this.label3.TabIndex = 10;
			this.label3.Text = "Número de consultas:";
			// 
			// TbTiempo
			// 
			this.TbTiempo.Location = new System.Drawing.Point(109, 48);
			this.TbTiempo.Name = "TbTiempo";
			this.TbTiempo.Size = new System.Drawing.Size(100, 26);
			this.TbTiempo.TabIndex = 9;
			this.TbTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTiempo_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "Tiempo (ms):";
			// 
			// BtnParar
			// 
			this.BtnParar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnParar.Location = new System.Drawing.Point(701, 544);
			this.BtnParar.Name = "BtnParar";
			this.BtnParar.Size = new System.Drawing.Size(75, 29);
			this.BtnParar.TabIndex = 7;
			this.BtnParar.Text = "Parar";
			this.BtnParar.UseVisualStyleBackColor = true;
			this.BtnParar.Click += new System.EventHandler(this.BtnParar_Click);
			// 
			// BtnIniciar
			// 
			this.BtnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnIniciar.Location = new System.Drawing.Point(782, 544);
			this.BtnIniciar.Name = "BtnIniciar";
			this.BtnIniciar.Size = new System.Drawing.Size(75, 29);
			this.BtnIniciar.TabIndex = 6;
			this.BtnIniciar.Text = "Iniciar";
			this.BtnIniciar.UseVisualStyleBackColor = true;
			this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
			// 
			// LbConsultas
			// 
			this.LbConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LbConsultas.AutoSize = true;
			this.LbConsultas.Location = new System.Drawing.Point(3, 501);
			this.LbConsultas.Name = "LbConsultas";
			this.LbConsultas.Size = new System.Drawing.Size(84, 20);
			this.LbConsultas.TabIndex = 5;
			this.LbConsultas.Text = "Cunsultas:";
			// 
			// TbRespuesta
			// 
			this.TbRespuesta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TbRespuesta.Location = new System.Drawing.Point(7, 395);
			this.TbRespuesta.Multiline = true;
			this.TbRespuesta.Name = "TbRespuesta";
			this.TbRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TbRespuesta.Size = new System.Drawing.Size(850, 103);
			this.TbRespuesta.TabIndex = 4;
			// 
			// CbMetodoConsulta
			// 
			this.CbMetodoConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CbMetodoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbMetodoConsulta.FormattingEnabled = true;
			this.CbMetodoConsulta.Items.AddRange(new object[] {
            "GET",
            "POST"});
			this.CbMetodoConsulta.Location = new System.Drawing.Point(736, 8);
			this.CbMetodoConsulta.Name = "CbMetodoConsulta";
			this.CbMetodoConsulta.Size = new System.Drawing.Size(121, 28);
			this.CbMetodoConsulta.TabIndex = 3;
			// 
			// TablaParametros
			// 
			this.TablaParametros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TablaParametros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.TablaParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TablaParametros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Valor,
            this.Descripcion,
            this.Tipo,
            this.Aleatorio});
			this.TablaParametros.Location = new System.Drawing.Point(7, 85);
			this.TablaParametros.Name = "TablaParametros";
			this.TablaParametros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TablaParametros.Size = new System.Drawing.Size(538, 221);
			this.TablaParametros.TabIndex = 2;
			// 
			// Clave
			// 
			this.Clave.HeaderText = "CLAVE";
			this.Clave.Name = "Clave";
			// 
			// Valor
			// 
			this.Valor.HeaderText = "VALOR";
			this.Valor.Name = "Valor";
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "DESCRIPCION";
			this.Descripcion.Name = "Descripcion";
			// 
			// Tipo
			// 
			this.Tipo.HeaderText = "TIPO";
			this.Tipo.Items.AddRange(new object[] {
            "Texto",
            "Numerico"});
			this.Tipo.Name = "Tipo";
			// 
			// Aleatorio
			// 
			this.Aleatorio.HeaderText = "ALEATORIO";
			this.Aleatorio.Name = "Aleatorio";
			// 
			// TbURL
			// 
			this.TbURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TbURL.Location = new System.Drawing.Point(55, 8);
			this.TbURL.Name = "TbURL";
			this.TbURL.Size = new System.Drawing.Size(675, 26);
			this.TbURL.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "URL:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 600);
			this.Controls.Add(this.PanelContenedor);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "TestForm";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.PanelContenedor.ResumeLayout(false);
			this.PanelContenedor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NupConsultas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TablaParametros)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PanelContenedor;
		private System.Windows.Forms.TextBox TbURL;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox CbMetodoConsulta;
		private System.Windows.Forms.DataGridView TablaParametros;
		private System.Windows.Forms.TextBox TbRespuesta;
		private System.Windows.Forms.Label LbConsultas;
		private System.Windows.Forms.Button BtnParar;
		private System.Windows.Forms.Button BtnIniciar;
		private System.Windows.Forms.TextBox TbTiempo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown NupConsultas;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
		private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewComboBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Aleatorio;
		private System.Windows.Forms.TextBox TbParametros;
		private System.Windows.Forms.TextBox TbLink;
		private System.Windows.Forms.Button BtnExportar;
		private System.Windows.Forms.Button BtnImportar;
	}
}

