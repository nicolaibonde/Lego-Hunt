using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeMovement : MonoBehaviour {

    enum movements
    {
        None,
        Forward,
        Left,
        Right
    }

    Queue<movements> Moves;
    public GameObject plane;

    float movementDistance = 0.01f;
    movements currentMove = movements.None;

    bool isPlaying = false;
    bool moving = false;
    public Vector3 startMarker;
    public Vector3 endMarker;
    public float speed = 0.0000001F;
    private float startTime;
    private float journeyLength;

    // Use this for initialization
    void Start () {
        Moves = new Queue<movements>();
        Moves.Enqueue(movements.Forward);
        Moves.Enqueue(movements.Forward);
        Moves.Enqueue(movements.Left);
        Moves.Enqueue(movements.Forward);
        Moves.Enqueue(movements.None);
	}
	
	// Update is called once per frame
	void Update () {
        if (!isPlaying)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                currentMove = Moves.Dequeue();
                isPlaying = true;
            }
        }
        else
        {
            executeMovements();
        }
	}

    void executeMovements()
    {
        switch (currentMove)
        {
            case movements.Forward:
                moveForward();
                break;

            case movements.Left:
                turnLeft();
                break;

            case movements.Right:
                turnRight();
                break;
            case movements.None:
                break;
        }
    }

    void moveForward()
    {
        if (moving)
        {
            transform.Translate(Vector3.Lerp(startMarker,endMarker,0.00001f));

            if (transform.position == endMarker)
            {
                moving = false;
                currentMove = Moves.Dequeue();
            }
        }
        else
        {
            startMarker = transform.position;
            endMarker = transform.position + new Vector3(1, 0, 0);
            moving = true;
        }
    }

    void turnRight()
    {

    }

    void turnLeft()
    {

    }
    


}
