using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{   
    public void shimmy() {
      Animator animator = gameObject.GetComponent<Animator>();
      animator.SetTrigger("shimmyTrigger");
    }
    public void faint()
    {
      Animator animator = gameObject.GetComponent<Animator>();
      animator.SetTrigger("faintTrigger");
    }
}
