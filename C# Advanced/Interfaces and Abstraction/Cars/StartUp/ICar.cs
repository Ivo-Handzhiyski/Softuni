using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp
{
    interface ICar
    {
        public string Model { get; set; }

        public string Color { get; set; }

        string Start();

        string Stop();
    }
}
