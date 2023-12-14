using VehicleManager.Foundation.Interfaces;

namespace VehicleManager.Foundation
{
    public class StringService : IStringService
    {
        public bool IsPalindrome(string s)
        {
            return s == ReverseString(s);
        }

        public string ReverseString(string s)
        {
            return new string(s.ToCharArray().Reverse().ToArray());
        }
    }
}
