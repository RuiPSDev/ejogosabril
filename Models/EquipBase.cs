using System.IO;

namespace E_Jogos.Models
{
    public class EquipBase
    {
        public void CriarPastaOuArquivo(string caminho)
        {
            // nome da pasta / NomeDoArquivo.csv

            string pasta = caminho.Split('/')[0];

            // se o diretorio não existir, criar a pasta
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            
            if(!File.Exists(caminho))
            {
                File.Create(caminho);
            }
        }
    }
}
