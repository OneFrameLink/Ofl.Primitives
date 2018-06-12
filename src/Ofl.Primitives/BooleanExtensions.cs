namespace Ofl
{
    public class BooleanExtensions
    {
        public static bool? TryParse(string value)
        {
            // If success, return the output.
            if (bool.TryParse(value, out var result)) return result;

            // Return null.
            return null;
        }
    }
}
