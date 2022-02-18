using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Prático
{
    public class Serie : EntidadeBase
    {

        //Atributos da Série
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private int ClassificacaoIndicativa { get; set; }
        private int Temporadas { get; set; }
        private string Elenco { get; set; }
        private string Diretor { get; set; }
        private bool Excluido { get; set; }

        //Métodos
        public Serie(int id, Genero Genero, string Titulo, string Descricao, int Ano, int ClassificacaoIndicativa, int Temporadas, string Elenco, string Diretor)
        {
            this.Id = id;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.ClassificacaoIndicativa = ClassificacaoIndicativa;
            this.Temporadas = Temporadas;
            this.Elenco = Elenco;
            this.Diretor = Diretor;
            this.Excluido = false;
        }


        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Classificação Indicativa: " + this.ClassificacaoIndicativa + Environment.NewLine;
            retorno += "Temporadas: " + this.Temporadas + Environment.NewLine;
            retorno += "Elenco: " + this.Elenco + Environment.NewLine;
            retorno += "Diretor: " + this.Diretor + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido + Environment.NewLine;
            return retorno;


        }

        public string retornaTitulo ()
        {
            return this.Titulo;
        }
        
        public int  retornaId()
        {
            return this.Id;
        }

         public void Excluir()
        {
            this.Excluido = true;
        }

        public int retornaAno()
        {
            return this.Ano;
        }

        public Genero retornaGenero()
        {
            return this.Genero;
        }

        public int retornaTemporadas()
        {
            return this.Temporadas;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }


    }
}
