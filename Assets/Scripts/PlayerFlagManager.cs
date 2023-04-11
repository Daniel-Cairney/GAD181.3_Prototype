using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DanDan
{


    public class PlayerFlagManager : MonoBehaviour
    {
        public static int playersInFlags = 0;
        public int playersInFlagsPublic;

        private void Start()
        {
            playersInFlags = 0;
        }

        private void Update()
        {
            playersInFlagsPublic = playersInFlags;
        }
    }

}