using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G.I.V
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Comandos obj = new Comandos();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Comandos obj = new Comandos();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.descricao = txtDescricao.Text;
            obj.valor = Convert.ToDouble(txtValor.Text);
            obj.quantidade = (int)Convert.ToInt64(txtQuantidade.Text);
            obj.Cadastrar();
            MessageBox.Show("Cadastro Efetuado!");
            txtId.Clear();
            txtDescricao.Clear();
            txtValor.Clear();
            txtQuantidade.Clear();
            txtId.Focus();
            dataGridView1.DataSource = obj.Listar();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Comandos obj = new Comandos();
            obj.id = int.Parse(txtId.Text);
            obj.Excluir();
            MessageBox.Show("Excluído com Sucesso!");
            txtId.Clear();
            txtDescricao.Clear();
            txtValor.Clear();
            txtQuantidade.Clear();
            txtId.Focus();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Comandos obj = new Comandos();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.descricao = txtDescricao.Text;
            obj.valor = Convert.ToDouble(txtValor.Text);
            obj.quantidade = (int)Convert.ToInt64(txtQuantidade.Text);
            obj.Alterar();
            MessageBox.Show("Alterado com Sucesso!");
            txtId.Clear();
            txtDescricao.Clear();
            txtValor.Clear();
            txtQuantidade.Clear();
            txtId.Focus();
            dataGridView1.DataSource = obj.Listar();
        }
    }
}
