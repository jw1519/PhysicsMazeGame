using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Skittles : MonoBehaviour
{
    public Transform skittles;
    public GameObject Skittle;
    public Collider Collider;
    public TextMeshProUGUI AmountOfPins;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (skittles.rotation.z != 0 || skittles.rotation.x != 0)
        {

            SkittleManger.instance.SkittleFallOver();
            AmountOfPins.SetText("Pins knocked Over:  " + SkittleManger.instance.NumberFallenSkittles);
            Destroy(Skittle);
        }
    }
}
