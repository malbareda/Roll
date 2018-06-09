using UnityEngine;
using System.Collections;

public class Hole : MonoBehaviour
{

    // Use this for initialization
    void Awake()
    {
        int x = Random.Range(0, 5);
        if (x == 0)
        {
            print("yo");
            Destroy(this.gameObject);
        }
    }
    
}
