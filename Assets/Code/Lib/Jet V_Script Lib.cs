using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetV_ScriptLib : MonoBehaviour
{
    public Vector3Int Vec3Vec3Int(Vector3 vector)
    {
        int tempValue1 = (int)Mathf.Abs( vector.x);
        int tempValue2 = (int)Mathf.Abs( vector.y);
        int tempValue3 = (int)Mathf.Abs( vector.z);
        return new Vector3Int(tempValue1, tempValue2, tempValue3);
    }
}
