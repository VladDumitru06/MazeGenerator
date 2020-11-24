using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellBlock : MonoBehaviour
{
    #region Members
    public GridController gridController;
    public Vector2 Position;
    public GameObject Floor, NorthWall, SouthWall, EastWall, WestWall;
    public bool selected;
    #endregion
    #region Constructors
    #endregion
    #region UnityMethods
    private void Start()
    {
        selected = false;
        Position.x = transform.position.x;
        Position.y = transform.position.z;
    }
    private void OnMouseDown()
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
        gridController.SelectCell(this);
    }
    #endregion
    #region Methods
    #endregion
}
