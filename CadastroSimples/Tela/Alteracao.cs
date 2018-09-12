using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroSimples.Tela
{
    public partial class Alteracao : Form
    {
        public Alteracao()
        {
            InitializeComponent();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            using (var b = new Context())
            {
                //metodo para buscar por ID
               var objeto = b.ObjetoAgenda.Find(Convert.ToInt32(txt_id.Text));

                //As propriedades que estão sendo alteradas
                objeto.Nome = txt_nome.Text;
                objeto.Telefone = txt_telefone.Text;

                //realizando a operação de modificação
                b.Entry(objeto).State = EntityState.Modified;

                //salvando a modificação
                b.SaveChanges();

                MessageBox.Show("Alterado com sucesso!");

                var abrir = new Form1();
                abrir.Show();

                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
