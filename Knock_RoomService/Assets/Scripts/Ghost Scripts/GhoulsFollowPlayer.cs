using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhoulsFollowPlayer : MonoBehaviour
{
    [SerializeField] public float speed = 1.5f;

    private GameObject player;
    private bool isPlayerInZone = false;

    private float distanceToPlayer;
    [SerializeField] private float radius;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        distanceToPlayer = Vector2.Distance(transform.position, player.transform.position);

        if(distanceToPlayer < radius)
        {
           
            isPlayerInZone =true;
        }
        else
        {
            isPlayerInZone = false;
        }


        if (isPlayerInZone == true)
        {
            FollowPlayer(1.5f);
        }
        else
        {
            FollowPlayer(0f);
        }
    }

    public void FollowPlayer(float speed)
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);


    }
 /*   public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInZone = true; 
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInZone = false;
        }
    }
*/


    public void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position,radius);
    }
}
