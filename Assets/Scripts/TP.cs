using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{
    [SerializeField]
    GameObject go;
    [SerializeField]
    GameObject pl;
    GameManager gm;
    [SerializeField]
    bool goal;
    bool did = true;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetInstance();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (did)
        {
            Debug.Log(other.gameObject.name);
            if (goal)
            {
                gm.helio = true;
            }
            pl.transform.position = go.transform.position;
            did = false;
        }
    }
}
