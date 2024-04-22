Musica musica1 = new Musica();
musica1.nome = "Roxane";
musica1.artista = "The Police";
musica1.duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

Musica musica2 = new Musica();
musica2.nome = "Vertigo";
musica2.artista = "U2";
musica2.duracao = 367;
musica2.Disponivel = false;
Console.WriteLine(musica2.Disponivel);

musica1.ExibirFicaTecnica();
musica2.ExibirFicaTecnica();