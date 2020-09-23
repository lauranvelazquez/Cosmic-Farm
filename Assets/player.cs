using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 4f;
    Rigidbody2D rb2d;
    Vector2 mov;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.MovePosition(rb2d.position + mov * speed * Time.deltaTime);
        mov = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );
        Animations ();
    }
    void Animations () {

        if (mov != Vector2.zero) {
            anim.SetFloat("movX", mov.x);
            anim.SetFloat("movY", mov.y);
          //  anim.SetBool("walking", true);
        } else {
           // anim.SetBool("walking", false);
        }

      
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        maderitas.maderas++;
        Destroy(col.gameObject);
    }
}
