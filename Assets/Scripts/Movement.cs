using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   [SerializeField] GameObject FinishPanel;


   public float moveSpeed = 5.0f;
   public float drag = 0.5f;
   public float terminalRotationSpeed = 25.0f;
   private Rigidbody controller;
   private Transform camTransform;

   private void Start() 
   {
      controller = GetComponent <Rigidbody> ();
      controller.maxAngularVelocity = terminalRotationSpeed;
      controller.drag = drag;
      Time.timeScale = 1.0f;

      camTransform = Camera.main.transform;
   }
   private void Update()
   {
     Vector3 dir = Vector3.zero;

     dir.x = Input.GetAxis ("Horizontal");
     dir.z = Input.GetAxis ("Vertical");

     if (dir.magnitude > 1)
    {
        dir.Normalize ();
    }
    Vector3 rotatedDir = camTransform.TransformDirection(dir);
    rotatedDir = new Vector3 (rotatedDir.x, 0, rotatedDir.z);
    rotatedDir = rotatedDir.normalized * dir.magnitude;

    controller.AddForce (rotatedDir * moveSpeed);

    
   }
   private void OnTriggerEnter(Collider collision)
   {
      if (collision.transform.tag == "FinishLayer")
      {
         FinishPanel.SetActive(true);
         Time.timeScale = 0f;
      }
   }

}
