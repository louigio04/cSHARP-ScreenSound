class Album
{
      private List<Musica> _musicas = new List<Musica>();
      public string Nome { get; set; }
      public int DuracaoTotal => _musicas.Sum(m => m.Duracao);

      public void AdicionarMusica(Musica musica)
      {
            _musicas.Add(musica);
      }

      public void ExibirMusicasDoAlbum()
      {
            Console.WriteLine($"Musicas do álbum {Nome}:");
            foreach (var musica in _musicas)
            {
                  Console.WriteLine($" - {musica.Nome} ({musica.Duracao} segundos)");
            }
            Console.WriteLine($"Duração total do álbum: {DuracaoTotal} segundos");
            Console.WriteLine($"Total de músicas: {_musicas.Count}");
      }

}