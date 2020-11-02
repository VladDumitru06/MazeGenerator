using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    #region Members

    [SerializeField] private Vector2 _gridSize;
    /// <summary>
    /// Start position of the grid 0, 0
    /// </summary>
    [SerializeField] private Vector2 _startPosition;
    [SerializeField] private int _cellBlockSize;
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
        SetPlane();
    }
    #endregion
    #region Methods
    /// <summary>
    /// Instantiates each Cell Block at it's respective positions
    /// </summary>
    private void CreateGrid()
    {
        _cellList = new List<CellBlock>();
        for (int i = (int)_startPosition.x; i < _gridSize.x + _startPosition.x; i++)
        {
            for (int j = (int)_startPosition.y; j < _gridSize.y + _startPosition.y; j++)
            {
                CellBlock _tempCellBlock = new CellBlock(i-(int)_startPosition.x,j - (int)_startPosition.y);
                _tempCellBlock.Floor = Instantiate(_floorBlock, new Vector3(i * _cellBlockSize, .1f, j * _cellBlockSize), new Quaternion(0f, 0f, 0f, 0f));
                _tempCellBlock.Floor.name = "Floor X:" + (i - (int)_startPosition.x).ToString() + " Y: " + (j - (int)_startPosition.y).ToString();
                _cellList.Add(_tempCellBlock);
            }
        }
    }
    /// <summary>
    /// Set's the plane to the size of the grid
    /// </summary>
    private void SetPlane()
    {
        _roomFloorPrefab.transform.position = new Vector3(_gridSize.x / 2 - 0.5f, _roomFloorPrefab.transform.position.y, _gridSize.y / 2 - 0.5f);
        _roomFloorPrefab.transform.localScale = new Vector3(_gridSize.x / 10, _roomFloorPrefab.transform.localScale.y, _gridSize.y / 10);
    }
    #endregion
}
