using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    Transform playerPos;

    public int moveDistance = 0;

    public bool MovePlayer(Vector3 pos)
    {
        if (moveDistance > 0 && CalcDistance(pos))
        {
            playerPos.position = pos;
            moveDistance = 0;
            return true;
        }
        return false;
    }

    bool CalcDistance(Vector3 pos)
    {
        Tile tile = GetTileAtPosition(pos);
        if (tile == null || tile.isObstacle)
        {
            // The tile does not exist or is an obstacle, so the player cannot move to it
            return false;
        }
        return Math.Abs(pos.x - playerPos.position.x) + Math.Abs(pos.y - playerPos.position.y) <= moveDistance;
    }

    Tile GetTileAtPosition(Vector3 pos)
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(pos, 0.1f);
        foreach (Collider2D hitCollider in hitColliders)
        {
            Tile tile = hitCollider.GetComponent<Tile>();
            if (tile != null)
            {
                return tile;
            }
        }
        return null;
    }
}
