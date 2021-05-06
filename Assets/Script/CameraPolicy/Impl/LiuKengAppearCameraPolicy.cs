using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.CameraPolicy
{
    public class LiuKengAppearCameraPolicy : ICameraPolicy
    {
        public void Update(Transform cameraTranform)
        {
            var player = GameObject.Find("Player");
            var playerTransform = player.GetComponent<Transform>();
            cameraTranform.position = new Vector3(playerTransform.position.x, cameraTranform.position.y, cameraTranform.position.z);
        }
    }
}
