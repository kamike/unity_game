using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMoveAnimtor : MonoBehaviour {
    private Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        anim.SetFloat("x", horizontal);
        anim.SetFloat("y", vertical);
        transform.Translate(horizontal,0,0);

        //anim.SetFloat("y", m_TurnAmount, 0.1f, Time.deltaTime);
    }

 
  
   
}
