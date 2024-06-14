using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encode_Decode
{
    internal class Programm
    {
        //Initialisiert das Alphabet Grid
        char[] AlphabetNew()
        {
            //Datengrid wird definiert und in ein Char Array geladen um damit Arbeiten zu können
            String abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZzyxwvutsrqponmlkjihgfedcba %?!+ç&/=-*:;.,1234567890äöüÄÖÜéèà[]{}()'^`~";
            char[] alpha = abc.ToCharArray();
            return alpha;
        }

        //Caesar Encoding
        public char[] encodeCaesar(String input)
        {
            //Werte werden geladen
            char[] alpha = AlphabetNew();

            //Random number zum verschieben in der Caesar Verschlüsselung
            Random rnd = new Random();
            int num = rnd.Next(0, alpha.Length - 1);

            //Input wird als Array Convertiert um die verschlüsselung zu berechnen
            char[] toEncode = input.ToCharArray();

            //Umwandlung von Buchstaben in Zahlen um mit diesen zu rechnen
            int[] letternumb = null;
            char[] encrypted = null;
            for (int i = 0; i < toEncode.Length; i++)
            {
                for (int d = 0; d < alpha.Length; d++)
                {
                    if (toEncode[i] == alpha[d])
                    {
                        //Arrays werden auf richtige Grösse angepasst
                        Array.Resize(ref letternumb, i + 1);
                        Array.Resize(ref encrypted, i + 1);
                        letternumb[i] = d;

                        // Verschiebung der Zahlen um Cäsar Verschlüsselung auszuführen
                        for (int e = 0; e < num; e++)
                        {
                            letternumb[i]--;
                            if (letternumb[i] < 0)
                            {
                                letternumb[i] = alpha.Length - 1;
                            }
                        }
                        //Buchstabenwerte des Verschlüsselten Textes in encrypted speichern
                        encrypted[i] = alpha[letternumb[i]];
                    }
                }
            }

            //Encrypt um 1 Vergrössern um Caesarschlüssel Verschlüsselt anzuhängen
            Array.Resize(ref encrypted, encrypted.Length + 1);
            encrypted[encrypted.Length - 1] = alpha[num];

            return encrypted;
        }

        //Schlüssel Encoding
        public char[] encodeKey(String input, String key)
        {
            //Werte werden geladen
            char[] alpha = AlphabetNew();

            //Input wird als Array Convertiert um die verschlüsselung zu berechnen
            char[] toEncode = input.ToCharArray();
            char[] secretKey = key.ToCharArray();
            char[] encrypted = null;

            //secretKey in Nummern abspeichern
            int[] keyCode = null;
            for (int i = 0; i < secretKey.Length; i++)
            {
                for (int d = 0; d < alpha.Length; d++)
                {
                    if (secretKey[i] == alpha[d])
                    {
                        Array.Resize(ref keyCode, i + 1);
                        keyCode[i] = d;
                    }
                }
            }

            //Key Verschlüsselung
            int count = 0;
            for (int i = 0; i < toEncode.Length; i++)
            {
                for (int d = 0; d < alpha.Length; d++)
                {
                    if (toEncode[i] == alpha[d])
                    {
                        int code = d;
                        for (int k = 0; k < keyCode[count]; k++)
                        {
                            code++;
                            if (code > alpha.Length - 1)
                            {
                                code = 0;
                            }
                        }
                        Array.Resize(ref encrypted, i + 1);
                        encrypted[i] = alpha[code];
                        count++;
                        if (count > keyCode.Length - 1)
                        {
                            count = 0;
                        }
                    }
                }
            }

            return encrypted;
        }


        //Caesar Decode Methode
        public char[] decodeCaesar(String input)
        {
            char[] encrypt = input.ToCharArray();

            //Alphabettabelle wird geladen
            char[] alpha = AlphabetNew();

            //Lade Letztes Zeichen aus Zeichenkette und berechne Cäsarschlüssel
            char cs = encrypt[encrypt.Length - 1];
            int csint = 0;
            for (int i = 0; i < alpha.Length; i++)
            {
                if (alpha[i] == cs)
                {
                    csint = i;
                }
            }

            //Berechnung der Buchstaben zu der Arrayzahl um Cäsarverschlüsselung zu entriffern
            int[] decryptNum = null;
            char[] decrypted = null;
            for (int i = 0; i < encrypt.Length - 1; i++)
            {
                for (int c = 0; c < alpha.Length; c++)
                {
                    if (encrypt[i] == alpha[c])
                    {
                        Array.Resize(ref decryptNum, i + 1);
                        decryptNum[i] = c;

                        //Zahlenwerte um Cäsarwert zurückrechnen
                        for (int d = 0; d < csint; d++)
                        {
                            decryptNum[i]++;
                            if (decryptNum[i] > alpha.Length - 1)
                            {
                                decryptNum[i] = 0;
                            }
                        }

                        //Zahlenwert in Buchstaben aus Array umwandeln
                        Array.Resize(ref decrypted, i + 1);
                        decrypted[i] = alpha[decryptNum[i]];

                    }
                }
            }

            return decrypted;
        }

        //Caesar Decode Methode
        public char[] decodeKey(String input, String key)
        {
            //Alphabettabelle wird geladen
            char[] alpha = AlphabetNew();

            char[] encrypt = input.ToCharArray();
            char[] secretKey = key.ToCharArray();

            //secretKey in Nummern abspeichern
            int[] keyCode = null;
            for (int i = 0; i < secretKey.Length; i++)
            {
                for (int d = 0; d < alpha.Length; d++)
                {
                    if (secretKey[i] == alpha[d])
                    {
                        Array.Resize(ref keyCode, i + 1);
                        keyCode[i] = d;
                    }
                }
            }

            char[] decrypted = null;

            //Key entschlüsselung
            int count = 0;
            for (int i = 0; i < encrypt.Length; i++)
            {
                for (int d = 0; d < alpha.Length; d++)
                {
                    if (encrypt[i] == alpha[d])
                    {
                        Array.Resize(ref decrypted, i + 1);
                        int code = d;
                        //key abzählen
                        for (int k = 0; k < keyCode[count]; k++)
                        {
                            code--;
                            if (code < 0)
                            {
                                code = alpha.Length - 1;
                            }
                        }
                        decrypted[i] = alpha[code];
                        count++;
                        if (count > keyCode.Length - 1)
                        {
                            count = 0;
                        }
                    }
                }
            }
            return decrypted;
        }


    }
}
