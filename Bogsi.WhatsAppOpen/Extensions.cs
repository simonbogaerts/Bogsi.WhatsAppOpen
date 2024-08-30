namespace Bogsi.WhatsAppOpen;

internal static class Extensions
{
    public static string ValidateInput(this string input)
    {
        var result = input
            .Trim()
            .Replace(" ", string.Empty)
            .Replace("+", string.Empty);

        return result;
    }
}
