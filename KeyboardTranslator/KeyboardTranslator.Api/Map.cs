using System.Collections.Generic;

namespace KeyboardTranslator.Api
{
    public abstract class Map
    {
        //the key of dictionary is the ascii code of the first value in KeyPairValue which is Qwerty char
        public readonly Dictionary<int, KeyValuePair<char, char>> QwertyAzertyMappingTable = new Dictionary
            <int, KeyValuePair<char, char>>
        {
            {96, new KeyValuePair<char, char>('`', '²')},
            {49, new KeyValuePair<char, char>('1', '&')},
            {50, new KeyValuePair<char, char>('2', 'é')},
            {51, new KeyValuePair<char, char>('3', '"')},
            {52, new KeyValuePair<char, char>('4', '\'')},
            {53, new KeyValuePair<char, char>('5', '(')},
            {54, new KeyValuePair<char, char>('6', '-')},
            {55, new KeyValuePair<char, char>('7', 'è')},
            {56, new KeyValuePair<char, char>('8', '_')},
            {57, new KeyValuePair<char, char>('9', 'ç')},
            {48, new KeyValuePair<char, char>('0', 'à')},
            {45, new KeyValuePair<char, char>('-', ')')},
            {61, new KeyValuePair<char, char>('=', '=')},


            {126, new KeyValuePair<char, char>('~', ' ')},
            {33, new KeyValuePair<char, char>('!', '1')},
            {64, new KeyValuePair<char, char>('@', '2')},
            {35, new KeyValuePair<char, char>('#', '3')},
            {36, new KeyValuePair<char, char>('$', '4')},
            {37, new KeyValuePair<char, char>('%', '5')},
            {94, new KeyValuePair<char, char>('^', '6')},
            {38, new KeyValuePair<char, char>('&', '7')},
            {42, new KeyValuePair<char, char>('*', '8')},
            {40, new KeyValuePair<char, char>('(', '9')},
            {41, new KeyValuePair<char, char>(')', '0')},
            {95, new KeyValuePair<char, char>('_', '°')},
            {43, new KeyValuePair<char, char>('+', '+')},


            {113, new KeyValuePair<char, char>('q', 'a')},
            {119, new KeyValuePair<char, char>('w', 'z')},
            {101, new KeyValuePair<char, char>('e', 'e')},
            {114, new KeyValuePair<char, char>('r', 'r')},
            {116, new KeyValuePair<char, char>('t', 't')},
            {121, new KeyValuePair<char, char>('y', 'y')},
            {117, new KeyValuePair<char, char>('u', 'u')},
            {105, new KeyValuePair<char, char>('i', 'i')},
            {111, new KeyValuePair<char, char>('o', 'o')},
            {112, new KeyValuePair<char, char>('p', 'p')},
            {91, new KeyValuePair<char, char>('[', '^')},
            {93, new KeyValuePair<char, char>(']', '$')},
            {92, new KeyValuePair<char, char>('\\', '*')},

            {81, new KeyValuePair<char, char>('Q', 'A')},
            {87, new KeyValuePair<char, char>('W', 'Z')},
            {69, new KeyValuePair<char, char>('E', 'E')},
            {82, new KeyValuePair<char, char>('R', 'R')},
            {84, new KeyValuePair<char, char>('T', 'T')},
            {89, new KeyValuePair<char, char>('Y', 'Y')},
            {85, new KeyValuePair<char, char>('U', 'U')},
            {73, new KeyValuePair<char, char>('I', 'I')},
            {79, new KeyValuePair<char, char>('O', 'O')},
            {80, new KeyValuePair<char, char>('P', 'P')},
            {123, new KeyValuePair<char, char>('{', '¨')},
            {125, new KeyValuePair<char, char>('}', '£')},
            {124, new KeyValuePair<char, char>('|', 'µ')},

            {97, new KeyValuePair<char, char>('a', 'q')},
            {115, new KeyValuePair<char, char>('s', 's')},
            {100, new KeyValuePair<char, char>('d', 'd')},
            {102, new KeyValuePair<char, char>('f', 'f')},
            {103, new KeyValuePair<char, char>('g', 'g')},
            {104, new KeyValuePair<char, char>('h', 'h')},
            {106, new KeyValuePair<char, char>('j', 'j')},
            {107, new KeyValuePair<char, char>('k', 'k')},
            {108, new KeyValuePair<char, char>('l', 'l')},
            {59, new KeyValuePair<char, char>(';', 'm')},
            {39, new KeyValuePair<char, char>('\'', 'ù')},

            {65, new KeyValuePair<char, char>('A', 'Q')},
            {83, new KeyValuePair<char, char>('S', 'S')},
            {68, new KeyValuePair<char, char>('D', 'D')},
            {70, new KeyValuePair<char, char>('F', 'F')},
            {71, new KeyValuePair<char, char>('G', 'G')},
            {72, new KeyValuePair<char, char>('H', 'H')},
            {74, new KeyValuePair<char, char>('J', 'J')},
            {75, new KeyValuePair<char, char>('K', 'K')},
            {76, new KeyValuePair<char, char>('L', 'L')},
            {58, new KeyValuePair<char, char>(':', 'M')},
            {34, new KeyValuePair<char, char>('"', '%')},

            {122, new KeyValuePair<char, char>('z', 'w')},
            {120, new KeyValuePair<char, char>('x', 'x')},
            {99, new KeyValuePair<char, char>('c', 'c')},
            {118, new KeyValuePair<char, char>('v', 'v')},
            {98, new KeyValuePair<char, char>('b', 'b')},
            {110, new KeyValuePair<char, char>('n', 'n')},
            {109, new KeyValuePair<char, char>('m', ',')},
            {44, new KeyValuePair<char, char>(',', ';')},
            {46, new KeyValuePair<char, char>('.', ':')},
            {47, new KeyValuePair<char, char>('/', '!')},


            {90, new KeyValuePair<char, char>('Z', 'W')},
            {88, new KeyValuePair<char, char>('X', 'X')},
            {67, new KeyValuePair<char, char>('C', 'C')},
            {86, new KeyValuePair<char, char>('V', 'V')},
            {66, new KeyValuePair<char, char>('B', 'B')},
            {78, new KeyValuePair<char, char>('N', 'N')},
            {77, new KeyValuePair<char, char>('M', '?')},
            {60, new KeyValuePair<char, char>('<', '.')},
            {62, new KeyValuePair<char, char>('>', '/')},
            {63, new KeyValuePair<char, char>('?', '§')}
        };
        public abstract char? GetCharByAscci( int ascci);
        public abstract char? GetCharByChar(char input);
    }
}
