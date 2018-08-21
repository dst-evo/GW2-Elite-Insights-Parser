﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckParser.Models.ParseModels
{
    public class CircleActor : Actor
    {
        private int _radius;

        public CircleActor(bool fill, int growing, int radius, Tuple<int, int> lifespan, string color) : base(fill, growing, lifespan, color, new MobileActor())
        {
            _radius = radius;
        }

        public CircleActor(bool fill, int growing, int radius, Tuple<int, int> lifespan, string color, Point3D position) : base(fill, growing, lifespan, color, new ImmobileActor(position))
        {
            _radius = radius;
        }

        public int GetRadius()
        {
            return _radius;
        }

    }
}
