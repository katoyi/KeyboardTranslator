using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyboardTranslator.Api
{
    public class MapAzertyToQwerty : Map
    {
        public override char GetCharByAssci(int ascci)
        {
            var qwertyChar = QwertyAzertyMappingTable.Single(k => k.Key == ascci).Value.Key;
            //now we look for the char corresponding to azerty table
            var azerty = QwertyAzertyMappingTable.FirstOrDefault(d => d.Value.Value == qwertyChar);
            return azerty.Value.Key;
        }

        public override char GetCharByChar(char input)
        {
            var qwertyChar = QwertyAzertyMappingTable.FirstOrDefault(k => k.Value.Value == input);
            return qwertyChar.Value.Key;
        }
    }
}
