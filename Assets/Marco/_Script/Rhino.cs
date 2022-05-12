using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhino : MonoBehaviour
{
    float _baseSpeed = 10.0f;
    float _gravidade = 1f;
    private bool running = false;
    private bool stopped = false;
    private Animator animator;
    CharacterController characterController;

    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetInstance();
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (running && !stopped) {
            characterController.Move(transform.forward * _baseSpeed * Time.deltaTime);
            if(!characterController.isGrounded){
                characterController.Move(transform.up * (-_gravidade)* Time.deltaTime);
            } 
        }
        else {
            running = animator.GetBool("isRunning");
        }
    }


    private void OnTriggerEnter(Collider col) {
        //start sound;
        
        if (col.gameObject.CompareTag("Player")) {
            //print("MORREU");
            gm.ChangeState(GameManager.GameState.GAMEOVER);
            Destroy(gameObject);
        }
        if (col.gameObject.CompareTag("Wall")) {
            animator.SetBool("isStopped",true);
            stopped = true;
        }
    }


    
}
