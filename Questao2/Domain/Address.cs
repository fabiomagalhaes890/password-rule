namespace Question2.Domain
{
    public class Address
    {
        public virtual int Value { get; set; } = 0;
        public virtual int Position { get; set; } = 0;

        public void Increment(string content)
        {
            if (content[0..2] == "20")
                Value += GetValueToIncrement(2, content);
            else if (content[0..1] == "5")
                Position += GetValueToIncrement(1, content) - 1;
        }

        private static int GetValueToIncrement(int start, string value)
        {
            var increment = value[start..value.Length];
            return int.Parse(increment);
        }
    }
}
