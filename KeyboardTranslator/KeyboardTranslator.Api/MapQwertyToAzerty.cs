using System.Linq;

namespace KeyboardTranslator.Api
{
    public class MapQwertyToAzerty : Map
    {

        public override char GetCharByAssci(int ascci)
        {
            return QwertyAzertyMappingTable.Single(k => k.Key == ascci).Value.Key;
        }

        public override char GetCharByChar(char input)
        {
            return QwertyAzertyMappingTable.Select(m => m.Value).Single(d => d.Key == input).Value;

        }
    }
}
