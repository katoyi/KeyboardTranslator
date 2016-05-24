using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyboardTranslator.Api
{
    public class MapAzertyToQwerty : Map
    {
        public override char? GetCharByAscci(int ascci)
        {
            var qwertyChar = QwertyAzertyMappingTable.SingleOrDefault(k => k.Key == ascci);
            if (!qwertyChar.Equals(null))
            {
                var _char = qwertyChar.Value.Key;
                //now we look for the char corresponding to azerty table
                var azerty = QwertyAzertyMappingTable.FirstOrDefault(d => d.Value.Value == _char);
                if (!azerty.Equals(null))
                {
                    return azerty.Value.Key;
                }
            }
            return null;
        }

        public override char? GetCharByChar(char input)
        {
            var qwertyChar = QwertyAzertyMappingTable.FirstOrDefault(k => k.Value.Value == input);
            if (qwertyChar.Equals(null))
                return null;
            return qwertyChar.Value.Key;
        }
    }
}
