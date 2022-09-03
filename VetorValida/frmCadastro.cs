using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetorValida
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
            rdbManha.Checked = false;
            rdbTarde.Checked = false;
            rdbNoite.Checked = false;
        }
        int quantidade;
        int preenche = 0;
        string[] disciplina = new string[15];
        string nome, cpf, endereco, escola, materias;
        DateTime dNasc;
        bool rbManha, rbTarde, rbNoite;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Guardar as informações do formulário
            nome = txbNome.Text;
            cpf = txbCpf.Text;
            endereco = txbEndereco.Text;
            dNasc = dtpNascimento.Value;
            rbManha = rdbManha.Checked;
            rbTarde = rdbTarde.Checked;
            rbNoite = rdbNoite.Checked;
            txbQuantidadeDisciplina.Enabled = true;
            materias = txbQuantidadeDisciplina.Text;
            txbDisciplina.Enabled = true;

            //Limpar o formulário
            txbNome.Text = "";
            txbCpf.Text = "";
            txbEndereco.Text = "";
            dtpNascimento.Value = DateTime.Now.Date;
            txbEscola.Text = "";
            rdbManha.Checked = false;
            rdbTarde.Checked = false;
            rdbNoite.Checked = false;
            txbQuantidadeDisciplina.Text = "";
            lsbDisciplina.Items.Clear();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void rdbManhã_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int i, x;
            txbNome.Text = nome;
            txbCpf.Text = cpf;
            txbEndereco.Text = endereco;
            dtpNascimento.Value = dNasc;
            txbEscola.Text = escola;
            rdbManha.Checked = rbManha;
            rdbTarde.Checked = rbTarde;
            rdbNoite.Checked = rbNoite;
            txbQuantidadeDisciplina.Text = materias;
            x = Convert.ToInt32(txbQuantidadeDisciplina.Text);
            for(i = 0; i < x; i++)
            {
                lsbDisciplina.Items.Add(disciplina[i]);
            }
        }
    }
}
