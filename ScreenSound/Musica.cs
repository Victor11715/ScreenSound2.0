﻿class Musica 
{
    public string nome;
    public string artista;
    public int duracao;
    public bool Disponivel { get; set; }

    public void ExibirFicaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        
        if (disponivel)
        {
            Console.WriteLine("Disponível no plano.\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+\n");
        }
    }
}