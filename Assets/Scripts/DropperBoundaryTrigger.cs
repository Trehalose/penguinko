using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperBoundaryTrigger : MonoBehaviour
{
	public Rigidbody2D triggeringBody;

	void OnTriggerEnter2D(Collider2D col)
	{
		if (triggeringBody == null) return;

		var hitBody = col.attachedRigidbody;
		if (hitBody == triggeringBody && hitBody.gravityScale == 0) {
			SnowballScript snowballScript = col.gameObject.GetComponent<SnowballScript>();
			snowballScript.toggleFinderDirection();
        }
	}
}
