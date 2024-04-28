using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class EnemyFOV : MonoBehaviour
{
    public float fovAngle = 90f;
    public Transform fovPoint;
    public float range = 8f;
    private GameController controller;

    public Transform target;
    RaycastHit2D hit;
    float angle;
    Vector2 dir;
    private void Awake()
    {
        controller = FindObjectOfType<GameController>().GetComponent<GameController>();
    }
    public void Update()
    {
        if(GameObject.Find("Player") != null)
        {
            
            try
            {
                dir = target.position - transform.position;
                angle = Vector3.Angle(dir, fovPoint.up);
                hit = Physics2D.Raycast(fovPoint.position, dir, range);
            }catch
            {
                print("EXP");
            }
            finally
            {
                if (angle < fovAngle / 2)
                {
                    if (hit.collider.CompareTag("Player"))
                    {
                        try
                        {
                            Debug.DrawRay(fovPoint.position, dir, Color.red);
                            //if(!AgentMovement.seePlayer)
                            //{
                            //    AgentMovement.seePlayer = true;
                            //}
                            if(!controller.playerVisible)
                            {
                                controller.playerVisible = true;
                                print("Set playerVisible to true");
                            }
                        }
                        catch
                        {
                            print("exp");
                        }
                        finally
                        {
                            //if (AgentMovement.seePlayer)
                            //{
                            //    AgentMovement.seePlayer = false;
                            //}
                            
                        }
                        

                    }else
                    {
                        if (controller.playerVisible)
                        {
                            controller.playerVisible = false;
                            print("Set playerVisible to false");
                        }
                    }
                    

                }
            }
            
            //Debug.DrawRay(fovPoint.position, dir, Color.red);

            
        }
        
    }
}
