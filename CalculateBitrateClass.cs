using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace skyline.obj
{
    public static class CalculateBitrateClass
    {
      private const double pollingRateInSeconds = 0.4998;    // 2Hz converted to seconds
      public static double CalculateBitrate(long value)
      {
        return (value / pollingRateInSeconds) * 8;
      }
        
    }
}