using System;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando um identificador global único - guid
            //var id = Guid.NewGuid();
            //id.ToString();
			//id = new Guid("120835ae-8b68-4800-bc5e-a26d5e02d861");
			//if(id == Guid.NewGuid())
            //Console.WriteLine(id.ToString().Substring(0,8));

			//interpolação de strings
			//var price = 10.2;
			//var texto = "0 preço do produto é " + price + " apenas na promoção.";
			//var texto = string.Format("O preço do produto é {0} apenas na promoção", price);
			//var texto = $"O preço do produto é {price} apenas na promoção";
			//Console.WriteLine(texto);
			
			//comparação de strings - compareto/contains
			//var texto = "Testando";
			//Console.WriteLine(texto.CompareTo("Testando"));
			//Console.WriteLine(texto.CompareTo("testando"));
			//var texto = "Esse texto é um teste";
			//Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
			//Console.WriteLine(texto.Contains(null));
			
			//StartsWith/EndsWith
			//var texto = "Este texto é um teste";
			//Console.WriteLine(texto.StartsWith("Este"));
			//Console.WriteLine(texto.StartsWith("este"));
			//Console.WriteLine(texto.StartsWith("texto"));
			//Console.WriteLine(texto.EndsWith("teste"));
			//Console.WriteLine(texto.EndsWith("Teste"));
			//Console.WriteLine(texto.EndsWith("xpro"));
			
			//Equals
			//var texto = "Este texto é um teste";
			//Console.WriteLine(texto.Equals("Este"));
			//Console.WriteLine(texto.Equals("este"));
			//Console.WriteLine(texto.Contains("este", StringComparison.OrdinalIgnoreCase));
	        
			//Indices - IndexOf/LastIndexOf
			//var texto = "Este texto é um teste";
			//Console.WriteLine(texto.IndexOf("é"));
			//Console.WriteLine(texto.LastIndexOf("s"));
			
			//Metodos adicionais - ToLower/ToUpper/Insert/Remove/Length
			//var texto = "Este texto é um teste";
			//Console.WriteLine(texto.ToLower());
			//Console.WriteLine(texto.ToUpper());
			//Console.WriteLine(texto.Insert(5, "AQUI"));
			//Console.WriteLine(texto.Remove(5, 5));
			//Console.WriteLine(texto.Length);
			
			//Manipulando Strings
			//var texto = " Este texto é um teste ";
			//Console.WriteLine(texto.Replace("Este", "isto"));
			//var divisao = texto.Split(" ");
			//Console.WriteLine(divisao[0]);
			//Console.WriteLine(divisao[1]);
			//Console.WriteLine(divisao[2]);
			//Console.WriteLine(divisao[3]);
            //var resultado = texto.Substring(5, 5);
			//Console.WriteLine(resultado);
			//Console.WriteLine(texto.Trim());
			
			//StringBuilder
			//var texto = new StringBuilder();
			//texto.Append("Este texto é um teste");
			//texto.Append("é um teste");
			//texto.Append("Este texto");
			//texto.Append("Este um teste");
			//Console.WriteLine(texto);


        }
    }
}