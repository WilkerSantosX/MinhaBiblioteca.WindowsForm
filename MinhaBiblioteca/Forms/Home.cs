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
    public partial class Home : Form
    {
        public readonly _Context _db;
        Carregando loading = new Carregando();

        public Home()
        {
            InitializeComponent();
            _db = new _Context();
        }

        public bool renderizar = true;
        List<LivroModel> objListaLivros = new List<LivroModel>();
        List<Livro> livros = new List<Livro>();

        //Load da Página
        public void Home_Load(object sender, EventArgs e)
        {
            try
            {
                #region Popula Livros no Grid

                livros = _db.Livro.Include("Autor").Include("Editora").ToList();

                if (objListaLivros.Any())
                    objListaLivros = new List<LivroModel>(); ;

                foreach (Livro item in livros)
                {
                    LivroModel objLivro = new LivroModel();
                    objLivro.IDLivro = item.CodigoLivro;
                    objLivro.Titulo = item.Titulo;
                    objLivro.Autor = item.Autor.NomeAutor;
                    objLivro.Editora = item.Editora.NomeEditora;
                    objLivro.Ano = item.Ano;
                    objLivro.JaLido = item.JaLido;
                    objLivro.Avaliacao = item.Avaliacao;
                    objListaLivros.Add(objLivro);
                }

                //Datagridview recebe já preenchido
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = objListaLivros;

                #endregion

                #region Popula Autor no ComboBox

                List<string> objListaAutor = new List<string>();
                List<Autor> autores = _db.Autor.ToList();

                foreach (Autor item in autores)
                {
                    string autor = item.NomeAutor;
                    objListaAutor.Add(autor);
                }

                comboEditAutor.DataSource = objListaAutor;

                #endregion

                #region Popula Editora no ComboBox

                List<string> objListaEditora = new List<string>();
                List<Editora> editora = _db.Editora.ToList();

                foreach (Editora item in editora)
                {
                    string editor = item.NomeEditora;
                    objListaEditora.Add(editor);
                }

                comboEditEditora.DataSource = objListaEditora;

                #endregion

                #region Popula Contagem dos Dados

                //Contagem total de registros cadastrados
                CountLivro.Text = objListaLivros.Count.ToString();
                CountAutor.Text = _db.Autor.ToList().Count.ToString();
                CountEditora.Text = _db.Editora.ToList().Count.ToString();
                CountLido.Text = objListaLivros.Where(x => x.JaLido).ToList().Count.ToString();

                //Progresso de Leitura
                progressLeitura.Value = CalcularProgressoLeitura(Convert.ToDouble(CountLivro.Text), Convert.ToDouble(CountLido.Text));
                PorcentLeitura.Text = progressLeitura.Value.ToString() + "%";

                #endregion

                #region Ajusta Largura das Colunas

                if (renderizar)
                {
                    //Preenchendo o GRID
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    //Definindo largura para coluna ID
                    DataGridViewColumn columnID = dataGridView1.Columns[0];
                    columnID.Width = 20;

                    //Definindo largura para coluna TITULO
                    DataGridViewColumn columnTitle = dataGridView1.Columns[1];
                    columnTitle.Width = 250;

                    //Definindo largura para coluna AUTOR
                    DataGridViewColumn columnAutor = dataGridView1.Columns[2];
                    columnAutor.Width = 130;

                    //Definindo largura para coluna EDITORA
                    DataGridViewColumn columnEditora = dataGridView1.Columns[3];
                    columnEditora.Width = 70;

                    //Definindo largura para coluna ANO
                    DataGridViewColumn columnAno = dataGridView1.Columns[4];
                    columnAno.Width = 70;

                    //Definindo largura para coluna JALIDO
                    DataGridViewColumn columnLido = dataGridView1.Columns[5];
                    columnLido.Width = 50;

                    //Para não ficar ajustando toda vez, basta apenas uma
                    renderizar = false;
                }

                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message + " Contate o desenvolvedor adriwilca@gmail.com informando o erro.", "ERROR");
            }
             
        }

        //Evento de Click no Grid
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDLivro.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtEditLivro.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboEditAutor.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboEditEditora.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtEditAno.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                bool lido = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[5].Value);

                if (lido)
                    radioEditSim.Checked = true;
                else
                    radioEditNao.Checked = true;

                comboEditAvaliacao.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                if (comboEditAvaliacao.Text == "0")
                    comboEditAvaliacao.Text = "SEM AVALIAÇÃO";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message + " Contate o desenvolvedor adriwilca@gmail.com informando o erro.", "ERROR");
            }
        }

        //Pesquisar no Grid
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                btnListarTodos.Visible = true;

                if (comboPesquisa.Text == "LIVRO")
                {
                    dataGridView1.DataSource = null;
                    List<LivroModel> livrosPesquisados = objListaLivros.Where(x => x.Titulo == txtPesquisa.Text.ToUpper()).ToList();
                    dataGridView1.DataSource = livrosPesquisados;
                }
                else if (comboPesquisa.Text == "AUTOR")
                {
                    dataGridView1.DataSource = null;
                    List<LivroModel> livrosPesquisados = objListaLivros.Where(x => x.Autor == txtPesquisa.Text.ToUpper()).ToList();
                    dataGridView1.DataSource = livrosPesquisados;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message + " Contate o desenvolvedor adriwilca@gmail.com informando o erro.", "ERROR");
            }
        }

        //Resetar pesquisa no Grid
        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = objListaLivros.ToList();
                btnListarTodos.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message + " Contate o desenvolvedor adriwilca@gmail.com informando o erro.", "ERROR");
            }
        }

        //Botão modal Adicionar Livro
        private void btnAddLivro_Click(object sender, EventArgs e)
        {
            AdicionaLivro addLivro = new AdicionaLivro(this);
            addLivro.Show();
        }

        //Botão modal Adicionar Autor
        private void btnAddAutor_Click(object sender, EventArgs e)
        {
            AdicionaAutor addAutor = new AdicionaAutor(this);
            addAutor.Show();
        }

        //Botão modal Adicionar Editora
        private void btnAddEditora_Click(object sender, EventArgs e)
        {
            AdicionaEditora addEditora = new AdicionaEditora(this);
            addEditora.Show();
        }

        //Botão salvar alterações no Livro
        private void btnEditSaveLivro_Click(object sender, EventArgs e)
        {
            try
            {
                //Pegando o objeto antigo no banco e passando os novos valores
                int idLivro = Convert.ToInt32(IDLivro.Text);

                Livro objSaveLivro = _db.Livro.Where(x => x.CodigoLivro == idLivro).First();

                objSaveLivro.Titulo = txtEditLivro.Text.ToUpper();
                objSaveLivro.Ano = Convert.ToInt32(txtEditAno.Text);

                if (comboEditAvaliacao.Text != "SEM AVALIAÇÃO")
                    objSaveLivro.Avaliacao = Convert.ToInt32(comboEditAvaliacao.Text);

                objSaveLivro.CodigoAutor = _db.Autor.Where(x => x.NomeAutor == comboEditAutor.Text).First().CodigoAutor;
                objSaveLivro.CodigoEditora = _db.Editora.Where(x => x.NomeEditora == comboEditEditora.Text).First().CodigoEditora;

                if (radioEditSim.Checked)
                    objSaveLivro.JaLido = true;

                if (radioEditNao.Checked)
                    objSaveLivro.JaLido = false;

                //Persiste no banco
                _db.SaveChanges();
                MessageBox.Show("Livro atualizado com sucesso!", "Sucesso");

                //Atualiza o GRID
                renderizar = false;
                Home_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message + " Contate o desenvolvedor adriwilca@gmail.com informando o erro.", "ERROR");
            }
        }

        //Botão deletar o Livro
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Dialogo = MessageBox.Show("Voce deseja realmente excluir esse livro?",
             "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (Dialogo == DialogResult.Yes)
                {
                    int idLivro = Convert.ToInt32(IDLivro.Text);

                    Livro objDeleteLivro = _db.Livro.Where(x => x.CodigoLivro == idLivro).FirstOrDefault();
                    _db.Livro.Remove(objDeleteLivro);
                    _db.SaveChanges();

                    MessageBox.Show("Excluído com sucesso!", "SUCESSO");

                    //Atualizando o grid
                    renderizar = false;
                    Home_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Ocorreu um erro inesperado: {0}", ex.Message), "ERRO");
            }
        }

        //Calcular progresso na Leitura
        private int CalcularProgressoLeitura(double qtdTotal, double qtdLida)
        {
            if (qtdTotal > 0)
            {
                double porcentagem = ((qtdLida / qtdTotal) * 100);

                return Convert.ToInt32(porcentagem);
            }

            return 0;
        }
    }
}
