using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

/**
 * RU:
Класс контроллера игры, сюда пробрасываются все глобальные действия. Также здесь написан основной скрипт - функция Tick(), система "тиков", на которой построена игра
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
    Простой метод Start(), в котором задаются ссылки на объекты
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
    Та самая система "тиков". Она вызывается каждый раз при движении игрока(скорее всего будет переделано), и выполняет действия других сущностей

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
