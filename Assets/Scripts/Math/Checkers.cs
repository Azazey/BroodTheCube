using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Checkers
{
    public static bool isDigits(string s)
    {
        if (s == null || s == "") return false;

        for (int i = 0; i < s.Length; i++)
            if ((s[i] ^ '0') > 9)
                return false;

        return true;
    }
}