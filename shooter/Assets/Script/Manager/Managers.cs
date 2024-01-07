using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_Instance;
    static Managers Instance {  get { Init(); return s_Instance; } }

    InputManagers _input = new InputManagers();

    public static InputManagers Input {  get { return Instance._input; } }

    void Start()
    {
        Init();
    }

    void 

    static void Init()
    {
        
    }
}
