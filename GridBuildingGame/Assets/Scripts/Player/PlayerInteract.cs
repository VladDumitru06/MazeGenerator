using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    Interactable _interactable;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Interactable")
        {
            _interactable = other.gameObject.GetComponent<Interactable>();
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Interactable")
        {
            _interactable = null;
        }

    }
    void Update()
    {
        if(Input.GetButtonDown("Use"))
        {
            if(_interactable != null)
            {
                _interactable.Use();
            }
        }

    }
    private bool CheckForInteractable()
    {
        return true;
    }
}
