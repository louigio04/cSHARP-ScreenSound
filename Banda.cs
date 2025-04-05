class Banda
{
      public Banda(string nome)
      {
            Nome = nome;
      }
      private List<Album> albuns = new List<Album>();
      public string Nome { get; }

      public void AdicionarAlbum(Album album)
      {
            albuns.Add(album);
            Console.WriteLine($"Álbum {album.Nome} adicionado à banda {Nome}.");
      }

      public void ExibirDiscografia()
      {
            Console.WriteLine($"Discografia da banda {Nome}:");
            foreach (var album in albuns)
            {
                  Console.WriteLine($" - {album.Nome} ({album.DuracaoTotal} segundos)");
            }
      }
   
}	