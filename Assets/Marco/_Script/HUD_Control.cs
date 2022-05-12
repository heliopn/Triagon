using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD_Control : MonoBehaviour
{
    public GameObject marco;
    public GameObject helio;
    public GameObject erik;
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.marco) {
            marco.SetActive(true);
        }
        else {
            marco.SetActive(false);
        }
        if (gm.helio) {
            helio.SetActive(true);
        }
        else {
            helio.SetActive(false);
        }
        if (gm.erik) {
            erik.SetActive(true);
        }
        else {
            erik.SetActive(false);
        }
    }
}
