using Question2.Domain;

namespace Question2.Application
{
    public class ApplicationAddressService
    {
        public static int SearchAddress()
        {
            var _textFile = @"../../../../instructions/commands.txt";

            if (File.Exists(_textFile))
            {
                var address = new Address();
                var content = File.ReadAllLines(_textFile);

                for (address.Position = 0; address.Position < content.Length; address.Position++)
                    address.Increment(content[address.Position]);

                return address.Value;
            }
            return 0;
        }
    }
}
