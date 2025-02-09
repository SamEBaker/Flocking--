using UnityEngine;

public class BlendSteering
{
        public BehaviorAndWeight[] behaviors;
        float maxAcceleration = 1f;
        float maxRotation = 5f;

        public SteeringOutput getSteering()
        {
            SteeringOutput result = new SteeringOutput();

            foreach (BehaviorAndWeight b in behaviors)
            {
                SteeringOutput s = b.behavior.getSteering();
                if(s != null)
                {
                    result.angular += s.angular * b.weight;
                    result.linear += s.linear * b.weight;
                }
            }
            result.linear = result.linear.normalized * maxAcceleration;
            float angAcc = Mathf.Abs(result.angular);
            if(angAcc > maxRotation )
            {
                result.angular /= angAcc;
                result.angular *= maxRotation;
            }
           // result.angular = Mathf.Max(result.angular, maxRotation);
            return result;
        }
    }
