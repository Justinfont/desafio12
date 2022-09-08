using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemythief : basicenemy
{
        public Transform box;

  public bool steal = false;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      follow_player();
      looking();  
      //lookplayer();
      //run_away();  
    }

private void OnCollisionEnter(Collision other) 
    {
       if (other.gameObject.CompareTag("player"))
       {
        steal = true;
       }

       if (other.gameObject.CompareTag("box"))
       {
        steal = false;
       }

    }

   /* private void run_away()
    {
        if(steal == false)
        {
          follow_player();  
        }


        if (steal == true)
        {
          Vector3 direction = (transform.position - playerentity.position); 
        if (direction.magnitude > 1f)  
        {
        transform.Translate(Vector3.back *  Data.runspeed * Time.deltaTime);  
        }
        }
        
    }
        */

    public void looking()
    {
     if(steal == false)
     {
        lookplayer();
     }   


    if(steal == true)
    {
        transform.LookAt(box);
    }


    }
}
