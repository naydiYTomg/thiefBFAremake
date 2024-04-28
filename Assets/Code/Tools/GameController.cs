using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

/**
 * RU:
����� ����������� ����, ���� �������������� ��� ���������� ��������. ����� ����� ������� �������� ������ - ������� Tick(), ������� "�����", �� ������� ��������� ����
 * EN:
The class of the game controller, all global actions are thrown here. The main script is also written here - the Tick() function, the system of "ticks" on which the game is built
*/
public class GameController : MonoBehaviour
{
    //OtherClasses
    [SerializeField] private PlayerMovement playerM;
    FindPlayer _fp;


    //GameObjects
    [SerializeField] private GameObject enemyM;



    //Bools
    [HideInInspector] public bool playerVisible = false;


    /**
     * RU:
    ������� ����� Start(), � ������� �������� ������ �� �������
     * EN:
    A simple Start() method that sets references to objects
    */
    void Start()
    {
        playerM = FindObjectOfType<PlayerMovement>().GetComponent<PlayerMovement>();
        _fp = enemyM.GetComponent<FindPlayer>();
    }
    /**
     * RU:
    �� ����� ������� "�����". ��� ���������� ������ ��� ��� �������� ������(������ ����� ����� ����������), � ��������� �������� ������ ���������

     * EN:
    A system of "ticks". It is called every time the player moves (most likely it will be redone), and performs the actions of other entities
    */
    public void Tick(Vector2 playerDirection)
    {
        if (playerM.CanMove(playerDirection))
        {
            playerM.gameObject.transform.position += (Vector3)playerDirection;
        }
        if(playerVisible)
        {
            print("Enemy is seeing player");
            _fp.GoToPlayer(playerM.gameObject);
        }
        
    }
    T Choose<T>(params T[] arg)
    {
        return arg[Random.Range(0, arg.Length)];
    }
}
