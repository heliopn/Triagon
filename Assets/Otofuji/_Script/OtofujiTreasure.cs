using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OtofujiTreasure : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lmanager;
    public GameObject dragon;
    LightingManager lm;

    void Start()
    {
        lm = lmanager.GetComponent<LightingManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(lm.OnStartEvent);
    }

    private void OnTriggerEnter(Collider other)
    {
        //start sound;
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.green;
        lm.OnStartEvent = false;
        lm.OnFinishEvent = true;
        Destroy(dragon);
    }
}
