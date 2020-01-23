using UnityEngine;
using System;

public class SingletonMB<T> : MonoBehaviour where T : class
{
    static SingletonMB<T> instance;

    public static T Instance
    {
        get { return instance as T; }
    }

    protected virtual void Awake()
    {
        instance = this;
    }

}