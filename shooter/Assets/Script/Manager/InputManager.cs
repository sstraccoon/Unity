using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagers : MonoBehaviour
{
    static Managers s_Instance;
    static Managers Instance { get { Init(); return s_Instance; } }



    static void Init()
    {
    }
}
