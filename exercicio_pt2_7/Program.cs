using Microsoft.VisualBasic;

int opcao = -1;

do
{

    Console.WriteLine($"------------------------------------------------");
    Console.WriteLine($"                 Bem Vindo                      ");
    Console.WriteLine($"                    ao                          ");
    Console.WriteLine($"               Educarequina Food                    ");
    Console.WriteLine($"------------------------------------------------");


    Console.WriteLine($"");
    Console.WriteLine($"                 Escolha uma das opções           ");

    Console.WriteLine($"");
    Console.WriteLine($" 1) Hot holl------------------------------------$29,90");
    Console.WriteLine($" 2) Temaki--------------------------------------$10,00");
    Console.WriteLine($" 3) Sashimi-------------------------------------$19,50");
    Console.WriteLine($" 4) Yakisoba------------------------------------$20,00");
    Console.WriteLine($" 5) Guioza--------------------------------------$25,90  (10 unidades)");
    Console.WriteLine($" 6) shimeji-------------------------------------$29,90");
    Console.WriteLine($"    sair ");
    Console.Write($"    Opção: ");


    opcao = int.Parse(System.Console.ReadLine());




    switch (opcao)
    {
        case 1:
            HotHoll();
            break;

        case 2:
            Temaki();

            break;

        case 3:
            Sashimi();

            break;

        case 4:
            Yakisoba();

            break;

        case 5:

            Guioza();

            break;

        case 6:
            shimeji();

            break;

    
        default:

            Console.Write($"    Opção invalida ");
            break;
    }
    System.Console.WriteLine($"Digite ENTER para continuar...");
    Console.ReadLine();
} while (opcao != 0);

void HotHoll ()
{
    Console.WriteLine($" 1) Hot holl------------------------------------$29,90");
}

void Temaki ()
{
    Console.WriteLine($" 2) Temaki--------------------------------------$10,00");
}

void Sashimi ()
{
          Console.WriteLine($" 3) Sashimi-------------------------------------$19,50");
}

void Yakisoba ()
{
    Console.WriteLine($" 4) Yakisoba------------------------------------$20,00");
}

void Guioza ()
{
    Console.WriteLine($" 5) Guioza--------------------------------------$25,90  (10 unidades)");

}

void shimeji ()
{    
    Console.WriteLine($" 6) shimeji-------------------------------------$29,90");
         
}
