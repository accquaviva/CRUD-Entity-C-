using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroSimples.Bussines
{
    public class BussinesAgenda
    {
        public void SalvarAgenda(Agenda agenda)
        {
            //validação para que seja inserido dados em todos os campos
            if (string.IsNullOrEmpty(agenda.Nome) || string.IsNullOrEmpty(agenda.Telefone))
            {
                MessageBox.Show("Por favor preencha todos os campos");
                //o returno é atribuido para que a validaçao pare aqui e não faça mais nada para baixo
                return;
            }
            else
            { 
                using (var b = new Context())
                {
                b.ObjetoAgenda.Add(new Agenda { Nome = agenda.Nome, Telefone = agenda.Telefone });
                b.SaveChanges();
                }
            }
        }

        //metodo para listar todos os usuarios cadastrados
        public void Listar(Form1 form)
        {
            using (var b = new Context())
            {
                form.dataGridView1.DataSource = b.ObjetoAgenda.ToList();
            }

        }

        public void Excluir(Agenda agenda)
        {
            if (string.IsNullOrEmpty(Convert.ToString(agenda.AgendaId)))
            {
                
                MessageBox.Show("Digite o ID que deseja excluir");
            }
            else
            { 
                using (var b = new Context())
                {
                //metodo para buscar por ID
                
                var objeto = b.ObjetoAgenda.Find(Convert.ToInt32(agenda.AgendaId));
                if(objeto == null)
                    {
                        MessageBox.Show("Esse valor não existe no banco");
                        return;
                    }
                    else
                    {
                        b.ObjetoAgenda.Remove(objeto);
                    }
                

                //salvando a modificação
                b.SaveChanges();

                MessageBox.Show("Excluido com sucesso!");

                }
            }
        }
    }
}
