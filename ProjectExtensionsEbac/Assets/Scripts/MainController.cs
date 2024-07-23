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
#if UNITY_EDITOR

    [UnityEditor.MenuItem("Message/New message &m")]
    public static void ShowMessage()
    {
        Debug.Log("I'm pac man!");
    }

#endif   
}
