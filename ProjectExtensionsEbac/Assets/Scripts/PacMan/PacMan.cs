using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan : MonoBehaviour
{
    public GameObject pacMan;

    public void CreatePacMan()
    {
        var pac = Instantiate(pacMan);
        pac.transform.position = Vector3.zero;
    }
}
