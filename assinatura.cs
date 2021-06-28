public override void Imprimir()
    {
        Console.WriteLine("Software:\t{0}", this.Nome); 
        Console.WriteLine("Mensalidade:\tR$ {0:0.00}", this._preco);
        Console.WriteLine("Duração:\t{0}", this._duracao);
        Console.WriteLine("Valor:\t\tR$ {0:0.00}", this.CalculaValorTotal());
    }
}
}
