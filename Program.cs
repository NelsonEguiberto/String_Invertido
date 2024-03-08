using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita ao usuário para inserir a string a ser invertida
        Console.WriteLine("Digite uma string para inverter os caracteres:");
        string inputString = Console.ReadLine();

        // Converte a string para um array de caracteres
        char[] charArray = inputString.ToCharArray();

        // Define os índices inicial e final para inverter os caracteres
        int startIndex = 0;
        int endIndex = charArray.Length - 1;

        // Loop para inverter os caracteres
        while (startIndex < endIndex)
        {
            // Troca os caracteres nas posições startIndex e endIndex
            char temp = charArray[startIndex];
            charArray[startIndex] = charArray[endIndex];
            charArray[endIndex] = temp;

            // Move os índices para os próximos caracteres a serem trocados
            startIndex++;
            endIndex--;
        }

        // Cria uma nova string a partir do array de caracteres invertido
        string reversedString = new string(charArray);

        // Exibe a string invertida
        Console.WriteLine($"String invertida: {reversedString}");

        Console.ReadLine(); // Aguarda o usuário pressionar Enter antes de fechar a janela
    }
}
