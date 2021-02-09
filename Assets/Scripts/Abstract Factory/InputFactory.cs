using System;
using UnityEngine;

namespace Asteroids.AbstractFactory
{
    internal sealed class InputFactory
    {
        public IInput CreateInput(RuntimePlatform platform)
        {
            switch (platform)
            {
                case RuntimePlatform.WindowsPlayer:
                case RuntimePlatform.WindowsEditor:
                    return new PCInput();
                case RuntimePlatform.XBOX360:
                case RuntimePlatform.XboxOne:
                case RuntimePlatform.PS3:
                case RuntimePlatform.PS4:
                    return new ConsoleInput();
                default:
                    throw new ArgumentOutOfRangeException(nameof(platform),platform, null);
            }
        }
    }
}
