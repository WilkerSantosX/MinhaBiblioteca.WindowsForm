using MinhaBiblioteca.Classes;
using MinhaBiblioteca.Entity;
using MinhaBiblioteca.Forms;
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
    public partial class AdicionaLivro : Form
    {
        public readonly _Context _db;
        Home Home = new Home();

        public AdicionaLivro(Home home)
        {
            InitializeComponent();
            _db = new _Context();
            Home = home;
        }

        private void AdicionaLivro_Load(object sender, EventArgs e)
        {
            try
            {
                #region Popula Autor no ComboBox

                List<string> objListaAutor = new List<string>();
                List<Autor> autores = _db.Autor.ToList();

                foreach (Autor item in autores)
                {
                    string autor = item.NomeAutor;
                    objListaAutor.Add(autor);
                }

                comboNewAutor.DataSource = objListaAutor;

                #endregion

                #region Popula Editora no ComboBox

                List<string> objListaEditora = new List<string>();
                List<Editora> editora = _db.Editora.ToList();

                foreach (Editora item in editora)
                {
                    string editor = item.NomeEditora;
                    objListaEditora.Add(editor);
                }

                comboNewEditora.DataSource = objListaEditora;

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message + " Contate o desenvolvedor adriwilca@gmail.com informando o erro.", "ERROR");
            }  
        }

        private void btnSaveLivro_Click(object sender, EventArgs e)
        {
            try
            {
                Livro novoLivro = new Livro();

                novoLivro.Titulo = txtNewLivro.Text.ToUpper();
                novoLivro.CodigoAutor = _db.Autor.Where(x => x.NomeAutor == comboNewAutor.Text).First().CodigoAutor;
                novoLivro.CodigoEditora = _db.Editora.Where(x => x.NomeEditora == comboNewEditora.Text).First().CodigoEditora;
                novoLivro.Ano = Convert.ToInt32(txtNewAno.Text);

                if (radioSim.Checked)
                    novoLivro.JaLido = true;

                if (radioNao.Checked)
                    novoLivro.JaLido = false;

                if (comboNewAvaliacao.Text != "SEM AVALIAÇÃO")
                    novoLivro.Avaliacao = Convert.ToInt32(comboNewAvaliacao.Text);
                else
                    novoLivro.Avaliacao = 0;

                _db.Livro.Add(novoLivro);
                _db.SaveChanges();

                MessageBox.Show("Livro inserido com sucesso!", "SUCESSO");

                txtRetorno.Text = "LIVRO INSERIDO COM SUCESSO!";
                txtRetorno.Visible = true;

                btnSaveLivro.Visible = false;
                btnNovoLivro.Visible = true;

                //Atualizando o grid de livros
                Home.renderizar = false;
                Home.Home_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message + " Contate o desenvolvedor adriwilca@gmail.com informando o erro.", "ERROR");
            }
        }

        private void btnNovoLivro_Click(object sender, EventArgs e)
        {
            txtNewLivro.Text = "";
            txtNewAno.Text = "";
            txtRetorno.Text = "";
            radioNao.Checked = false;
            radioSim.Checked = false;
            btnNovoLivro.Visible = false;
            btnSaveLivro.Visible = true;
        }

    }
}
