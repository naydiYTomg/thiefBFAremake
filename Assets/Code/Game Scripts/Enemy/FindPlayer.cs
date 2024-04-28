using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using Jet_V_ScriptLib;

[RequireComponent(typeof(Enemy))]
public class FindPlayer : MonoBehaviour
{
    Enemy enemy;
    [SerializeField] private Tilemap ground;
    //[SerializeField] private Jet_V_ScriptLib jvscript;
    public Main jvscript;
    void Start()
    {
        jvscript = new Main();
        enemy = GetComponent<Enemy>();
    }

    // Update is called once per frame
    public void GoToPlayer(GameObject @object)
    {
        Vector3Int pos = jvscript.Vec3IntVec3(@object.transform.position);
        print(ground.GetTile(pos));
    }
}
