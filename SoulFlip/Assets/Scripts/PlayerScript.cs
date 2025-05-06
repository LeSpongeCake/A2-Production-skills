using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public int moveSpeed;
    public bool moving;
    List<string> moveSequence = new List<string>();
    public Rigidbody2D rb2D;
    public LayerMask blockingLayer;

    private Vector2 direction;

    private Vector2 dir_Up = new Vector2(0, 1);
    private Vector2 dir_Down = new Vector2(0, -1);
    private Vector2 dir_Left = new Vector2(-1, 0);
    private Vector2 dir_Right = new Vector2(1, 0);
    private Vector2 currentPos;
    private BoxCollider2D boxCollider;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        currentPos = rb2D.position;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            moveSequence.Add("up");
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            moveSequence.Add("left");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            moveSequence.Add("down");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            moveSequence.Add("right");
        }
        FixedUpdate();
    }

    void FixedUpdate()
    {
        if (moveSequence.Count > 0 && !moving)
        {
            Move(moveSequence[0]);
        }
    }

    void Move(string direction_string)
    {
        ChangeDirection(direction_string);

        Vector2 start = transform.position;
        Vector2 end = start + direction;

        Debug.Log("Start Position: " + start);
        Debug.Log("End Position: " + end);
        Debug.Log("Direction: " + direction);

        boxCollider.enabled = false;
        RaycastHit2D hit = Physics2D.Linecast(start, end, blockingLayer);
        boxCollider.enabled = true;

        if (hit.transform == null)
        {
            StartCoroutine(Movement(end));
            //animator.SetTrigger(direction_string);
            return;
        }
        else
        {
            moveSequence.RemoveAt(0);
            //animator.SetTrigger(direction_string);
            return;
        }
    }

    void ChangeDirection(string direction_string)
    {
        switch (direction_string)
        {
            case "up":
                direction = dir_Up;
                break;
            case "down":
                direction = dir_Down;
                break;
            case "left":
                direction = dir_Left;
                break;
            case "right":
                direction = dir_Right;
                break;
        }
    }

    IEnumerator Movement(Vector3 end)
    {
        moving = true;
        float sqrRemainingDistance = (transform.position - end).sqrMagnitude;

        while (sqrRemainingDistance > float.Epsilon)
        {
            Vector3 newPosition = Vector3.MoveTowards(rb2D.position, end, moveSpeed * Time.deltaTime);
            rb2D.MovePosition(newPosition);
            sqrRemainingDistance = (transform.position - end).sqrMagnitude;
            yield return null;
        }

        currentPos = end;
        moveSequence.RemoveAt(0);
        moving = false;
    }
}
