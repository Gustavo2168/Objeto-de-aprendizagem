using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace G.I.V
{
    class Comandos
    {
        public int id, quantidade;
        public string descricao;
        public double valor;

        Conexao obj = new Conexao();

        public void Cadastrar()
        {

            string inserir = $@"insert into produtos values ('{id}', '{descricao}', '{valor}', '{quantidade}');";
            obj.ExecutarComando(inserir);

        }

        public DataTable Listar()     //Requer: using System.Data;
        {
            string listar = $"SELECT * FROM produtos; ";
            return obj.ExecutarConsulta(listar);
        }
        public void Excluir()
        {
            string deletar = $"DELETE FROM produtos WHERE id = '{id}'; ";
            obj.ExecutarComando(deletar);
        }

        public void Alterar()
        {
            string alterar = $"UPDATE produtos SET descricao = '{descricao}', valor = '{valor}', quantidade = '{quantidade}' WHERE id = '{id}'";
            obj.ExecutarComando(alterar);
        }
    }
}
