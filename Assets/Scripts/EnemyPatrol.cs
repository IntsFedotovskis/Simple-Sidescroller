using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float Speed = 10;
    public float Distance = 10;
    private bool _movingRight = true;
    public Transform GroundCheck;

    void Update()
    {
        transform.Translate(Vector2.right * Speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(GroundCheck.position,Vector2.down,Distance);
        if (groundInfo.collider == false)
        {
            if (_movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                _movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0,0);
                _movingRight = transform;
            }

        }
    }
}