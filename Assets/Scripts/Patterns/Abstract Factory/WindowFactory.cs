using System;
using UnityEngine;

namespace Asteroids.AbstractFactory
{
    internal sealed class WindowFactory
    {
        public IWindow CreateWindow(RuntimePlatform platform)
        {
            switch (platform)
            {
                case RuntimePlatform.WindowsPlayer:
                case RuntimePlatform.WindowsEditor:
                    return new PCWindow();
                case RuntimePlatform.XBOX360:
                case RuntimePlatform.XboxOne:
                case RuntimePlatform.PS3:
                case RuntimePlatform.PS4:
                    return new ConsoleWindow();
                default:
                    throw new ArgumentOutOfRangeException(nameof(platform), platform, null);
            }
        }
    }
}
