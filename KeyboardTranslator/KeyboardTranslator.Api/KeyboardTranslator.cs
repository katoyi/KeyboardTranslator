
using System;
using System.Linq;

namespace KeyboardTranslator.Api
{
    public static class KeyboardTranslator
    {
        public static char? ToAzertyChar(char? qwertyChar = null, int? ascii = null)
        {
            Map map = new MapQwertyToAzerty();
            if (ascii.HasValue)
                return map.GetCharByAscci(ascii.Value);
            if (qwertyChar.HasValue)
                return map.GetCharByChar(qwertyChar.Value);
            return null;
        }

        public static string ToAzerty(string qwertyString)
        {
            var result = string.Empty;
            if (string.IsNullOrEmpty(qwertyString))
                return null;
            var arrayOfChar = qwertyString.ToCharArray();
            foreach (var charRes in arrayOfChar.Select(c => ToAzertyChar(c)))
            {
                if (!charRes.HasValue)
                    throw new Exception("Unknown char");
                result += charRes.Value;
            }
            return result;
        }

        public static char? ToQwertyChar(char? azertyChar = null, int? ascii = null)
        {
            Map map = new MapAzertyToQwerty();
            if (ascii.HasValue)
                return map.GetCharByAscci(ascii.Value);
            if (azertyChar.HasValue)
                return map.GetCharByChar(azertyChar.Value);
            return null;
        }

        public static string ToQwerty(string azertyString)
        {
            var result = string.Empty;
            if (string.IsNullOrEmpty(azertyString))
                return null;
            var arrayOfChar = azertyString.ToCharArray();
            foreach (var charRes in arrayOfChar.Select(c => ToQwertyChar(c)))
            {
                if (!charRes.HasValue)
                    throw new Exception("Unknown char");
                result += charRes.Value;
            }
            return result;

        }
    }
}
