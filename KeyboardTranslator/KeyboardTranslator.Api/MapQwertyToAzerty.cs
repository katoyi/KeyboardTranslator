using System.Linq;

namespace KeyboardTranslator.Api
{
    public class MapQwertyToAzerty : Map
    {

        public override char? GetCharByAscci(int ascci)
        {
            var _char = QwertyAzertyMappingTable.FirstOrDefault(k => k.Key == ascci);
            if (!_char.Equals(null))
            {
                return _char.Value.Value;
            }
            return null;
        }

        public override char? GetCharByChar(char input)
        {
            var _char = QwertyAzertyMappingTable.Select(m => m.Value).SingleOrDefault(d => d.Key == input);
            if (!_char.Equals(null))
            {
                return _char.Value;
            }
            return null;
        }
    }
}
