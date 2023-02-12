using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballScript : MonoBehaviour
{
    public Rigidbody2D snowballBody;
    private bool mayDrop = false;
    private Vector2 ogPosition;
    private int finderDirection = 0;

    void Start()
	{
		if (snowballBody == null) return;

		ogPosition = snowballBody.gameObject.transform.position;
		snowballBody.gravityScale = 0;
	}

    void Update()
    {
        if (snowballBody == null) return;

        if (mayDrop) {
            snowballBody.gravityScale = 1;
		} else {
            Vector2 direction = finderDirection == 0 ? Vector2.left : Vector2.right;
            int speed = 15;
			snowballBody.velocity = direction * speed;
		}
	}

    public void toggleFinderDirection() {
		finderDirection = finderDirection == 0 ? 1 : 0;
    }

    public void drop() {
        if (mayDrop == true) return;

		mayDrop = true;

		Vector2 direction = finderDirection == 0 ? Vector2.left : Vector2.right;
		int speed = 0;
		snowballBody.velocity = direction * speed;
	}

	public void reset()
	{
        Debug.Log("RESETTING POSITION");
		mayDrop = false;
		snowballBody.gravityScale = 0;
		snowballBody.gameObject.transform.position = ogPosition;
	}
}
