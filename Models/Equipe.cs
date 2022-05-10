using E_Jogos.Interface;
using System.Collections.Generic;
using System.IO;

namespace E_Jogos.Models
{
    public class Equipe : EquipBase, IEquipe
    {
        // : Herança
        // , Contrato
        public int idEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        // variáveis de dados da Equipe
        private const string caminhobd = "Database/equipe.csv";


        // Método construtor
        public Equipe()
        {
            // metodo da classe de herança EquipeBase
            CriarPastaOuArquivo(caminhobd);
        }

        // Criar uma função que vai receber o objeto EQUIPE, 
        // e vai retornar no formato de csv (string).

        private string Preparar(Equipe e)
        {
            return e.idEquipe + ";" + e.Nome + ";" + e.Imagem;  // pode ser esse, ou

            // return $"{e.idEquip};{e.Nome};{e.Imagem}";      // esse (você escolhe a melhor formatação da string de retorno)
        }


        public void Criar(Equipe novaEquipe)
        {
            // Array de strings = recebe o retorno de "Preparar" e grava na posição [0].
            string[] equipe_texto = { Preparar(novaEquipe) };

            // Adiciona uma nova linha no arquivo
            // Parâmetros: cominho do arquivo, string em formato array.
            File.AppendAllLines(caminhobd, equipe_texto);
        }

        public List<Equipe> LerEquipes()
        {
            List<Equipe> listaEquipes = new List<Equipe>();

            string[] linhas = File.ReadAllLines(caminhobd);

            foreach (string item in linhas)
            {
                // 1; nome da equipe; caminho da imagem

                string[] linhaEquipe = item.Split(';');

                Equipe equipeAtual = new Equipe();
                equipeAtual.idEquipe = int.Parse(linhaEquipe[0]);
                equipeAtual.Nome = linhaEquipe[1];
                equipeAtual.Imagem = linhaEquipe[2];

                listaEquipes.Add(equipeAtual);
            }
            return listaEquipes;

        }
    }
}
