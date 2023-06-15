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
    public partial class AdicionaAutor : Form
    {
        public readonly _Context _db;
        Home Home = new Home();

        public AdicionaAutor(Home home)
        {
            InitializeComponent();
            _db = new _Context();
            Home = home;
        }

        //Load da página
        private void AdicionaAutor_Load(object sender, EventArgs e)
        {
            PopularDadosAutor();
        }

        //Botão de inserir Autor
        private void btnInserirAutor_Click(object sender, EventArgs e)
        {
            try
            {
                Autor autor = new Autor();
                autor.NomeAutor = txtAutor.Text.ToUpper();

                _db.Autor.Add(autor);
                _db.SaveChanges();

                MessageBox.Show("Autor inserido com sucesso!", "SUCESSO");

                lblRetorno.Text = "Autor inserido com sucesso!";
                lblRetorno.Visible = true;

                btnInserirAutor.Visible = false;
                btnInserirNovoAutor.Visible = true;

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
        private void btnInserirNovoAutor_Click(object sender, EventArgs e)
        {
            txtAutor.Text = "";
            lblRetorno.Text = "";
            btnInserirNovoAutor.Visible = false;
            btnInserirAutor.Visible = true;
        }

        //Botão deletar o Autor
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Dialogo = MessageBox.Show("Voce deseja realmente excluir esse autor?",
                "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (Dialogo == DialogResult.Yes)
                {
                    Autor objDeleteAutor = _db.Autor.Where(x => x.NomeAutor == comboDeleteAutor.Text).First();
                    _db.Autor.Remove(objDeleteAutor);
                    _db.SaveChanges();

                    PopularDadosAutor();

                    MessageBox.Show("Excluído com sucesso!", "SUCESSO");

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

        private void PopularDadosAutor()
        {
            try
            {
                List<string> objListaAutor = new List<string>();
                List<Autor> autor = _db.Autor.ToList();

                foreach (Autor item in autor)
                {
                    string autorNome = item.NomeAutor;
                    objListaAutor.Add(autorNome);
                }

                comboDeleteAutor.DataSource = objListaAutor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message + " Contate o desenvolvedor adriwilca@gmail.com informando o erro.", "ERROR");
            }
        }
    }
}
