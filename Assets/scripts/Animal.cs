using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] protected string animalName;
    [SerializeField] protected string animalNoise;
    void Start()
    {
        
    }

    public virtual void ShowInfo()
    {
        Debug.Log("I am a " + animalName + ".");
        Debug.Log("The " + name + " does this sound: " + animalNoise);
    }

}
