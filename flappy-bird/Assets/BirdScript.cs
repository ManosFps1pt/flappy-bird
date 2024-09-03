using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // public variables
    public new Rigidbody2D rigidbody;
    public int jumpStrength = 10;
    public LogicScript logic;
    public bool birdAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdAlive)
        {
            rigidbody.velocity = UnityEngine.Vector2.up * jumpStrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdAlive = false;
    }
}
