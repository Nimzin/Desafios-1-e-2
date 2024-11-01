
public class Program
{
    

   static void Main() 
    { 
    
        //DESAFIO 1
        int indice = 13;
        int soma = 0;
        int k = 0;

        while (k < indice)  //Loop para que enquanto K for menor que o indice os valores sejam adicionados em soma.
        {
            k = (k + 1);
            soma = soma + k;
        }

        Console.WriteLine("(1° Desafio) O valor dew soma é: " +  soma); //Impressão do resultado que será 91.


        //DESAFIO 2
        
        Console.Write("\n(2° Desafio) Digite um numero: ");
        int numeroDigitado = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        int fibonacci = 0;

        bool pertence = false; 

        while (fibonacci <= numeroDigitado) //Loop p/ calcular a sequencia até que o numero seja igual ou maior que o numero digitado.
        {
            if (fibonacci == numeroDigitado) //Condição p/ caso seja igual o da sequencia ele pertence.
            {
                pertence = true;
                break;
            }

            fibonacci = a + b;      // Soma dos numeros começando de 0 + 1.
            a = b;                  //Atualiza o valor de a para que seja o ultimo valor de b.
            b = fibonacci;          //Atualiza o valor de b pegando o resultado da ultima soma dos dois numeros
        }
        if (pertence) //Impressão do resultado.
        {
            Console.WriteLine($"O número {numeroDigitado} pertence a sequencia");

        }
        else
        {
            Console.WriteLine($"O número {numeroDigitado} não pertence a sequencia");

        }

    }
}