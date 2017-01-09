using System.Collections.Generic;
using UnityEngine;

namespace UberLogger
{
    public class UberColorProvider
    {
        Dictionary<string, Color> map = new Dictionary<string, Color>();

        public Color GetColor(string channel)
        {
            if (!map.ContainsKey(channel))
            {
                map[channel] = Random.ColorHSV(0,1,0,1,0.3f,1);
            }
            return map[channel];
        }
    }
}