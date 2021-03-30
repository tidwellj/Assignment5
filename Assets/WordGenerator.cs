using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = { "sidewalk", "robin", "three","protect", "periodic",
                                       "somber", "majestic", "jump","pretty", "wound","jazzy" };
   public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];
        return randomWord;
    }
}
