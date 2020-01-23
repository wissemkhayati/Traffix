using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppApplication : SingletonMB<AppApplication>
{
    // Reference to the root instances of the MVC.
    public AppModel model;
    public AppView view;
    public AppController controller;
}
