
namespace VetorValida
{
    partial class frmCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.txbEscola = new System.Windows.Forms.TextBox();
            this.lblEscola = new System.Windows.Forms.Label();
            this.lblHorário = new System.Windows.Forms.Label();
            this.gpbHorario = new System.Windows.Forms.GroupBox();
            this.rdbManha = new System.Windows.Forms.RadioButton();
            this.rdbTarde = new System.Windows.Forms.RadioButton();
            this.rdbNoite = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDisciplina = new System.Windows.Forms.TextBox();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.txbQuantidadeDisciplina = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lsbDisciplina = new System.Windows.Forms.ListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.gpbHorario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(53, 31);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(207, 20);
            this.txbNome.TabIndex = 1;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(12, 67);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF";
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(53, 67);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(207, 20);
            this.txbCpf.TabIndex = 3;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(301, 34);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(364, 31);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(240, 20);
            this.txbEndereco.TabIndex = 5;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(464, 167);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(104, 13);
            this.lblDataNascimento.TabIndex = 6;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(467, 183);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(92, 20);
            this.dtpNascimento.TabIndex = 7;
            // 
            // txbEscola
            // 
            this.txbEscola.Location = new System.Drawing.Point(364, 67);
            this.txbEscola.Name = "txbEscola";
            this.txbEscola.Size = new System.Drawing.Size(240, 20);
            this.txbEscola.TabIndex = 9;
            // 
            // lblEscola
            // 
            this.lblEscola.AutoSize = true;
            this.lblEscola.Location = new System.Drawing.Point(273, 70);
            this.lblEscola.Name = "lblEscola";
            this.lblEscola.Size = new System.Drawing.Size(85, 13);
            this.lblEscola.TabIndex = 8;
            this.lblEscola.Text = "Nome da Escola";
            // 
            // lblHorário
            // 
            this.lblHorário.AutoSize = true;
            this.lblHorário.Location = new System.Drawing.Point(12, 125);
            this.lblHorário.Name = "lblHorário";
            this.lblHorário.Size = new System.Drawing.Size(83, 13);
            this.lblHorário.TabIndex = 10;
            this.lblHorário.Text = "Período Escolar";
            // 
            // gpbHorario
            // 
            this.gpbHorario.Controls.Add(this.rdbNoite);
            this.gpbHorario.Controls.Add(this.rdbTarde);
            this.gpbHorario.Controls.Add(this.rdbManha);
            this.gpbHorario.Location = new System.Drawing.Point(101, 110);
            this.gpbHorario.Name = "gpbHorario";
            this.gpbHorario.Size = new System.Drawing.Size(218, 39);
            this.gpbHorario.TabIndex = 11;
            this.gpbHorario.TabStop = false;
            this.gpbHorario.Text = "Horário";
            // 
            // rdbManha
            // 
            this.rdbManha.AutoSize = true;
            this.rdbManha.Location = new System.Drawing.Point(6, 13);
            this.rdbManha.Name = "rdbManha";
            this.rdbManha.Size = new System.Drawing.Size(58, 17);
            this.rdbManha.TabIndex = 12;
            this.rdbManha.TabStop = true;
            this.rdbManha.Text = "Manhã";
            this.rdbManha.UseVisualStyleBackColor = true;
            this.rdbManha.CheckedChanged += new System.EventHandler(this.rdbManhã_CheckedChanged);
            // 
            // rdbTarde
            // 
            this.rdbTarde.AutoSize = true;
            this.rdbTarde.Location = new System.Drawing.Point(70, 13);
            this.rdbTarde.Name = "rdbTarde";
            this.rdbTarde.Size = new System.Drawing.Size(75, 17);
            this.rdbTarde.TabIndex = 13;
            this.rdbTarde.TabStop = true;
            this.rdbTarde.Text = "Vespertino";
            this.rdbTarde.UseVisualStyleBackColor = true;
            // 
            // rdbNoite
            // 
            this.rdbNoite.AutoSize = true;
            this.rdbNoite.Location = new System.Drawing.Point(151, 13);
            this.rdbNoite.Name = "rdbNoite";
            this.rdbNoite.Size = new System.Drawing.Size(63, 17);
            this.rdbNoite.TabIndex = 14;
            this.rdbNoite.TabStop = true;
            this.rdbNoite.Text = "Noturno";
            this.rdbNoite.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quantas Disciplina Estuda";
            // 
            // txbDisciplina
            // 
            this.txbDisciplina.Location = new System.Drawing.Point(116, 168);
            this.txbDisciplina.Name = "txbDisciplina";
            this.txbDisciplina.Size = new System.Drawing.Size(188, 20);
            this.txbDisciplina.TabIndex = 14;
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(12, 171);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(98, 13);
            this.lblDisciplina.TabIndex = 13;
            this.lblDisciplina.Text = "Nome da Disciplina";
            // 
            // txbQuantidadeDisciplina
            // 
            this.txbQuantidadeDisciplina.Location = new System.Drawing.Point(467, 129);
            this.txbQuantidadeDisciplina.Name = "txbQuantidadeDisciplina";
            this.txbQuantidadeDisciplina.Size = new System.Drawing.Size(92, 20);
            this.txbQuantidadeDisciplina.TabIndex = 15;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(300, 168);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(103, 20);
            this.btnAdicionar.TabIndex = 16;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // lsbDisciplina
            // 
            this.lsbDisciplina.FormattingEnabled = true;
            this.lsbDisciplina.Location = new System.Drawing.Point(16, 203);
            this.lsbDisciplina.Name = "lsbDisciplina";
            this.lsbDisciplina.ScrollAlwaysVisible = true;
            this.lsbDisciplina.Size = new System.Drawing.Size(387, 225);
            this.lsbDisciplina.TabIndex = 17;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(432, 311);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(172, 35);
            this.btnMostrar.TabIndex = 18;
            this.btnMostrar.Text = "Mostrar Cadastro";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(432, 352);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(172, 35);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar Formulário";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(432, 393);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(172, 35);
            this.btnApagar.TabIndex = 20;
            this.btnApagar.Text = "Apagar Tudo";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lsbDisciplina);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txbQuantidadeDisciplina);
            this.Controls.Add(this.txbDisciplina);
            this.Controls.Add(this.lblDisciplina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbHorario);
            this.Controls.Add(this.lblHorário);
            this.Controls.Add(this.txbEscola);
            this.Controls.Add(this.lblEscola);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCadastro";
            this.Text = "Formulário de Cadastro de Disciplinas";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.gpbHorario.ResumeLayout(false);
            this.gpbHorario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.TextBox txbEscola;
        private System.Windows.Forms.Label lblEscola;
        private System.Windows.Forms.Label lblHorário;
        private System.Windows.Forms.GroupBox gpbHorario;
        private System.Windows.Forms.RadioButton rdbNoite;
        private System.Windows.Forms.RadioButton rdbTarde;
        private System.Windows.Forms.RadioButton rdbManha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDisciplina;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.TextBox txbQuantidadeDisciplina;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox lsbDisciplina;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnApagar;
    }
}

