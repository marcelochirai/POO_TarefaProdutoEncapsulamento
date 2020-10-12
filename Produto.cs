using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProdutoPS5
{
    class Produto
    {
        //Teste de encapsulamento
        //Declaração de variáveis como private
        private string _nome;
        private double _preco;
        int _quantidade;

        //Cosntrutor padrão
        public Produto()
        {

        }
        
        //Construtor personalizado
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            _quantidade = _quantidade - quantidade;
        }

        //Utilização do GET e SET
        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome!=null && nome.Length > 1)  //Define regras de entrada
            {
                _nome = nome;
            }
        }
        
        //Retorno dos valores preço do produto e quantidade sem interferência do usuário
        public double GetPreco()
        {
            return _preco;
        }

        public int GetQnt()
        {
            return _quantidade;
        }

        public override string ToString()
        {
            return _nome+",R$"+_preco.ToString("F2", CultureInfo.InvariantCulture)+","+_quantidade
                +"unidades, Total: R$ "+ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }

    }

}
