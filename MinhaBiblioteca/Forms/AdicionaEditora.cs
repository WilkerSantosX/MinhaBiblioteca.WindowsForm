using MinhaBiblioteca.Classes;
using MinhaBiblioteca.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaBiblioteca.Forms
{
    public partial class AdicionaEditora : Form
    {
        public readonly _Context _db;
        Home Home = new Home();

        public AdicionaEditora(Home home)
        {
            InitializeComponent();
            _db = new _Context();
            Home = home;
        }

        //Load da página
        private void AdicionaEditora_Load(object sender, EventArgs e)
        {
            PopularDadosEditora();
        }

        //Inserir Editora
        private void btnInserirEditora_Click(object sender, EventArgs e)
        {
            try
            {
                Editora editora = new Editora();
                editora.NomeEditora = txtEditora.Text.ToUpper();

                _db.Editora.Add(editora);
                _db.SaveChanges();

                MessageBox.Show("Editora inserida com sucesso!", "SUCESSO");

                lblRetorno.Text = "Editora inserido com sucesso!";
                lblRetorno.Visible = true;

                btnInserirEditora.Visible = false;
                btnInserirNovaEditora.Visible = true;

                //Atualizando o GRID
                Home.renderizar = false;
                Home.Home_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message + " Contate o desenvolvedor adriwilca@gmail.com informando o erro.", "ERROR");
            }
        }

        //Limpar campos
        private void btnInserirNovaEditora_Click(object sender, EventArgs e)
        {
            txtEditora.Text = "";
            lblRetorno.Text = "";
            btnInserirNovaEditora.Visible = false;
            btnInserirEditora.Visible = true;
        }

        //Deletar Editora
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Dialogo = MessageBox.Show("Voce deseja realmente excluir essa editora?",
             "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (Dialogo == DialogResult.Yes)
                {
                    Editora objDeleteEditora = _db.Editora.Where(x => x.NomeEditora == comboDeleteEditora.Text).First();
                    _db.Editora.Remove(objDeleteEditora);
                    _db.SaveChanges();

                    MessageBox.Show("Excluído com sucesso!", "SUCESSO");

                    PopularDadosEditora();

                    //Atualizando o grid
                    Home.renderizar = false;
                    Home.Home_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message + " Contate o desenvolvedor adriwilca@gmail.com informando o erro.", "ERROR");
            }
        }

        private void PopularDadosEditora()
        {
            try
            {
                List<string> objListaEditora = new List<string>();
                List<Editora> editora = _db.Editora.ToList();

                foreach (Editora item in editora)
                {
                    string editor = item.NomeEditora;
                    objListaEditora.Add(editor);
                }

                comboDeleteEditora.DataSource = objListaEditora;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message + " Contate o desenvolvedor adriwilca@gmail.com informando o erro.", "ERROR");
            }
        }
    }
}
