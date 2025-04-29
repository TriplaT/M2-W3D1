using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    private int[] myArray;

    // Start is called before the first frame update
    void Start()
    {
        myArray = new int[] { 1, 2, 3, 4, 5 };
        Debug.Log("Array iniziale:");
        stampaArray(myArray);

        myArray = CambiaDimensioneArray(myArray, 3);
        Debug.Log("Array ridotto a dimensione 3:");
        stampaArray(myArray);

        myArray = CambiaDimensioneArray(myArray, 7);
        Debug.Log("Array aumentato a dimensione 7:");
        stampaArray(myArray);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void stampaArray(int[] array)
    {
        string output = "";
        for (int i = 0; i < array.Length; i++)
        {
            output += array[i] + " ";
        }
        Debug.Log(output.Trim());
    }

    int[] CambiaDimensioneArray(int[] array, int dim)
    {
        System.Random rnd = new System.Random();

        if (dim < array.Length)
        {
            int[] newArray = new int[dim];
            for (int i = 0; i < dim; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }
        else
        {
            int[] newArray = new int[dim];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = array.Length; i < dim; i++)
            {
                newArray[i] = rnd.Next(0, 100);
            }
            return newArray;
        }
    }


}
