using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkittleManger : MonoBehaviour
{
    public int NumberFallenSkittles = 0;

    public static SkittleManger instance;
    void Awake()
    {
        if(instance ==null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void SkittleFallOver()
    {
        NumberFallenSkittles++;
        Debug.Log(NumberFallenSkittles);
    }
}
