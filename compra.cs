using System;
using System.Collections.Generic;

namespace aula14
{
	public class Compra:IImprimivel
	{

        protected Estoque _estoque;
        protected Cliente _cliente;
        protected Carrinho _carrinho;

		public Estoque Estoque
        {
			get { return this._estoque; }
			set
            {
				_estoque = value;
            }
        }

        public Cliente Cliente
        {
            get { return this._cliente; }
        }

        public Carrinho Carrinho
        {
            get { return this._carrinho; }
        }

        public Compra (Cliente cliente, Carrinho carrinho, Estoque estoque)
        {
            this._carrinho = carrinho;
            this._cliente = cliente;
            this._estoque = estoque;
		}

        public void Imprimir()
        {
            foreach(var itens in _estoque.Catalogo)
            {
                Cliente.Imprimir();
                Carrinho.ImprimirCarrinho();
            }
        }

    }
}