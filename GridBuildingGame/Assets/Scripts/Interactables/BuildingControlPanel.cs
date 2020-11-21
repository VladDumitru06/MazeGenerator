using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuildingControlPanel : MonoBehaviour , Interactable
{
    [SerializeField] Camera _fpsCamera;
    [SerializeField] Camera _buildingCamera;

    public void Use()
    {
        _fpsCamera.enabled = !_fpsCamera.enabled;
        _buildingCamera.enabled = !_buildingCamera.enabled;
        if(!_fpsCamera.enabled)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        Debug.Log("I am being used");
    }

}
