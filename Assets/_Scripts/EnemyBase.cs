//gesick
//proj 2 complete - proj 3 start

using UnityEngine;
using System.Collections.Generic;

public abstract class EnemyBase : MonoBehaviour
{

    protected float speed;
    public GameObject shot;
    public Transform e1shotSpawn;
    public Transform e1shotSpawn2;
    public Transform e1shotSpawn3;
    protected Vector3 playerPosition;
    protected float fireDelay;
    protected float timing;
    public float DdaSpeedAdj;

    public abstract void Move(List<EnemyBase> elist, Transform playerPos);

    public abstract void attack();
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               //gesick project

