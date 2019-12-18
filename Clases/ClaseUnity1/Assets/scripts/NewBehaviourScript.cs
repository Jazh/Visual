using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]//sirve para que el inspector de unity lo pueda ver(consola).
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigidbody2D;
    public float speed = 1f;
    public Animator animator;

    public bool grounded { get { return RoundAbsoluteToZero(rigidbody2D.velocity.y) == 0f; } }

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        
        animator.SetBool("walk",(h!=0));
        animator.SetBool("jump", !grounded);
        animator.SetFloat("vertical", Mathf.Sign(rigidbody2D.velocity.y));



        if(h != 0)
        {
            spriteRenderer.flipX = (h<0);
        }

        /*if(h > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if(h < 0)
        {
            spriteRenderer.flipX = true;
        }*/


        transform.Translate(Vector3.right * h * speed);


        if(grounded && Input.GetKeyDown(KeyCode.Space)) {
            rigidbody2D.AddForce(Vector2.up * 4,ForceMode2D.Impulse);
        }


    }

    float RoundAbsoluteToZero(float decimalValue) {
        decimalValue = Mathf.Abs(decimalValue);
        if(decimalValue <= 0.01f) {
            decimalValue = 0f;
        }
        return decimalValue;
    }

    /*
    void FixedUpdate() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            rigidbody2D.AddForce(Vector2.up * 2, ForceMode2D.Impulse);
        }
    }*/

}
