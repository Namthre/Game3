//gesick
//proj 2 complete - proj 3 start

using UnityEngine;
using System.Collections.Generic;

public class EnemySub1 : EnemyBase
{
    protected UnityEngine.AI.NavMeshAgent agent;
    void Start ()
    {
		timing = 0;
		fireDelay = 10;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = playerPosition;
        speed = agent.speed;
	}
    private void Update()
    {
        if (DestroyByContact.dead)
            agent.speed = 0;
    }
    public override void Move(List<EnemyBase> elist, Transform playerPos)
	{
        
            
         playerPosition = playerPos.position;
        agent.destination = playerPosition;
        agent.speed = speed * .8f*DdaSpeedAdj;
       
		
	}
	public override void attack ()
	{
        timing += Time.deltaTime;
        if (timing > fireDelay)
        {
            timing = 0;
            
            if (Vector3.Distance(agent.transform.position, playerPosition) < 50)
            {
              GameObject s1=  Instantiate(shot, e1shotSpawn.position, e1shotSpawn.rotation) as GameObject;
               GameObject s2= Instantiate(shot, e1shotSpawn2.position, e1shotSpawn2.rotation)as GameObject;
                Destroy(s1, 4);
                Destroy(s2, 4);
            }
        }
	}
}                                                                                                                                                                                                                                                        //gesick project
