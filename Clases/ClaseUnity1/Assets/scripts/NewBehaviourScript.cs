using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    static public NewBehaviourScript instance;

    static public void SetPosition(Vector3 pos)
    {
        pos.z = 0;
        instance.transform.position = pos;
    }

    static public Vector3 setPosition
    {
        set {
            Vector3 pos = value;
            pos.z = 0;
            instance.transform.position = pos;
        }
    }

    static public Transform setPosition2
    {
        set {
            Vector3 pos = value.position;
            pos.z = 0;
            instance.transform.position = pos;
        }
    }

    static public HealthBarController HealhBar
    {
        set {
            instance.healthBarController = value;
        }
    }


    [SerializeField]//sirve para que el inspector de unity lo pueda ver(consola).
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigidbody2D;
    public float speed = 1f;
    public Animator animator;
    public float jumpForce = 10f;


    public bool grounded { get { return RoundAbsoluteToZero(rigidbody2D.velocity.y) == 0f; } }
    [SerializeField]
    private HealthBarController healthBarController;



    public Vector3 startPos;
    [Header("Vida")]
    [Tooltip("Vida Maxima")]
    public float maxLife = 50;
    [Range(0f,50)]
    public float currentLife;

    public BulletRock bullet;

    //Primero se ejecutan todos los aweke y luego los start
    void Awake() {

        instance = this;
        DontDestroyOnLoad(gameObject);

    }


    // Start is called before the first frame update
    void Start()
    {
        currentLife = 0;
        startPos = transform.position;

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
            rigidbody2D.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);
        }


        if(Input.GetKeyDown(KeyCode.O))
        {
            TakeDamage(1f);
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            Heal(1f);
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            Attack();
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            FastAttack();
        }


    }

    void OnCollisionEnter2D(Collision2D col) {

        if(col.gameObject.tag.Equals("DeathZone")) {
            transform.position = startPos;
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


    void TakeDamage(float damage) {
        currentLife -= damage;
        healthBarController.currentLife = currentLife;

    }

    void Heal(float heal)
    {
        currentLife += heal;
        healthBarController.currentLife = currentLife;

    }

    void Attack() {
       BulletRock clone = Instantiate<BulletRock>(bullet,transform.position,Quaternion.identity);

        clone.InitDirection(spriteRenderer.flipX ? BulletRock.Direction.left : BulletRock.Direction.right);

    }

    void FastAttack()
    {
        BulletRock clone = Instantiate<BulletRock>(bullet,transform.position,Quaternion.identity);

        //BulletRock bulletRock = clone.GetComponent<BulletRock>();
        clone.Init(10);
        clone.InitDirection(spriteRenderer.flipX ? BulletRock.Direction.left : BulletRock.Direction.right);
    }

}
