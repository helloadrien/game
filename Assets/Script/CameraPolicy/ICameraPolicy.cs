using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.CameraPolicy
{
    public interface ICameraPolicy
    {
        void Update(Transform tranform);
    }
}
