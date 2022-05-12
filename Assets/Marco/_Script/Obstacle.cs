using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        private void OnTriggerEnter(Collider col)
    {
                //start sound;
        // print("AAAAAAAAA");
        if (col.gameObject.CompareTag("Enemy")) {
            Destroy(gameObject);
        }
    }
}
