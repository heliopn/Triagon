using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarcoDragon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Rhino;
    private bool activated;

    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetInstance();
        activated = false;
        //GameManager.changeStateDelegate += Construir;
    }
    /*void Construir()
    {
        foreach (Transform child in transform)
            {
                GameObject.Destroy(child.gameObject);
            }
        activated = false;
        
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col) {
        //start sound;
        // print("tocou");
        if (col.gameObject.CompareTag("Player")) {
            if (!activated) {
                //Renderer render = GetComponent<Renderer>();
                //render.material.color = Color.green;
                Instantiate(Rhino, transform.position + new Vector3(-14.2f,-0.5f,-11.2f),transform.rotation * Quaternion.Euler (180f, 270, 180f),transform);
                activated = true;
            }
        }
        }
}
