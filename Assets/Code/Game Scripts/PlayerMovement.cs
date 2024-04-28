
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerControls controls;
    [SerializeField] private Tilemap groundTilemap;
    [SerializeField] private Tilemap obstaclesTilemap;
    GameController controller;

    private void Awake()
    {
        
        controls = new PlayerControls();
        controller = FindObjectOfType<GameController>().GetComponent<GameController>();
    }
    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
    private void Start()
    {
        controls.Main.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>());
    }
    void Move(Vector2 direction)
    {
        controller.Tick(direction);
    } 
    public bool CanMove(Vector2 direction)
    {
        Vector3Int gridPos = groundTilemap.WorldToCell(transform.position + (Vector3)direction);
        if (!groundTilemap.HasTile(gridPos) || obstaclesTilemap.HasTile(gridPos))
            return false;
        return true;
    }
}
