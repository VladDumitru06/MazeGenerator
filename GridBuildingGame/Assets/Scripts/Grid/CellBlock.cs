using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellBlock
{
    #region Members
    public int x, y;
    public GameObject Floor, NorthWall, SouthWall, EastWall, WestWall;
    #endregion
    #region Constructors
    public CellBlock(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    #endregion
    #region Methods
    #endregion
}
