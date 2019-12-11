using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigidbody2D;
    public float speed = 1f;
    public Animator animator;

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

        if(h > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if(h < 0)
        {
            spriteRenderer.flipX = true;
        }


        transform.Translate(Vector3.right * h * speed);
    }

    void FixedUpdate() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            rigidbody2D.AddForce(Vector2.up * 2, ForceMode2D.Impulse);
        }
    }

}
