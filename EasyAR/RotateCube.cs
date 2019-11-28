using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Object; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Object.transform.Rotate(Vector3.left);
    }
}
