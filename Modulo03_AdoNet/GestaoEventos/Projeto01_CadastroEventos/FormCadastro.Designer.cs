namespace Projeto01_CadastroEventos
{
	partial class FormCadastro
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.incluirEventoButton = new System.Windows.Forms.Button();
			this.responsavelTextBox = new System.Windows.Forms.TextBox();
			this.precoTextBox = new System.Windows.Forms.TextBox();
			this.descricaoTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.convidadosDataGridView = new System.Windows.Forms.DataGridView();
			this.buscarConvidadosButton = new System.Windows.Forms.Button();
			this.incluirConvidadoButton = new System.Windows.Forms.Button();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.telefoneTextBox = new System.Windows.Forms.TextBox();
			this.nomeTextBox = new System.Windows.Forms.TextBox();
			this.cpfTextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.telefoneLabel = new System.Windows.Forms.Label();
			this.nomeLabel = new System.Windows.Forms.Label();
			this.cpfLabel = new System.Windows.Forms.Label();
			this.eventoComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.convidadosDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataMaskedTextBox);
			this.groupBox1.Controls.Add(this.incluirEventoButton);
			this.groupBox1.Controls.Add(this.responsavelTextBox);
			this.groupBox1.Controls.Add(this.precoTextBox);
			this.groupBox1.Controls.Add(this.descricaoTextBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(327, 351);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados do Evento";
			// 
			// dataMaskedTextBox
			// 
			this.dataMaskedTextBox.Location = new System.Drawing.Point(132, 110);
			this.dataMaskedTextBox.Mask = "00/00/0000";
			this.dataMaskedTextBox.Name = "dataMaskedTextBox";
			this.dataMaskedTextBox.Size = new System.Drawing.Size(100, 20);
			this.dataMaskedTextBox.TabIndex = 2;
			// 
			// incluirEventoButton
			// 
			this.incluirEventoButton.Location = new System.Drawing.Point(85, 255);
			this.incluirEventoButton.Name = "incluirEventoButton";
			this.incluirEventoButton.Size = new System.Drawing.Size(147, 23);
			this.incluirEventoButton.TabIndex = 4;
			this.incluirEventoButton.Text = "Incluir Evento";
			this.incluirEventoButton.UseVisualStyleBackColor = true;
			this.incluirEventoButton.Click += new System.EventHandler(this.incluirEventoButton_Click);
			// 
			// responsavelTextBox
			// 
			this.responsavelTextBox.Location = new System.Drawing.Point(132, 69);
			this.responsavelTextBox.Name = "responsavelTextBox";
			this.responsavelTextBox.Size = new System.Drawing.Size(174, 20);
			this.responsavelTextBox.TabIndex = 1;
			// 
			// precoTextBox
			// 
			this.precoTextBox.Location = new System.Drawing.Point(132, 155);
			this.precoTextBox.Name = "precoTextBox";
			this.precoTextBox.Size = new System.Drawing.Size(100, 20);
			this.precoTextBox.TabIndex = 3;
			// 
			// descricaoTextBox
			// 
			this.descricaoTextBox.Location = new System.Drawing.Point(132, 27);
			this.descricaoTextBox.Name = "descricaoTextBox";
			this.descricaoTextBox.Size = new System.Drawing.Size(174, 20);
			this.descricaoTextBox.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Preço:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Data:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Responsável:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Descrição:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.convidadosDataGridView);
			this.groupBox2.Controls.Add(this.buscarConvidadosButton);
			this.groupBox2.Controls.Add(this.incluirConvidadoButton);
			this.groupBox2.Controls.Add(this.emailTextBox);
			this.groupBox2.Controls.Add(this.telefoneTextBox);
			this.groupBox2.Controls.Add(this.nomeTextBox);
			this.groupBox2.Controls.Add(this.cpfTextBox);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.telefoneLabel);
			this.groupBox2.Controls.Add(this.nomeLabel);
			this.groupBox2.Controls.Add(this.cpfLabel);
			this.groupBox2.Controls.Add(this.eventoComboBox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(356, 33);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(347, 351);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dados do Convidado";
			// 
			// convidadosDataGridView
			// 
			this.convidadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.convidadosDataGridView.Location = new System.Drawing.Point(7, 189);
			this.convidadosDataGridView.Name = "convidadosDataGridView";
			this.convidadosDataGridView.Size = new System.Drawing.Size(334, 150);
			this.convidadosDataGridView.TabIndex = 13;
			// 
			// buscarConvidadosButton
			// 
			this.buscarConvidadosButton.Location = new System.Drawing.Point(253, 30);
			this.buscarConvidadosButton.Name = "buscarConvidadosButton";
			this.buscarConvidadosButton.Size = new System.Drawing.Size(75, 23);
			this.buscarConvidadosButton.TabIndex = 12;
			this.buscarConvidadosButton.Text = "Buscar";
			this.buscarConvidadosButton.UseVisualStyleBackColor = true;
			this.buscarConvidadosButton.Click += new System.EventHandler(this.buscarConvidadosButton_Click);
			// 
			// incluirConvidadoButton
			// 
			this.incluirConvidadoButton.Location = new System.Drawing.Point(101, 162);
			this.incluirConvidadoButton.Name = "incluirConvidadoButton";
			this.incluirConvidadoButton.Size = new System.Drawing.Size(150, 23);
			this.incluirConvidadoButton.TabIndex = 11;
			this.incluirConvidadoButton.Text = "Incluir Convidado";
			this.incluirConvidadoButton.UseVisualStyleBackColor = true;
			this.incluirConvidadoButton.Click += new System.EventHandler(this.incluirConvidadoButton_Click);
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(101, 137);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(227, 20);
			this.emailTextBox.TabIndex = 10;
			// 
			// telefoneTextBox
			// 
			this.telefoneTextBox.Location = new System.Drawing.Point(101, 111);
			this.telefoneTextBox.Name = "telefoneTextBox";
			this.telefoneTextBox.Size = new System.Drawing.Size(124, 20);
			this.telefoneTextBox.TabIndex = 9;
			// 
			// nomeTextBox
			// 
			this.nomeTextBox.Location = new System.Drawing.Point(101, 85);
			this.nomeTextBox.Name = "nomeTextBox";
			this.nomeTextBox.Size = new System.Drawing.Size(227, 20);
			this.nomeTextBox.TabIndex = 8;
			// 
			// cpfTextBox
			// 
			this.cpfTextBox.Location = new System.Drawing.Point(101, 59);
			this.cpfTextBox.Name = "cpfTextBox";
			this.cpfTextBox.Size = new System.Drawing.Size(124, 20);
			this.cpfTextBox.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(32, 140);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 13);
			this.label9.TabIndex = 6;
			this.label9.Text = "Email";
			// 
			// telefoneLabel
			// 
			this.telefoneLabel.AutoSize = true;
			this.telefoneLabel.Location = new System.Drawing.Point(29, 114);
			this.telefoneLabel.Name = "telefoneLabel";
			this.telefoneLabel.Size = new System.Drawing.Size(49, 13);
			this.telefoneLabel.TabIndex = 5;
			this.telefoneLabel.Text = "Telefone";
			// 
			// nomeLabel
			// 
			this.nomeLabel.AutoSize = true;
			this.nomeLabel.Location = new System.Drawing.Point(29, 88);
			this.nomeLabel.Name = "nomeLabel";
			this.nomeLabel.Size = new System.Drawing.Size(35, 13);
			this.nomeLabel.TabIndex = 4;
			this.nomeLabel.Text = "Nome";
			// 
			// cpfLabel
			// 
			this.cpfLabel.AutoSize = true;
			this.cpfLabel.Location = new System.Drawing.Point(29, 62);
			this.cpfLabel.Name = "cpfLabel";
			this.cpfLabel.Size = new System.Drawing.Size(23, 13);
			this.cpfLabel.TabIndex = 3;
			this.cpfLabel.Text = "Cpf";
			// 
			// eventoComboBox
			// 
			this.eventoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.eventoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.eventoComboBox.FormattingEnabled = true;
			this.eventoComboBox.Location = new System.Drawing.Point(101, 32);
			this.eventoComboBox.Name = "eventoComboBox";
			this.eventoComboBox.Size = new System.Drawing.Size(135, 21);
			this.eventoComboBox.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Evento";
			// 
			// FormCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 422);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormCadastro";
			this.Text = "Cadastro de Eventos e Convidados";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.convidadosDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MaskedTextBox dataMaskedTextBox;
		private System.Windows.Forms.Button incluirEventoButton;
		private System.Windows.Forms.TextBox responsavelTextBox;
		private System.Windows.Forms.TextBox precoTextBox;
		private System.Windows.Forms.TextBox descricaoTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox eventoComboBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button incluirConvidadoButton;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox telefoneTextBox;
		private System.Windows.Forms.TextBox nomeTextBox;
		private System.Windows.Forms.TextBox cpfTextBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label telefoneLabel;
		private System.Windows.Forms.Label nomeLabel;
		private System.Windows.Forms.Label cpfLabel;
		private System.Windows.Forms.DataGridView convidadosDataGridView;
		private System.Windows.Forms.Button buscarConvidadosButton;
	}
}

