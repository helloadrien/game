using Assets.Scripts.CameraPolicy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraPolicy
{
    public interface ICameraPolicyFactory
    {
        ICameraPolicy Create(Chapter0PilotPoints pilotPoints);
    }
}
