using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using AStar;
using System.Threading.Tasks;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Tilemap ground;
    [SerializeField] private Tilemap obstacles;
    [SerializeField] private Transform[] targets;
    private int _targetValue;
    bool[,] g = new bool[1, 2];

    private void Start()
    {
        


    }
    private void Move(Vector2 direction)
    {
        //direction = path[_targetValue];

        //if (CanMove(direction))
        //{

        //}
    }
    private void Update()
    {
    }
    //public static async Task<(int, int)[]> GeneratePath(int startX, int startY, int goalX,  int goalY, bool[,] walkableMap, bool manhattanHeuristic = true, bool walkableDiagonals = false)
    //{

    //}

    public bool CanMove(Vector2 direction)
    {
        Vector3Int gridPos = ground.WorldToCell(transform.position + (Vector3)direction);
        if (!ground.HasTile(gridPos) || obstacles.HasTile(gridPos))
            return false;
        return true;
    }
    
    
}
