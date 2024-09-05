internal class Program {
    static void Main(string[] args) {
        // Números responsáveis pela sequência de Fibonacci
        int n1 = 0;
        int n2 = 1;
        int n3 = 0;

        // Validação da entrada do usuário
        Console.Write("Informe um número: ");
        int number = 0;
        if (int.TryParse(Console.ReadLine(), out number)) {

            // Laço de repetição até o número informado ser igual ao último
            // número da soma ou ser maior que o último número da soma
            while(true) {

                if(n1 == number) {
                    Console.WriteLine($"O número {number} pertence a sequência de Fibonacci.");
                    break;
                }
                else if(n1 > number) {
                    Console.WriteLine($"O número {number} não pertence a sequência de Fibonacci.");
                    break;
                }
                n3 = n1 + n2;
                n1 = n2; n2 = n3;
            }
        }
        else {
            Console.WriteLine("Digite um número!");
        }

        Console.Write("Aperte ENTER para continuar....");
        Console.ReadLine();
    }
}
    