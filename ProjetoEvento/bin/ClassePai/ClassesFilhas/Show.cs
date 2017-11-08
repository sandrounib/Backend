using System;
namespace ProjetoEvento.bin.ClassePai.ClassesFilhas
{
    public class Show : Evento
    {
        public string Artista { get; set; }
        public string GeneroMusical { get; set; }

        public Show(Parameters)
        {
            
        }

        public Show(string titulo,string local, int lotacao,string duracao,int classificacao,DateTime data, string artista, string generoMusical)
        {
            base.Titulo = titulo;
            base.Local = local;
            base.Lotacao = lotacao;
            base.Duracao = duracao;
            base.Classificacao = classificacao;
            base.Data = data;
            this.Artista = artista;
            this.GeneroMusical = generoMusical;
            
        }
        
                
    }
}