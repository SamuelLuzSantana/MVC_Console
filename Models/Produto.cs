using System.Collections.Generic;
using System.IO;

namespace MCV_POO.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        
        private const string PATH = "Database/Produto.csv";

        public Produto(){
            
            //Verificar se a pasta existe
              
                string pasta = PATH.Split("/")[0];

                if(!Directory.Exists(pasta))
                {
                    Directory.CreateDirectory(pasta);
                }

            //Verificar se o Arquivo existe

                if (!File.Exists(PATH))
                {
                    File.Create(PATH);
                }


        }

        public List<Produto> Ler()
        {
            //Crio uma Lista para armazenar os itens 
            List<Produto> produtos = new List<Produto>();

            //Lemos as Linhas do CSV
            string[] linhas = File.ReadAllLines(PATH);

            //Percorremos as linhas do csv (onde esta armazenado os itens)
            foreach (string item in linhas)
            {
                //Separamos os elementos de cada linha
                string[] atributos = item.Split(";");

                //Passamos para um objeto do tipo Produto
                Produto prod = new Produto();

                prod.Codigo = int.Parse(atributos[0]);
                prod.Nome = (atributos[1]);
                prod.Preco = float.Parse(atributos [2]);

                produtos.Add(prod);
            }

            return produtos;
        }  
        
        
    }
}