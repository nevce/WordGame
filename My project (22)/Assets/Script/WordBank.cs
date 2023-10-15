using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class WordBank : MonoBehaviour
{
    public Button finishButton;
    private List<string> originalWords = new List<string>()
    {
        "Elma" , "Armut" , "Portakal", "Böðürtlen" , "muz", "þeftali", "ananas", "kiraz" , "viþne"
    };

    private List<string> workingWords = new List<string>();

    private void Awake()
    {
        finishButton.interactable = false;
        workingWords.AddRange(originalWords);
        Shuffle(workingWords);
        ConverToLower(workingWords);
    }
    private void Update()
    {
        FinishButton();
    }

    private void Shuffle(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int random = Random.Range(i, list.Count);
            string temporary = list[i];

            list[i] = list[random];
            list[random] = temporary;
        }
    }

    private void ConverToLower(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = list[i].ToLower();
        }
    }

    public string GetWord()
    {
        string newWord = string.Empty;

        if (workingWords.Count != 0)
        {
            newWord = workingWords.Last();
            workingWords.Remove(newWord);
        }
        return newWord;
    }

    private void FinishButton()
    {
        if (originalWords.Count == 0)
        {
            finishButton.interactable = true;
        }
    }
}
