using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    bool isWalking = false;

    AudioManager audioManager;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0f) return;

        Vector3 position = Vector3.zero;
        isWalking = false;

        if(Input.GetKey(KeyCode.D))
        {
            position.x += 0.1f;
            isWalking = true; 
            transform.localScale = new Vector3(1, transform.localScale.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            position.x -= 0.1f;
            isWalking = true;
            transform.localScale = new Vector3(-1, transform.localScale.y);
        }
        transform.position += position;

        animator.SetBool("Walk", isWalking);
    }


}
