using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IceTrigger : MonoBehaviour
{
	public GameObject gameCtrl;
    public int worth = 0;
	public Rigidbody2D triggeringBody; 
    
    void OnTriggerEnter2D(Collider2D col){
        if (triggeringBody == null || gameCtrl == null) return;
		
		var hitBody = col.attachedRigidbody;
        if (hitBody == triggeringBody){
			GameplayHandler gameplayHandler = gameCtrl.GetComponent<GameplayHandler>();
			gameplayHandler.setScore(worth);
		}
    }

    void OnTriggerExit2D(Collider2D col)
    {
		if (triggeringBody == null || gameCtrl == null) return;

		var hitBody = col.attachedRigidbody;
		if (hitBody == triggeringBody)
		{
			GameplayHandler gameplayHandler = gameCtrl.GetComponent<GameplayHandler>();
			gameplayHandler.startNewRound();
		}
    }
}
