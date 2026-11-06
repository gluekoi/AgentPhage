using UnityEngine;

public class KillaTmovement : MonoBehaviour
{
     
     private Vector3 playerPosition;

     [SerializeField]
     private GameObject player;

     [SerializeField]
     private float speed = 8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyOnHit();
        
    }

    private void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, (speed * Time.deltaTime));
    }

    private void DestroyOnHit()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
