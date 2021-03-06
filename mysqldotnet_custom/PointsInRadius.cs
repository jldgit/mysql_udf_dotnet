﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLCustomClass
{
    public class PointsInRadius : MySQLHostManager.ICustomAssembly
    {

        public long RunInteger(long value)
        {
            throw new NotImplementedException();
        }

        public long RunIntegers(long[] values)
        {
            throw new NotImplementedException();
        }

        public double RunReal(double value)
        {
            throw new NotImplementedException();
        }

        public double RunReals(double[] values)
        {
            if (values.Length >= 4)
            {
                var gc = new System.Device.Location.GeoCoordinate(values[0], values[1]);
                var distance = gc.GetDistanceTo(new System.Device.Location.GeoCoordinate(values[2], values[3]));
                if (values.Length >= 5)
                {
                    if (distance <= values[4])
                    {
                        return 1.0;
                    }
                    return 0.0;
                }
                return distance;
            }
            return 0.0;
        }

        public string RunString(string value)
        {
            throw new NotImplementedException();
        }

        public string RunStrings(string[] values)
        {
            throw new NotImplementedException();
        }
    }
}
