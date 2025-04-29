using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    private System.Random rand = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        int[] array = generaArray(10, 1, 100);
        stampaArray(array);
        int min = findMinimo(array);
        int max = findMassimo(array);
        Debug.Log($"Minimo: {min}");
        Debug.Log($"Massimo: {max}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int[] generaArray(int dim, int min, int max)
    {
        int[] result = new int[dim];
        for (int i = 0; i < dim; i++)
        {
            result[i] = rand.Next(min, max + 1);
        }
        return result;
    }

    void stampaArray(int[] array)
    {
        Debug.Log("Array values: " + string.Join(", ", array));
    }

    // Simple linear search for minimum
    int findMinimo(int[] array)
    {
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];
        }
        return min;
    }

    // Simple linear search for maximum
    int findMassimo(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        return max;
    }
}
