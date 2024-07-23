using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    [SerializeField]
    private List<float> numbers = new List<float>();

    private float randomValue;
    void Start()
    {
        randomValue = numbers.GetRandomItem();
        Debug.Log(randomValue);
    }

    
    void Update()
    {
        
    }

    
}
