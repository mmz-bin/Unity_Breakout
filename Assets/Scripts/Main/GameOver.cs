using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Main
{
    //底辺に衝突したらリザルトに移行する
    public class GameOver : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            GameObject.Find("Manager").GetComponent<Manager>().Finish(GameManager.ResultType.FAILED);
        }
    }
}
