using CadastroSimples.Bussines;
using CadastroSimples.Tela;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var atualizar = new BussinesAgenda();
            atualizar.Listar(this);
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            var agenda = new Agenda();
            agenda.Nome = txt_nome.Text;
            agenda.Telefone = txt_telefone.Text;

            var salvar = new BussinesAgenda();
            salvar.SalvarAgenda(agenda);

            salvar.Listar(this);
            
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

            Alteracao alterar = new Alteracao();
            alterar.Show();
            //para fechar a tela
            this.Hide();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Excluir excluir = new Excluir();
            excluir.Show();
            //para fechar a tela
            this.Hide();
        }
    }
}
