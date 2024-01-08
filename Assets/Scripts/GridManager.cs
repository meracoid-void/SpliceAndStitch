using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField]
    private int _width, _height;

    [SerializeField]
    private Tile _tilePrefab;

    [SerializeField]
    private StartingTile _startingTilePrefab;

    [SerializeField]
    private EndingTile _endingTilePrefab;

    [SerializeField]
    private EventTile _eventTilePrefab;

    [SerializeField]
    private WallTile _wallTilePrefab;

    [SerializeField]
    private Transform _cam;

    [SerializeField]
    private Vector2 _startingTile;

    [SerializeField]
    private Vector2 _endTile;

    [SerializeField]
    private List<Vector2> _eventTiles;

    [SerializeField]
    private List<Vector2> _wallTiles;

    [SerializeField]
    private Player _playerPrefab;

    [SerializeField]
    private PlayerManager _playerManger;

    private Dictionary<Vector2, Tile> _grid;

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        _grid = new Dictionary<Vector2, Tile>();
        for(int x = 0; x < _width; x++)
        {
            for(int y = 0; y < _height; y++)
            {
                if(x == _startingTile.x && y == _startingTile.y)
                {
                    var spawnedTile = Instantiate(_startingTilePrefab, new Vector3(x, y), Quaternion.identity);
                    spawnedTile.name = $"Tile {x} {y}";
                    spawnedTile.Init();

                    var player = Instantiate(_playerPrefab, new Vector3(x, y, -5), Quaternion.identity);
                    player.name = "Player 1";

                    _grid[new Vector2(x, y)] = spawnedTile;
                }
                else if (x == _endTile.x && y == _endTile.y)
                {
                    var spawnedTile = Instantiate(_endingTilePrefab, new Vector3(x, y), Quaternion.identity);
                    spawnedTile.name = $"Tile {x} {y}";
                    spawnedTile.Init();

                    _grid[new Vector2(x, y)] = spawnedTile;
                }
                else if (_eventTiles.Where(v => v.x == x && v.y == y).Count() > 0)
                {
                    var spawnedTile = Instantiate(_eventTilePrefab, new Vector3(x, y), Quaternion.identity);
                    spawnedTile.name = $"Tile {x} {y}";
                    spawnedTile.Init();

                    _grid[new Vector2(x, y)] = spawnedTile;
                }
                else if(_wallTiles.Where(v => v.x == x && v.y == y).Count() > 0)
                {
                    var spawnedTile = Instantiate(_wallTilePrefab, new Vector3(x, y), Quaternion.identity);
                    spawnedTile.name = $"Tile {x} {y}";
                    spawnedTile.Init();

                    _grid[new Vector2(x, y)] = spawnedTile;
                }
                else
                {
                    var spawnedTile = Instantiate(_tilePrefab, new Vector3(x, y), Quaternion.identity);
                    spawnedTile.name = $"Tile {x} {y}";
                    var isOffset = (x + y) % 2 == 1;
                    spawnedTile.Init(isOffset);

                    _grid[new Vector2(x, y)] = spawnedTile;
                }
            }
        }

        _cam.transform.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -10);

        _playerManger.Init();
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
