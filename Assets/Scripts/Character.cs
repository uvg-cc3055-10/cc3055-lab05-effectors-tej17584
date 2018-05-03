using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour {


    Rigidbody2D rb2d;
    SpriteRenderer sr;
    Animator anim;
    private float speed = 5f;
    private float jumpForce = 350f;
    private bool facingRight = true;
    //VAriables del lab
    public GameObject feet;//pies del personaje
    public LayerMask layerMask;//variable mask


	void Start () {
        //Se reciben los componentes
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
	

	void Update () {
        //movimiento en el eje horizontal
        float move = Input.GetAxis("Horizontal");
        if (move != 0) {//si el movimiento es distintod de cero entonces...
            //hacemos un transform con un nuevo vector de tres dimensaiones, 1 en x y lo multiplicamos 
            //con el momvimiento que lleva, la velocidad y el tiempo
            rb2d.transform.Translate(new Vector3(1, 0, 0) * move * speed * Time.deltaTime);
            facingRight = move > 0;
        }
        //Velocidad de movimiento
        anim.SetFloat("Speed", Mathf.Abs(move));

        sr.flipX = !facingRight;
        //Funcion jump Editada
        if (Input.GetButtonDown("Jump"))
        {   //Le pasamos como parámetros un vector, una transofrmacion y un layer mask
            RaycastHit2D raycast =Physics2D.Raycast(feet.transform.position, Vector2.down, 0.1f,layerMask);
            if (raycast.collider != null)
                rb2d.AddForce(Vector2.up * jumpForce);//saltamos
        }
	}
}
