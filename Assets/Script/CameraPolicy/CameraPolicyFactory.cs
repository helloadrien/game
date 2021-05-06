using Assets.Scripts.CameraPolicy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraPolicy
{
    public class CameraPolicyFactory : ICameraPolicyFactory
    {
        public ICameraPolicy Create(Chapter0PilotPoints pilotPoints)
        {
            switch (pilotPoints)
            {
                case Chapter0PilotPoints.LiuKeng_Appear:
                    return new LiuKengAppearCameraPolicy();
                default:
                    return null;
            }
        }
    }
}
