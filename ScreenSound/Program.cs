Album albumDoQueen = new Album();
albumDoQueen.Nome = "A Night at the Opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of My Life";
musica1.Duracao = 213;
musica1.Artista = "Barões da Pisadinha";

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicasDoAlbum();

Banda queen = new Banda();
queen.Nome = "Queen";
queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();