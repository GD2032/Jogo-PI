using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class CountTime : MonoBehaviour
    {
        protected float startTime;
        protected float actualTime;
        public void Tempo(float startTime)
        {
            actualTime = Time.time - startTime;
        }
    }
}
