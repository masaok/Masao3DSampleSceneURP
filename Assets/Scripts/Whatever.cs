using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whatever : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello" + this.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("test update");
    }
}
