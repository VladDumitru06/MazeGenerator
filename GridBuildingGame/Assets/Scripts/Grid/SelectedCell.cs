using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public static class SelectedCell 
{
    public static Vector2 firstCell ;
    public static Vector2 secondCell ;
    public static void SelectCell(Vector2 cellPosition)
    {
        if (firstCell == new Vector2(-1, -1))
        {
            Debug.Log("FIRST CELL" + cellPosition);
            firstCell = cellPosition; 
        }
        else if (secondCell == new Vector2(-1, -1))
        {
            Debug.Log("SECOND CELL" + cellPosition);
            secondCell = cellPosition; 
        }
    }
    public static bool CreatePlane()
    {
        if (firstCell != null && secondCell != null)
            return true;
        return false;
    }
}
