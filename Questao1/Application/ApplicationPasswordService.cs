using Question1.Domain;
using Question1.Help.Extensions;

namespace Question1.Application
{
    public class ApplicationPasswordService
    {
        public static int CalculatePossibilitiesBetween(int min, int max)
        {
            var passwordList = new List<Password>();

            for (int password = min; password <= max; password++)
            {
                if (password.IsInsideTheRange()
                    && password.IsDecreasingRuleValid()
                    && password.IsNumberOfCharacterValid())
                    passwordList.Add(new Password(password));
            }

            return passwordList.Count();
        }
    }
}
