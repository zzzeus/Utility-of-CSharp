using System;
using System.Text.RegularExpressions;

class TextHelper
{
    //judge whether the string contains Kanji
    public static bool containsKanji(string text){
        return false;
    }

    //judge whether the string contains Hiragara
    public static bool containsHiragara(string text){
        return false;
    }

    public static bool containsNumber(string text){
        return false;
    }
    public static bool endswith(string text,string pattern){
        var r = Regex.Matches(text, String.Format("{0}$",pattern));
        if (r.Count>=1)
        {
            return true;
        }
        return false;
    }

}