using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameObjectExtensions
{
    public static T GetComponentInChildrenByName<T>(this GameObject gameObject, string name) where T : Component
    {
        foreach (T component in gameObject.GetComponentsInChildren<T>(true))
        {
            if (component.gameObject.name == name)
            {
                return component;
            }
        }
        return null;
    }
}
