using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LevelSystem;
public class ImportNum : MonoBehaviour
{
    FinisGenerator FinisGenerator;
    void Start()
    {
        int receivedValue = PlayerPrefs.GetInt("MyValue", 0);
        Debug.Log("Полученное значение: " + receivedValue);

        DoSomethingWithValue(receivedValue);
    }

    void DoSomethingWithValue(int value)
    {
        FinisGenerator.generationDistance = value;
    }
}
