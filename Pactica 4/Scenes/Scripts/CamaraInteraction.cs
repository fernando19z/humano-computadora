using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraInteraction : MonoBehaviour
{
    private new Transform camera;

    public float rayDistanse;

    void Start()
    {
        camera = transform.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(camera.position,camera.forward*rayDistanse, Color.red);
        
        if(Input.GetButtonDown("Interactable")){
            RaycastHit hit;
            if(Physics.Raycast(camera.position,camera.forward, out hit,rayDistanse,LayerMask.GetMask("Interactuar"))){
                hit.transform.GetComponent<interaccion>().Interact();
            }   

        }
        
    }
}
