using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public GameBehavior gameManager;
    public int ammoRefill = 20;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player" || collision.gameObject.name == "DisguisedPlayer")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Ammo Pickup collected!");
            gameManager.ammo += ammoRefill;
        }
    }
}
