﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
   public class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {         
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }

        public int EngineSpeed;
        public int EnginePower;
    }
}
