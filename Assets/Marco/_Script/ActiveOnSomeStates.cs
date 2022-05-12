using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ActiveOnSomeStates : MonoBehaviour
{
    public GameManager.GameState[] activeStates;
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.changeStateDelegate += UpdateVisibility;
        gm = GameManager.GetInstance();

        UpdateVisibility();
    }

    void UpdateVisibility()
    {
        if (activeStates.Contains(gm.gameState))
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
