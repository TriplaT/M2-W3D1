using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
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

        TrovaMinimi2(array);
        TrovaMassimi2(array);
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

    void TrovaMinimi2(int[] array)
    {
        if (array.Length < 2)
        {
            Debug.Log("Array troppo piccolo per trovare due minimi.");
            return;
        }

        int min1 = int.MaxValue;
        int min2 = int.MaxValue;

        foreach (int val in array)
        {
            if (val < min1)
            {
                min2 = min1;
                min1 = val;
            }
            else if (val < min2 && val != min1)
            {
                min2 = val;
            }
        }

        Debug.Log($"I due numeri più bassi sono: {min1} e {min2}");
    }

    void TrovaMassimi2(int[] array)
    {
        if (array.Length < 2)
        {
            Debug.Log("Array troppo piccolo per trovare due massimi.");
            return;
        }

        int max1 = int.MinValue;
        int max2 = int.MinValue;

        foreach (int val in array)
        {
            if (val > max1)
            {
                max2 = max1;
                max1 = val;
            }
            else if (val > max2 && val != max1)
            {
                max2 = val;
            }
        }

        Debug.Log($"I due numeri più alti sono: {max1} e {max2}");
    }
}
