using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicenemy : MonoBehaviour
{
    [SerializeField] 
    protected EnemyData Data;
    [SerializeField] 
    public Transform playerentity;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        follow_player();
        lookplayer();
    }

    public void follow_player()
    {
        Vector3 direction = (transform.position - playerentity.position);
        if (direction.magnitude > 1f)
        {
            transform.Translate(Vector3.forward * Data.speed * Time.deltaTime);
        }
    }

    public void lookplayer()
    {
        transform.LookAt(playerentity);
    }

}
