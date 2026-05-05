using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhoulsFollowPlayer : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;

    private GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
