using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public GameObject SpeedUp;
    public GameObject Points;

    public bool isCoins, isSpeedUp;

    public int Duration = 3;


    public PlayerController pc;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pc = other.GetComponent<PlayerController>();
            if (isCoins) { 
                
            
                pc.Score++;
                Destroy(gameObject);
            }

            if (isSpeedUp)
            {
                pc.moveSpeed *= 1.5f;
                Invoke(nameof(ResetEffect), Duration);
                Destroy(gameObject);
            }
        }
    }

    public void ResetEffect() {
        pc.moveSpeed -= 1.5f;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
