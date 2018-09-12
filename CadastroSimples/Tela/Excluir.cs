using CadastroSimples.Bussines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroSimples.Tela
{
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((txt_id.Text)))
            {
                MessageBox.Show("Digite todos os campos");
                return;
            }
            else
            { 
            var agenda = new Agenda();
            agenda.AgendaId = int.Parse(txt_id.Text);

            var excluir = new BussinesAgenda();
            excluir.Excluir(agenda);
            var abrir = new Form1();
            abrir.Show();

            this.Hide();
            }
            
        }
    }
}
