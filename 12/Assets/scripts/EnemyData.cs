using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new enemy data", menuName = "new enemy data")]
public class EnemyData : ScriptableObject
{
 [SerializeField]
 [Range(0f,10f)]
 public float speed = 0f;

 [SerializeField]
 [Range(0f,10f)]
 public float runspeed = 0f;


}
