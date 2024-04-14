using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{   public PlayerMovement pm;
    public GameObject startPoint;
    public GameObject Player;
    public bool immue = false;
    // Start is called before the first frame update
    void Start()
    {
        pm = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        immue = pm._isRock;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if ((other.gameObject.CompareTag("Player1")))
        {
            if (immue == false)
            {
                Player.transform.position = startPoint.transform.position;
            }
        }
        
    }
}
