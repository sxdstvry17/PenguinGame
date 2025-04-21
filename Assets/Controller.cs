using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public StarterAssetsInputs StarterAssetsInputs;
    private bool canMove = true;
    private void AttemptMove(Vector2 direction)
    {
        if (canMove)
        {
            StarterAssetsInputs.MoveInput(direction);
        }
    }
    public void MoveStop()
    {
        AttemptMove(Vector2.zero);
    }

    public void MoveLeft()
    {
        AttemptMove(Vector2.left);
    }

    public void MoveRight()
    {
        AttemptMove(Vector2.right);
    }
    public void MoveUp()
    {
        AttemptMove(Vector2.up);
    }

    public void MoveDown()
    {
        AttemptMove(Vector2.down);
    }

    public void SetCanMove(bool value)
    {
        canMove = value;
    }

    private Vector2 GetSingleDirection(Vector2 input)
    {
        if (Mathf.Abs(input.x) > Mathf.Abs(input.y))
        {
            return new Vector2(Mathf.Sign(input.x), 0);
        }
        else
        {
            return new Vector2(0, Mathf.Sign(input.y));
        }
    }
}

