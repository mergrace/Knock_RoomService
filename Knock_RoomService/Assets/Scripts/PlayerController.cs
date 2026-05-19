using UnityEngine;

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
        animator.SetBool("Walk", isWalking);

        if (Time.timeScale == 0f) return;

        Vector3 position = Vector3.zero;
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
    }


}
