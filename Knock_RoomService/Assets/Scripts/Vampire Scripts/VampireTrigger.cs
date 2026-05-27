using UnityEngine;

public class VampireTrigger : MonoBehaviour
{
    [SerializeField] private Animator VampAnime;

    private void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.CompareTag("Player"))
        {
            VampAnime.SetTrigger("Vamping");
            Destroy(gameObject);
        }
    }
}
