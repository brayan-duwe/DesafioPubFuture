using System;
using System.Globalization;

namespace DesafioPubFuture
{
    class Receitas
    {
        public string Nome; 
        public string Descricao;
        public string TipoReceita;
        public static string Remover;
        public int Itens;
        public int TipoConta;
        public double Preco;
        public DateTime DataRecebimento;
        public DateTime DataEsperada;

       
        
       

        public Receitas(string nome, int itens, double preco, DateTime dataR, DateTime dataE, string descricao, int tipoconta, string tipoReceita)
        {
            Nome = nome;
            Itens = itens;
            Preco = preco;
            DataRecebimento = dataR;
            DataEsperada = dataE;
            Descricao = descricao;
            TipoConta = tipoconta;
            TipoReceita = tipoReceita;

        }
        public override string ToString()
        {
            return "Valor: " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + "Data de recebimento:  " + DataRecebimento.ToString(CultureInfo.InvariantCulture) + ", "
                + "Data de recebimento esperada: " + DataEsperada.ToString(CultureInfo.InvariantCulture) + ", "
                + "Descrição: " + Descricao + ", "
                + "Tipo da conta: " + TipoConta + ", "
                + "Tipo de receita: " + TipoReceita;
        }



    }
}
