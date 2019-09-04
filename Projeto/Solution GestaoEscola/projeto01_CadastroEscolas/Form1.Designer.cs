namespace projeto01_CadastroEscolas
{
	partial class Form1
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
			this.descricaoLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.escolaGroupBox = new System.Windows.Forms.GroupBox();
			this.telefoneTextBox = new System.Windows.Forms.TextBox();
			this.enderecoTextBox = new System.Windows.Forms.TextBox();
			this.descricaoEscolaTextBox = new System.Windows.Forms.TextBox();
			this.inserirEscolaButton = new System.Windows.Forms.Button();
			this.cursoGroupBox = new System.Windows.Forms.GroupBox();
			this.cursosDataGridView = new System.Windows.Forms.DataGridView();
			this.inserirCursoButton = new System.Windows.Forms.Button();
			this.escolasComboBox = new System.Windows.Forms.ComboBox();
			this.precoTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cargaHorariaTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.descricaoCursoTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.escolaGroupBox.SuspendLayout();
			this.cursoGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cursosDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// descricaoLabel
			// 
			this.descricaoLabel.AutoSize = true;
			this.descricaoLabel.Location = new System.Drawing.Point(17, 58);
			this.descricaoLabel.Name = "descricaoLabel";
			this.descricaoLabel.Size = new System.Drawing.Size(85, 13);
			this.descricaoLabel.TabIndex = 0;
			this.descricaoLabel.Text = "Nome da Escola";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Endereço";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Telefone";
			// 
			// escolaGroupBox
			// 
			this.escolaGroupBox.Controls.Add(this.telefoneTextBox);
			this.escolaGroupBox.Controls.Add(this.enderecoTextBox);
			this.escolaGroupBox.Controls.Add(this.descricaoEscolaTextBox);
			this.escolaGroupBox.Controls.Add(this.inserirEscolaButton);
			this.escolaGroupBox.Controls.Add(this.label3);
			this.escolaGroupBox.Controls.Add(this.descricaoLabel);
			this.escolaGroupBox.Controls.Add(this.label2);
			this.escolaGroupBox.Location = new System.Drawing.Point(12, 12);
			this.escolaGroupBox.Name = "escolaGroupBox";
			this.escolaGroupBox.Size = new System.Drawing.Size(367, 381);
			this.escolaGroupBox.TabIndex = 3;
			this.escolaGroupBox.TabStop = false;
			this.escolaGroupBox.Text = "Escola";
			// 
			// telefoneTextBox
			// 
			this.telefoneTextBox.Location = new System.Drawing.Point(111, 156);
			this.telefoneTextBox.Name = "telefoneTextBox";
			this.telefoneTextBox.Size = new System.Drawing.Size(123, 20);
			this.telefoneTextBox.TabIndex = 6;
			// 
			// enderecoTextBox
			// 
			this.enderecoTextBox.Location = new System.Drawing.Point(113, 105);
			this.enderecoTextBox.Name = "enderecoTextBox";
			this.enderecoTextBox.Size = new System.Drawing.Size(235, 20);
			this.enderecoTextBox.TabIndex = 5;
			// 
			// descricaoEscolaTextBox
			// 
			this.descricaoEscolaTextBox.Location = new System.Drawing.Point(113, 50);
			this.descricaoEscolaTextBox.Name = "descricaoEscolaTextBox";
			this.descricaoEscolaTextBox.Size = new System.Drawing.Size(235, 20);
			this.descricaoEscolaTextBox.TabIndex = 4;
			// 
			// inserirEscolaButton
			// 
			this.inserirEscolaButton.Location = new System.Drawing.Point(95, 216);
			this.inserirEscolaButton.Name = "inserirEscolaButton";
			this.inserirEscolaButton.Size = new System.Drawing.Size(152, 23);
			this.inserirEscolaButton.TabIndex = 3;
			this.inserirEscolaButton.Text = "Inserir Escola";
			this.inserirEscolaButton.UseVisualStyleBackColor = true;
			this.inserirEscolaButton.Click += new System.EventHandler(this.inserirEscolaButton_Click);
			// 
			// cursoGroupBox
			// 
			this.cursoGroupBox.Controls.Add(this.cursosDataGridView);
			this.cursoGroupBox.Controls.Add(this.inserirCursoButton);
			this.cursoGroupBox.Controls.Add(this.escolasComboBox);
			this.cursoGroupBox.Controls.Add(this.precoTextBox);
			this.cursoGroupBox.Controls.Add(this.label6);
			this.cursoGroupBox.Controls.Add(this.cargaHorariaTextBox);
			this.cursoGroupBox.Controls.Add(this.label5);
			this.cursoGroupBox.Controls.Add(this.descricaoCursoTextBox);
			this.cursoGroupBox.Controls.Add(this.label4);
			this.cursoGroupBox.Controls.Add(this.label1);
			this.cursoGroupBox.Location = new System.Drawing.Point(403, 12);
			this.cursoGroupBox.Name = "cursoGroupBox";
			this.cursoGroupBox.Size = new System.Drawing.Size(367, 381);
			this.cursoGroupBox.TabIndex = 4;
			this.cursoGroupBox.TabStop = false;
			this.cursoGroupBox.Text = "Curso";
			// 
			// cursosDataGridView
			// 
			this.cursosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cursosDataGridView.Location = new System.Drawing.Point(6, 200);
			this.cursosDataGridView.Name = "cursosDataGridView";
			this.cursosDataGridView.Size = new System.Drawing.Size(355, 175);
			this.cursosDataGridView.TabIndex = 11;
			// 
			// inserirCursoButton
			// 
			this.inserirCursoButton.Location = new System.Drawing.Point(111, 171);
			this.inserirCursoButton.Name = "inserirCursoButton";
			this.inserirCursoButton.Size = new System.Drawing.Size(152, 23);
			this.inserirCursoButton.TabIndex = 7;
			this.inserirCursoButton.Text = "Inserir Curso";
			this.inserirCursoButton.UseVisualStyleBackColor = true;
			// 
			// escolasComboBox
			// 
			this.escolasComboBox.FormattingEnabled = true;
			this.escolasComboBox.Location = new System.Drawing.Point(111, 27);
			this.escolasComboBox.Name = "escolasComboBox";
			this.escolasComboBox.Size = new System.Drawing.Size(235, 21);
			this.escolasComboBox.TabIndex = 10;
			// 
			// precoTextBox
			// 
			this.precoTextBox.Location = new System.Drawing.Point(111, 145);
			this.precoTextBox.Name = "precoTextBox";
			this.precoTextBox.Size = new System.Drawing.Size(123, 20);
			this.precoTextBox.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(25, 35);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Escolas";
			// 
			// cargaHorariaTextBox
			// 
			this.cargaHorariaTextBox.Location = new System.Drawing.Point(111, 106);
			this.cargaHorariaTextBox.Name = "cargaHorariaTextBox";
			this.cargaHorariaTextBox.Size = new System.Drawing.Size(235, 20);
			this.cargaHorariaTextBox.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Preço";
			// 
			// descricaoCursoTextBox
			// 
			this.descricaoCursoTextBox.Location = new System.Drawing.Point(111, 64);
			this.descricaoCursoTextBox.Name = "descricaoCursoTextBox";
			this.descricaoCursoTextBox.Size = new System.Drawing.Size(235, 20);
			this.descricaoCursoTextBox.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Carga Horaria";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome do Curso";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cursoGroupBox);
			this.Controls.Add(this.escolaGroupBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.escolaGroupBox.ResumeLayout(false);
			this.escolaGroupBox.PerformLayout();
			this.cursoGroupBox.ResumeLayout(false);
			this.cursoGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cursosDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label descricaoLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox escolaGroupBox;
		private System.Windows.Forms.GroupBox cursoGroupBox;
		private System.Windows.Forms.TextBox telefoneTextBox;
		private System.Windows.Forms.TextBox enderecoTextBox;
		private System.Windows.Forms.TextBox descricaoEscolaTextBox;
		private System.Windows.Forms.Button inserirEscolaButton;
		private System.Windows.Forms.TextBox precoTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox cargaHorariaTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox descricaoCursoTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button inserirCursoButton;
		private System.Windows.Forms.ComboBox escolasComboBox;
		private System.Windows.Forms.DataGridView cursosDataGridView;
	}
}

