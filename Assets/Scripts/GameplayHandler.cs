using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayHandler : MonoBehaviour
{
	public GameObject ball;
	public GameObject scoreText;
    public GameObject penguin;
    public int score = 0;
    public bool isInPlay = false;


    void Update()
    {
        if (ball == null) return;
        if (isInPlay) return;
        if (
            Input.GetKey(KeyCode.Space) ||
            Input.GetKey(KeyCode.Mouse0) ||
            Input.GetKey(KeyCode.Return) ||
            Input.GetKey(KeyCode.JoystickButton0)
        ) {
            SnowballScript snowballScript = ball.GetComponent<SnowballScript>();
            snowballScript.drop();
			isInPlay = true;
        }
    }

    public void setScore(int worth = 0) {
		if (scoreText == null || penguin == null) return;

		score += worth;
		ScoreScript scoreScript = scoreText.GetComponent<ScoreScript>();
		scoreScript.updateScore(score);

		BirdScript birdScript = penguin.GetComponent<BirdScript>();
        if (worth > 0) {
    		birdScript.shimmy();
        } else {
			birdScript.faint();
        }
	}

	public void startNewRound()
	{
		if (ball == null) return;

		SnowballScript snowballScript = ball.GetComponent<SnowballScript>();
		snowballScript.reset();
		isInPlay = false;
	}
}
