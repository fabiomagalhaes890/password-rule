namespace Question1.Domain
{
    public class Password
    {
        public virtual int Value { get; set; }
        
        public Password(int password) => Value = password;
    }
}
