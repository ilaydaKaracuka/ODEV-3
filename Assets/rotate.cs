using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 vect;
    
    void Start()
    {
        vect = new Vector3(0.5f, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
      transform.Rotate(vect);
    }
}
