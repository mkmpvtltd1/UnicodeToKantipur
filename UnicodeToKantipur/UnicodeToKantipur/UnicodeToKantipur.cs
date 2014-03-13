using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LanguageConvert
{
    public class UnicodeToKantipur
    {
        public static string ConvertUnicode(string nepaliUnicode)
        {
            Dictionary<string, string> l = new Dictionary<string, string>();
            l.Add("320", " ");        //
            l.Add("59", "c");         //अ
            l.Add("69", "cf");        //आ
            l.Add("79", "O");         //इ
            l.Add("89", "O{");        //ई
            l.Add("99", "p");         //उ
            l.Add("109", "pm");       //ऊ
            l.Add("119", "C");        //ऋ
            l.Add("129", "n[");       //ऌ
            l.Add("139", "P‘");       //ऍ
            l.Add("149", "P]");       //ऎ
            l.Add("159", "P");        //ए
            l.Add("169", "P]");       //ऐ
            l.Add("179", "cf‘");      //ऑ
            l.Add("189", "cf]");      //ऒ
            l.Add("199", "cf]");      //ओ
            l.Add("209", "cf}");      //औ
            l.Add("969", "<");        //ॠ
            l.Add("979", "<");        //ॡ
            l.Add("219", "s");        //क
            l.Add("229", "v");        //ख
            l.Add("239", "u");        //ग
            l.Add("249", "3");        //घ
            l.Add("259", "ª");        //ङ
            l.Add("269", "r");        //च
            l.Add("279", "5");        //छ
            l.Add("289", "h");        //ज
            l.Add("299", "´");        //झ
            l.Add("309", "~F");       //ञ
            l.Add("319", "6");        //ट
            l.Add("329", "7");        //ठ
            l.Add("339", "8");        //ड
            l.Add("349", "9");        //ढ
            l.Add("359", "0F");       //ण
            l.Add("369", "t");        //त
            l.Add("379", "y");        //थ
            l.Add("389", "b");        //द
            l.Add("399", "w");        //ध
            l.Add("409", "g");        //न
            l.Add("419", "g");        //ऩ
            l.Add("429", "k");        //प
            l.Add("439", "km");       //फ
            l.Add("449", "a");        //ब
            l.Add("459", "e");        //भ
            l.Add("469", "d");        //म
            l.Add("479", "o");        //य
            l.Add("489", "/");        //र
            l.Add("499", "/");        //ऱ
            l.Add("509", "n");        //ल
            l.Add("519", "n");        //ळ
            l.Add("529", "n");        //ऴ
            l.Add("539", "j");        //व
            l.Add("549", "z");        //श
            l.Add("559", "È");        //ष
            l.Add("569", ";");        //स
            l.Add("579", "x");        //ह
            l.Add("19", "“");         //कँ
            l.Add("29", "+");         //कं
            l.Add("39", "M");         //कः
            l.Add("609", "Þ");        //क़
            l.Add("619", "˜");        //कऽ
            l.Add("629", "f");        //का
            l.Add("639", "l");        //कि
            l.Add("649", "L");        //की
            l.Add("659", "'");        //कु
            l.Add("669", "\"");       //कू
            l.Add("679", "[");        //कृ
            l.Add("689", "[");        //कॄ
            l.Add("989", "<");        //कॢ
            l.Add("999", "<");        //कॣ
            l.Add("699", "‘");        //कॅ
            l.Add("709", "]");        //कॆ
            l.Add("719", "]");        //के
            l.Add("729", "}");        //कै
            l.Add("739", "f‘");       //कॉ
            l.Add("749", "f]");       //कॊ
            l.Add("759", "f]");       //को
            l.Add("769", "f}");       //कौ
            l.Add("779", "\\");       //क्
            l.Add("819", "");         //क॑
            l.Add("829", "");         //क॒
            l.Add("839", "]");        //क॓
            l.Add("849", "");         //क॔
            l.Add("1009", ".");       //क।
            l.Add("1019", "..");      //क॥
            l.Add("1029", ")");       //०
            l.Add("1039", "!");       //१
            l.Add("1049", "@");       //२
            l.Add("1059", "#");       //३
            l.Add("1069", "$");       //४
            l.Add("1079", "%");       //५
            l.Add("1089", "^");       //६
            l.Add("1099", "&");       //७
            l.Add("1109", "*");       //८
            l.Add("1119", "(");       //९
            l.Add("809 ", "ç");       //ॐ
            l.Add("1129", "=");       //॰
            myDictionary = l;
            var myarray4 = Encoding.Unicode.GetBytes(nepaliUnicode);
            int count = myarray4.Length;
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < count; i = i + 2)
            {
                string unicodeNo = myarray4[i].ToString() + myarray4[i + 1].ToString();
                if ((myarray4[i + 1] == 9)) //|| (unicodeNo == "320")
                {

                    string stack = UnicodeToNepali(unicodeNo);
                    int test;
                    test = int.Parse(unicodeNo);
                    if (test == 639)
                    {
                        str.Insert(str.Length - 1, 'l');
                    }
                    else
                    {
                        str.Append(UnicodeToNepali(unicodeNo));
                    }
                }
                else if ((myarray4[i + 1] == 0))
                {
                    str.Append(Convert.ToChar(myarray4[i]));
                }

            }
            string mkm = str.ToString();
            var pattern = new Regex(@"([a-z])\\");
            char[] shiftPressForms = ")!@#$%^&*;(".ToCharArray();
            Regex pattern_digit = new Regex(@"\d");
            string replaced = pattern.Replace(mkm, m => m.Groups[1].ToString().ToUpper());
            // replaced = pattern_digit.Replace(replaced, m => shiftPressForms[int.Parse(m.Value)].ToString());
            return replaced;
        }
        private static Dictionary<string, string> myDictionary;
        public static string ConvertUnicodeWithEnglish(string InputString)
        {
            var myarray = Encoding.Unicode.GetBytes(InputString);
            StringBuilder str = new StringBuilder();
            int count = myarray.Length;
            for (int i = 0; i < count; i = i + 2)
            {

            }
            return "";
        }
        private static string UnicodeToNepali(string EngWord)
        {
            string key1 = EngWord;
            // if not has the meaning return the same word!
            if (!myDictionary.ContainsKey(key1)) return EngWord;
            else return myDictionary[key1];
        }
    }
}
