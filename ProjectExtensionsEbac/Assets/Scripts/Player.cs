using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Player
{
    
    public static T GetRandomItem<T>(this List<T>list)
    {
        return list[Random.Range(0, list.Count)];
    }
    
}
