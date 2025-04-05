class Album
{
      public Album(string nome)
      {
            Nome = nome;
      }
      private List<Musica> musicas = new List<Musica>();
      public string Nome { get; }
      public int DuracaoTotal => musicas.Sum(m => m.Duracao);

      public void AdicionarMusica(Musica musica)
      {
            musicas.Add(musica);
      }

      public void ExibirMusicasDoAlbum()
      {
            Console.WriteLine($"Musicas do álbum {Nome}:");
            foreach (var musica in musicas)
            {
                  Console.WriteLine($"Álbum: {musica.Nome} ({musica.Duracao} segundos)");
            }
            Console.WriteLine($"Duração total do álbum: {DuracaoTotal} segundos");
            Console.WriteLine($"Total de músicas: {musicas.Count}");
      }

}