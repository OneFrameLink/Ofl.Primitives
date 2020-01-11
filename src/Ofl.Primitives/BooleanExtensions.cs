namespace Ofl
{
    public class BooleanExtensions
    {
        public static bool? TryParse(string? value) =>
            bool.TryParse(value, out var result)
                ? result
                : (bool?) null;
    }
}
