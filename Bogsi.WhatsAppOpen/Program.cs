using System.Diagnostics;
using Bogsi.WhatsAppOpen;

var isBye = false;
var whatsAppUrl = "https://wa.me/";

Console.WriteLine(Constants.Line);
Console.WriteLine(Constants.StartUpMessage);
Console.WriteLine(Constants.Line);

do
{
    Console.WriteLine(Constants.ProvideNumber);

    var arguments = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(arguments))
    {
        Console.WriteLine(Constants.Empty);
        continue;
    }

    if (arguments.ToLowerInvariant().Equals(Constants.Bye))
    {
        isBye = true;

        Console.WriteLine(Constants.Goodbye);
        continue;
    }

    arguments = arguments.ValidateInput();

    Process.Start(new ProcessStartInfo
    {
        FileName = $"{whatsAppUrl}{arguments}",
        UseShellExecute = true
    });

} while (!isBye);
