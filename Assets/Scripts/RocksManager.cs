using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocksManager : MonoBehaviour
{
    // .--..-.--
    [SerializeField]
    List<GameObject> Left;
    [SerializeField]
    List<GameObject> Right;
    List<int> Correct = new List<int> { 1, 0, 0, 1, 1, 0, 1, 0, 0 };
    [SerializeField]
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Correct.Count; i++)
        {
            if (Correct[i] == 1)
            {
                Left[i].GetComponent<RockController>().quebra = true;
            }
            else if (Correct[i] == 0)
            {
                Right[i].GetComponent<RockController>().quebra = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
