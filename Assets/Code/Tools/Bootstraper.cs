using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstraper : MonoBehaviour
{
    [SerializeField] private Player player;
    void Awake()
    {
        player.Initializate(10, 1, 5, 5f);
    }

    
}
