using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
     [SerializeField]
    [Range(1f,10f)]
    private float speed = 2f;
   
   
    enum types  {enemyCamera,enemyFollower };
    [SerializeField] types EnemyAi;

     [SerializeField] Transform playerentity;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(EnemyAi)
        {
            case types.enemyCamera:
            LookPlayer();
            break;

            case types.enemyFollower:
            FollowPlayer();
            break;
        }
    }

    private void FollowPlayer()
    {
        Vector3 direction = (transform.position - playerentity.position); 
        if (direction.magnitude > 1f) 
        {
        transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
    }

    private void LookPlayer()
    {
        transform.LookAt(playerentity);
    }

}
