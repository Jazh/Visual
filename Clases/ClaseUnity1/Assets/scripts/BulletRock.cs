using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BulletRock : MonoBehaviour
{

    public enum Direction {
        left = -1,
        right = 1
    }

    public Direction direction = Direction.right;

    public float speed = 5f;
    public float lifeTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = ((int)direction * Vector3.right) * speed * Time.deltaTime;

        transform.position += pos;
        //transform.position += Vector3.right * speed *Time.deltaTime;
    }

    public void Init(float speed) {
        this.speed = speed;
    }

    public void InitDirection(Direction direction)
    {
        this.direction = direction;
    }
}
