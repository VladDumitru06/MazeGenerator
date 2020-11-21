using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellBlock : MonoBehaviour
{
    #region Members
    public float x, y;
    public GameObject Floor, NorthWall, SouthWall, EastWall, WestWall;
    #endregion
    #region Constructors
    #endregion
    #region UnityMethods
    private void Start()
    {
        
        x = transform.position.x;
        y = transform.position.z;
    }
    private void OnMouseDown()
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
        SelectedCell.SelectCell(new Vector2(x, y));
        Debug.Log("X " + x + " Y: " + y);
    }
    #endregion
    #region Methods
    #endregion
}
