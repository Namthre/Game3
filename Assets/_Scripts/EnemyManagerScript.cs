//gesick
//proj 2 complete - proj 3 start

using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class EnemyManagerScript : MonoBehaviour
{
    public EnemyBase[] enemyObjects;
    public static List<EnemyBase> eList=new List<EnemyBase>();
    public playerControl player;
    public Vector3 spawnValues;
    public int numEnemy;
    private float elapsedTime;
    private int eCount;

    void Start()
    {
        eCount = 0;
       Spawn();
        elapsedTime = 0;
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 30)
            CheckStatus();
        if (DestroyByContact.dead)
            return;
        if (player == null)
            return;
        Transform playerPos = player.transform;
        foreach (EnemyBase e in eList)
        {
            if (e != null)
            {
                e.Move(eList, playerPos);
                e.attack();
            }
        }
    }

    private void CheckStatus()
    {
        elapsedTime = 0;
        if (eList.Count > eCount * .7)
        {
            foreach (EnemyBase e in eList)
            {
                if (e != null)
                {
                    e.DdaSpeedAdj = .7f;

                }
            }
        }
        else if (eList.Count < eCount * .3f)
            if (eList.Count > eCount * .7)
            {
                foreach (EnemyBase e in eList)
                {
                    if (e != null)
                    {
                        e.DdaSpeedAdj = 1.3f;

                    }
                }
            }
    }

    void Spawn()
    {
        Quaternion spawnRotation = Quaternion.identity;
        for (int i = 0; i < numEnemy / 2; i++)
        {
            eCount++;
            Vector3 spawnPosition = new Vector3(Random.Range(250-spawnValues.x, 250+spawnValues.x), spawnValues.y, Random.Range(250-spawnValues.z, 250+spawnValues.z));
            eList.Add((EnemySub1)Instantiate(enemyObjects[0], spawnPosition, spawnRotation));
        }
        for (int i = 0; i < numEnemy ; i++)
        {
            eCount++;
            Vector3 spawnPosition = new Vector3(Random.Range(250-spawnValues.x, 250+spawnValues.x), spawnValues.y, Random.Range(250-spawnValues.z, 250+spawnValues.z));
            eList.Add((EnemySub2)Instantiate(enemyObjects[1], spawnPosition, spawnRotation));
        }
        for (int i = 0; i < numEnemy / 2; i++)
        {
            eCount++;
            Vector3 spawnPosition = new Vector3(Random.Range(250-spawnValues.x, 250+spawnValues.x), spawnValues.y+.5f, Random.Range(250-spawnValues.z, 250+spawnValues.z));
            eList.Add((EnemySub3)Instantiate(enemyObjects[2], spawnPosition, spawnRotation));
        }
    }


}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               //gesick project


