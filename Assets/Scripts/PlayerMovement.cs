using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerBody;
    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /// 0 - left click
        /// 1 - right click
        /// 2 - scroll/ middle click
        if (Input.GetMouseButton(0))
            playerBody.velocity = Vector2.up * Constants.force;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(Constants.playGame);
    }
}
