double n1, n2, n3;
string option;

do
{
    Console.WriteLine("Bem-vindo a calculadora");
    Console.WriteLine("\nEscolha uma opção: ");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("0 - Sair");
    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            n3 = n1 + n2;
            Console.WriteLine("Resultado: " + n3);
            Thread.Sleep(3000);

            Console.WriteLine("\nDeseja fazer outro cálculo? (S/N): ");
            string repeat = Console.ReadLine();
            if (repeat.ToUpper() != "S")
            {
                option = "0";
                Console.Clear();
            }
            else
            {
                Console.Clear();
            }
            break;

        case "2":
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo valor: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            n3 = n1 - n2;
            Console.WriteLine("\nResultado: " + n3);
            Thread.Sleep(3000);

            Console.WriteLine("\nDeseja fazer outro cálculo? (S/N): ");
            repeat = Console.ReadLine();
            if (repeat.ToUpper() != "S")
            {
                option = "0";
                Console.Clear();
            }
            else
            {
                Console.Clear();
            }
            break;

        case "3":
            Console.Clear();
            Console.WriteLine("\nDigite o primeiro valor: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo valor: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            n3 = n1 * n2;
            Console.WriteLine("Resultado: " + n3);
            Thread.Sleep(3000);

            Console.WriteLine("\nDeseja fazer outro cálculo? (S/N): ");
            repeat = Console.ReadLine();
            if (repeat.ToUpper() != "S")
            {
                option = "0";
                Console.Clear();
            }
            else
            {
                Console.Clear();
            }
            break;

        case "4":
            Console.Clear();
            Console.WriteLine("\nDigite o primeiro valor: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo valor: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            n3 = n1 / n2;
            Console.WriteLine("\nResultado: " + n3);
            Thread.Sleep(3000);

            Console.WriteLine("\nDeseja fazer outro cálculo? (S/N): ");
            repeat = Console.ReadLine();
            if (repeat.ToUpper() != "S")
            {
                option = "0";
                Console.Clear();
            }
            else
            {
                Console.Clear();
            }
            break;

        case "0":
            Console.Clear();
            Console.WriteLine("Volte sempre!");
            Thread.Sleep(3000);
            break;

        default:
            Console.Clear();
            Console.WriteLine("Opção inválida.");
            break;
    }
} while (option != "0");
Console.WriteLine("Volte sempre!");
Thread.Sleep(2500);
