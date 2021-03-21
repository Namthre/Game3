//gesick
//proj 2 complete - proj 3 start

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class playerControl : MonoBehaviour
{
    public float speed = 6f;

    Rigidbody playerRigidBody;
    public GameObject shot;
    public GameObject shotB;

    public int activeWeps;

    public int health;
    private bool isAlive;
    private float rotateY;
    public Inventory inv;
    private WeaponBase activeWep;
    private bool hasDied;

    void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody>();

        health = 100;
        isAlive = true;
        hasDied = false;
        inv = new Inventory();
        activeWep = null;
    }
    void Update()  //for shooting
    {
        if (playerRigidBody == null)
            isAlive = false;

        if (isAlive)
        {

            if (Input.GetKeyDown("x"))
            {

                activeWep = inv.SelectWep();
                if(activeWep != null)
                {
                    activeWep.GetComponent<Renderer>().enabled = true;
                }
                
            }
            if (Input.GetKeyDown("left shift"))
            {

                if (activeWep != null)
                {
                    activeWep.shoot();

                }
            }

        }
        if (DestroyByContact.dead)
            if (activeWep != null)
                activeWep.GetComponent<Renderer>().enabled = false;
    }
    void FixedUpdate()
    {
        if (playerRigidBody == null)
            isAlive = false;
        if (isAlive)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            rotateY += h * 3;
            if (rotateY > 360)
                rotateY -= 360;
            if (rotateY < 0)
                rotateY += 360;
            transform.rotation = Quaternion.Euler(0, rotateY, 0);
            if (v != 0)
            {
                Vector3 velocity = transform.forward * speed * Time.deltaTime * v;
                playerRigidBody.MovePosition(transform.position + velocity);
            }
            inv.Positioning(this.transform);


            if (health <= 0)
            {
                hasDied = true;
                isAlive = false;
            }
        }
        if (hasDied)
        {
            playerRigidBody.gameObject.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }





}                                                                                                                                                                                                                                                        //gesick project

