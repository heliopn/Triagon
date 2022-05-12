using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float _baseSpeed = 10.0f;
   float _gravidade = 1f;
   public float jumpHeight = 10;
   private float fallMultiplier = 7.0f;
   float y = 0;
   Rigidbody rb;
      //Referência usada para a câmera filha do jogador
   GameObject playerCamera;
   //Utilizada para poder travar a rotação no angulo que quisermos.
   float cameraRotation;

   private CharacterController characterController;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    [SerializeField]
    private float gravityValue = -9.81f;
   

   void Start()
   {
      rb = GetComponent<Rigidbody>();
       characterController = GetComponent<CharacterController>();
       playerCamera = GameObject.Find("Main Camera");
       cameraRotation = 0.0f;
   }

   void Update()
   {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
       
       //Verificando se é preciso aplicar a gravidade
      //   if(!characterController.isGrounded){
      //      y -= _gravidade;
      //   }
      //   else {
      //      y = 0;
      //      if (Input.GetButtonDown("Jump")) {
      //          //printf("AAAAAAAAAAAAAAAA");
      //          y+= jumpHeight;
      //          y -= _gravidade;
      //      }
      //   }
      groundedPlayer = characterController.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
       //Vector3 direction = new Vector3(x, y, z);
       

       
        //Tratando movimentação do mouse
        float mouse_dX = Input.GetAxis("Mouse X");
        float mouse_dY = Input.GetAxis("Mouse Y");
       
        //Tratando a rotação da câmera
        cameraRotation += -mouse_dY;
        Mathf.Clamp(cameraRotation, -75.0f, 75.0f);
       
        Vector3 direction = transform.right * x + transform.up * y + transform.forward * z;

        characterController.Move(direction * _baseSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, mouse_dX);


        playerCamera.transform.localRotation = Quaternion.Euler(cameraRotation, 0.0f, 0.0f);

        // Jump used is from Unity
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        characterController.Move(playerVelocity * Time.deltaTime);
        // Jump ends here
   }

   
void LateUpdate()

{
  RaycastHit hit;
  Debug.DrawRay(playerCamera.transform.position, transform.forward*10.0f, Color.magenta);
  if(Physics.Raycast(playerCamera.transform.position, transform.forward, out hit, 100.0f))
  {
     //Debug.Log(hit.collider.name);
   }
}
}