using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : interaccion
{
    public override void Interact(){
        base.Interact();

        Destroy(gameObject);
    }
}
