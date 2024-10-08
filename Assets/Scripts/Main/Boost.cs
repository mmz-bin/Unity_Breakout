using Main;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ボールの速度を上げる
public class Boost : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            OnExecute();
        }
    }

    public void OnExecute()
    {
        _ball.GetComponent<StartShot>().Start();
    }

    [SerializeField] private GameObject _ball;
}
