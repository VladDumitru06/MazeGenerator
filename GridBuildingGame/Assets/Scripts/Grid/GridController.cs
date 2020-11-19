using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    #region Members

    [SerializeField] private Vector2 _gridSize;
    [SerializeField] private int _cellBlockSize;
    [SerializeField] private Vector2 _startPosition;
    [SerializeField] private GameObject _floorBlock;
    /// <summary>
    /// Prefab used for creating a single floor tile from multiple
    /// </summary>
    [SerializeField] private GameObject _roomFloorPrefab;
    /// <summary>
    /// All the cell blocks
    /// </summary>
    private List<CellBlock> _cellList;
    #endregion
    #region Unity Methods
    private void Awake()
    {
        CreateGrid();
        SetPlane(_gridSize, _startPosition);
    }
    #endregion
    #region Methods
    /// <summary>
    /// Instantiates each Cell Block at it's respective positions
    /// </summary>
    private void CreateGrid()
    {
        _cellList = new List<CellBlock>();
        for (int i = 0; i < _gridSize.x ; i++)
        {
            for (int j = 0; j < _gridSize.y ; j++)
            {
                CellBlock _tempCellBlock = new CellBlock(i-(int)0,j - (int)0);
                _tempCellBlock.Floor = Instantiate(_floorBlock, new Vector3(i * _cellBlockSize, .1f, j * _cellBlockSize)+ new Vector3(_startPosition.x,0f,_startPosition.y), new Quaternion(0f, 0f, 0f, 0f));
                _tempCellBlock.Floor.name = "Floor X:" + (i - 0).ToString() + " Y: " + (j - 0).ToString();
                _cellList.Add(_tempCellBlock);
            }
        }
    }

    /// <summary>
    /// Set's the plane to the size of the grid
    /// </summary>
    private void SetPlane(Vector2 gridsize, Vector2 startPosition)
    {
        _roomFloorPrefab.transform.position = new Vector3(startPosition.x / 2 - 0.5f, _roomFloorPrefab.transform.position.y, startPosition.y / 2 - 0.5f);
        _roomFloorPrefab.transform.localScale = new Vector3(gridsize.x / 10, _roomFloorPrefab.transform.localScale.y, gridsize.y / 10);
    }
    #endregion
}
