namespace Question1.Help.Extensions
{
    public static class IntExtensions
    {
        private const int _MIN = 184759;
        private const int _MAX = 856920;

        public static bool IsInsideTheRange(this int pass)
        {
            return pass >= _MIN && pass <= _MAX;
        }

        public static bool IsNumberOfCharacterValid(this int pass)
        {
            var stringPass = pass.ToString();

            var hasThreeCharacters = stringPass
                .GroupBy(x => x)
                .Where(g => g.Count() == 3)
                .Any();

            var hasTwoCharacters = stringPass
                .GroupBy(x => x)
                .Where(g => g.Count() == 2 || g.Count() > 3)
                .Any();

            return (hasThreeCharacters && hasTwoCharacters) 
                || (!hasThreeCharacters && hasTwoCharacters);
        }

        public static bool IsDecreasingRuleValid(this int pass)
        {
            var sorted = pass.ToString().ToArray();
            Array.Sort(sorted);

            var result = string.Join("", sorted);
            return int.Parse(result) == pass;
        }
    }
}
