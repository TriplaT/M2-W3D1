using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    public int number1;
    public int number2;
    public int number3;
    // Start is called before the first frame update
    void Start()
    {
        if (isEven(number1))
        {
            Debug.Log("Il numero " + number1 + " è pari");
        }
        else
        {
            Debug.Log("Il numero " + number1 + " è dispari");
        }

        if (isMultipleOf(number1, number2))
        {
            Debug.Log("Il numero " + number2 + " è multiplo del numero " + number1);
        }
        else
        {
            Debug.Log("Il numero " + number2 + " non è multiplo del numero " + number1);
        }

        if (isEven(number3))
        {
            Debug.Log("Il numero " + number3 + " è pari");
        }
        else
        {
            Debug.Log("Il numero " + number3 + " è dispari");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool isEven(int number)
    {
        return number % 2 == 0;
    }

    public bool isMultipleOf(int baseNum, int multiple)
    {
        if (baseNum == 0) return false;
        return multiple % baseNum == 0;
    }
}
