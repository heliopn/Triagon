using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    public bool quebra = false;
    [SerializeField]
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(quebra){
            Debug.Log("Touch");
            DestroyGameObject();
        }
    }

    void DestroyGameObject()
    {
        Destroy(this.gameObject);
    }
}
