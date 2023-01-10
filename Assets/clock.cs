using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;


public class clock : MonoBehaviour
{
    public static void Main()
    {
        DateTime localDate = DateTime.Now;
        String[] cultureNames = { "en-US", "en-GB", "fr-FR",
                                "de-DE", "ru-RU" };

        foreach (var cultureName in cultureNames)
        {
            var culture = new CultureInfo(cultureName);
            Console.WriteLine("{0}: {1}", cultureName,
                              localDate.ToString(culture));
        }
    }
}

