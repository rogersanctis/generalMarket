using System;

/// <summary>
/// Classe Produto com representação básica de um produto
/// </summary>
public class Produto
{
    public int id { get; set; }
    /*[MaxLength(80)]*/ public string nome { get; set; }
    public string descricao { get; set; }
    public char secao_id { get; set; }
    public decimal valor { get; set; }
    public string img { get; set; }
}