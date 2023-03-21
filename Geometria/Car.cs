using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    bool _engineRunning = false;
    bool _steeringWheelLocked = true;

    public bool EngineRunning
    {
        get => _engineRunning;
        set
        {
            _engineRunning = value;

            if (value)
            {
                _steeringWheelLocked = false;
            }
        }
    }

    public bool SteeringWheelLocked
    {
        get => _steeringWheelLocked;
        set
        {
            if (value && _engineRunning)
            {
                throw new Exception("invalid op.");   
            }

            _steeringWheelLocked = value;
        }
    }
}
