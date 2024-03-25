namespace LogicaRocketseat;
public class Program
{
    enum Niveis
    {
        Baixo = 1,
        Medio = 2, 
        Alto = 3
    }

    public static void Main()
    {
        //Console.WriteLine("Primeiras aulas onde fazemos hello world e concatenação");
        //string texto = "Hello World!";
        //string texto2 = "Meu {0} é {1}";

        //Console.WriteLine($"{texto} {texto2}");
        //char cortaTexto = texto2[0];
        //Console.WriteLine(cortaTexto);

        //string resultado = string.Format(texto2, "nombre", "Matheus Alexandre");
        //Console.WriteLine(resultado);

        //Console.WriteLine();
        //Console.WriteLine();
        //Console.WriteLine("Segunda aula onde temos data e hora");

        //DateTime dateTime = DateTime.UtcNow;

        //Console.WriteLine(dateTime);

        //Console.WriteLine();
        //Console.WriteLine();
        //Console.WriteLine("Terceira aula onde vemos enums");
        //Niveis niveis = Niveis.Baixo;
        //Console.WriteLine(niveis);

        //int nivel = (int)Niveis.Alto;
        //Console.WriteLine(nivel);

        //Console.WriteLine();
        //Console.WriteLine();
        //Console.WriteLine("Quarta aula onde vemos arrays");

        //int[] array = new int[10];
        //Console.WriteLine(array.Length);

        //for (int i = 0; i < array.Length; i++)
        //{
        //    array[i] = i +1;
        //}

        //foreach (var item in array)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine("");
        //Console.WriteLine("Exercícios");
        //List<int> list = [10, 20, 30, 40, 50];

        //int soma = 0;
        //foreach (var item in list)
        //{
        //    soma += item;
        //}
        //Console.WriteLine(soma);


        //Console.WriteLine("Escreva 3 numeros inteiros");
        //Console.WriteLine("Primeiro Numero");
        //int primeiroNumero = int.Parse(Console.ReadLine());

        //Console.WriteLine("Segundo numero");
        //int segundoNumero = int.Parse(Console.ReadLine());

        //Console.WriteLine("Terceiro Numero");
        //int terceiroNumero = int.Parse(Console.ReadLine());

        //int somaTudo = primeiroNumero + segundoNumero + terceiroNumero;
        //Console.WriteLine(somaTudo);


        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Segundo exercício");

        string fraseAleatoria = "What is Lorem Ipsum?\r\nLorem Ipsum is simply dummy text of the printing and typesetting industry. " +
            "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. " +
            "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
            "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\r\n\r\nWhy do we use it?\r\nIt is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. " +
            "The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. " +
            "Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n\r\n\r\nWhere does it come from?\r\nContrary to popular belief, Lorem Ipsum is not simply random text. " +
            "It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. " +
            "Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.\r\n\r\nWhere can I get some?\r\nThere are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc. ";

        string[] vetorDePalavras = fraseAleatoria.Split(new char[] { ',', ';', '.', '?', '!', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> dicionarioDePalavras = new Dictionary<string, int>();

        foreach (var item in vetorDePalavras)
        {
            string palavrasEmMinusculo = item.ToLower();
            if(dicionarioDePalavras.ContainsKey(palavrasEmMinusculo))
            {
                dicionarioDePalavras[palavrasEmMinusculo]++;
            }
            else
            {
                dicionarioDePalavras[palavrasEmMinusculo] = 1;
            }
        }

        int numeroDeRepeticoes = 0;
        string palavraMaisRepetida = "";

        foreach (var palavrinha in dicionarioDePalavras)
        {
            if(palavrinha.Value > numeroDeRepeticoes)
            {
                numeroDeRepeticoes = palavrinha.Value;
                palavraMaisRepetida = palavrinha.Key;
            }
        }

        Console.WriteLine($"A palavra mais repetida foi {palavraMaisRepetida} com {numeroDeRepeticoes}");

    }
}
