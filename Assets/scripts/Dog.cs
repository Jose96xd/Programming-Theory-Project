using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Dog : Animal
{
    [SerializeField] private float biteForce;
    void Start()
    {
        
    }

    // POLYMORPHISM
    public override void ShowInfo()
    {
        base.ShowInfo();
        Debug.Log("Be carefully, I bite with " + biteForce + " newtons of force");
    }

    

}
