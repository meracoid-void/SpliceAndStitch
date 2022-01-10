using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField]
    private int _width, _height;

    [SerializeField]
    private Tile _tilePrefab;

    [SerializeField]
    private Transform _cam;

    [SerializeField]
    private Vector2 _startingTile;

    [SerializeField]
    private Vector2 _endTile;

    [SerializeField]
    private List<Vector2> _eventTiles;

    [SerializeField]
    private Player _playerPrefab;

    private Dictionary<Vector2, Tile> _grid;

    void Start()
    {
        GenerateGrid();

        SetEventTiles();
        SetStartingTile();
        SetEndingTile();
    }

    void SetEventTiles()
    {
        foreach(var tilePos in _eventTiles)
        {
            var tile = GetTileAtPosition(tilePos);
            if (tile != null)
            {
                tile.SetEventColor();
            }
        }
    }

    void SetStartingTile()
    {

        var tile = GetTileAtPosition(_startingTile);
        if (tile != null)
        {
            tile.SetStartingColor();
            var player = Instantiate(_playerPrefab, new Vector3(_startingTile.x, _startingTile.y, 0), Quaternion.identity);
        }
    }

    void SetEndingTile()
    {
        var tile = GetTileAtPosition(_endTile);
        if (tile != null)
        {
            tile.SetEndingColor();
        }
    }

    void GenerateGrid()
    {
        _grid = new Dictionary<Vector2, Tile>();
        for(int x = 0; x < _width; x++)
        {
            for(int y = 0; y < _height; y++)
            {
                var spawnedTile = Instantiate(_tilePrefab, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";

                var isOffset = (x + y) % 2 == 1;

                spawnedTile.Init(isOffset);

                _grid[new Vector2(x, y)] = spawnedTile;
            }
        }

        _cam.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -10);
    }

    public Tile GetTileAtPosition(Vector2 pos)
    {
        if(_grid.TryGetValue(pos, out var tile))
        {
            return tile;
        }
        return null;
    }
}
