using System;

namespace aula14
{
	public class Fornecedor:Imprimivel
	{
		private string _nome;
    private string _contato;
    private string _cnpj;
		private string _endereco;
	

		public string Nome
        {
			get { return this._nome; }
        }
    public string Contato
		{
			get { return this._contato; }
		}
    public string Cnpj
		{
			get { return this._cnpj; }
		}
		public string Endereco
		{
			get { return this._endereco; }
		}
		
		public Fornecedor (string nome,string contato, string cnpj, string endereco)
        {
			this._nome = nome;
      this._contato = contato;
      this._cnpj = cnpj;
      this._endereco = endereco;
	
        }

		public void Imprimir()
        {
			Console.WriteLine("Fornecedor:\t{0}", this.Nome);
      Console.WriteLine("contato:\t{0}", this.Contato);
			Console.WriteLine("cnpj:\t{0}", this.Cnpj);
      Console.WriteLine("endereco:\t{0}", this.Endereco);
			
		}
	}
}