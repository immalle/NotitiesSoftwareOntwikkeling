using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DobbelSpel2
{
    public class Console2
    {
        public static void Write(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(str);
            Console.ResetColor();
        }

        public static void WriteLine(string str, ConsoleColor color)
        {
            Console2.Write(str, color);
            Console.WriteLine();
        }

        enum LexerState  {
            BEFORE,
            ACCENTED,
            AFTER,
            FIRST_OPENING_BRACE,
            SECOND_OPENING_BRACE,
            FIRST_CLOSING_BRACE,
            SECOND_CLOSING_BRACE
        }

        // Parset een Mustache-achtige-template-string (met max. 1 parameter) en print deze op de console
        // met de parameter in de accentedColor.
        public static void Write(string str, ConsoleColor basicColor, ConsoleColor accentedColor)
        {
            string before = "";
            string accented = "";
            string after = "";

            LexerState ps = LexerState.BEFORE;

            foreach (char c in str)
            {
                switch(ps) {
                    case LexerState.BEFORE:
                        if (c != '{')
                        {
                            before += c;
                        }
                        else
                        {
                            ps = LexerState.FIRST_OPENING_BRACE;
                        }
                        break;
                    case LexerState.FIRST_OPENING_BRACE:
                        if (c == '{')
                        {
                            ps = LexerState.SECOND_OPENING_BRACE;
                        } 
                        else
                        {
                            ps = LexerState.BEFORE;
                            before += '{';
                            before += c;
                        }
                        break;
                    case LexerState.SECOND_OPENING_BRACE:
                        if (c == '}')
                        {
                            ps = LexerState.FIRST_CLOSING_BRACE;
                        } 
                        else 
                        {
                            ps = LexerState.ACCENTED;
                            accented += c;
                        }
                        break;
                    case LexerState.ACCENTED:
                        if (c == '}')
                        {
                            ps = LexerState.FIRST_CLOSING_BRACE;
                        } 
                        else 
                        {
                            accented += c;
                        }
                        break;
                    case LexerState.FIRST_CLOSING_BRACE:
                        if (c == '}')
                        {
                            ps = LexerState.SECOND_CLOSING_BRACE;
                        } 
                        else 
                        {
                            accented += '}';
                            accented += c;
                        }
                        break;
                    case LexerState.SECOND_CLOSING_BRACE:
                        ps = LexerState.AFTER;
                        after += c;
                        break;
                    case LexerState.AFTER:
                        after += c;
                        break;
                }
            }

            Console2.Write(before, basicColor);
            Console2.Write(accented, accentedColor);
            Console2.WriteLine(after, basicColor);
        }

        public static void WriteLine(string str, ConsoleColor basicColor, ConsoleColor accentedColor)
        {
            Console2.Write(str, basicColor, accentedColor);
        }
        
    }
}
