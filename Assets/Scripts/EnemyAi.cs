using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{

    public float speed;
    public float stoppingDistance;

    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // We will check the distance between the ai and the target to make sure that 
        // the targets will not intersect
        if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            // Occurs while the distance is greater than the stopping distance
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
