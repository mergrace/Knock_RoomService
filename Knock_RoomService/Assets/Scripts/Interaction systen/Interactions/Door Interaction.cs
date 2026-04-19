using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using System.Collections;
using System.Collections.Generic;

public class DoorInteraction : MonoBehaviour, IInteractable
{
    public bool IsOpened { get; private set; }





    public bool CanInteract()
    {
        throw new System.NotImplementedException();
    }

    public void Interact()
    {
        if (IsOpened)
        {
            SceneController.instance.NextLevel(); //Supposed to transition to new scene/Room 1

        }


    }
}
