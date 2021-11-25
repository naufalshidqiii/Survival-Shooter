using System;
using UnityEngine;

public interface IFactory
{
    GameObject FactoryMethod(int tag, int loc);
}
