using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Collections;

namespace SolverCube.Entity
{
    public class Face
    {
        enum Collors {
            Blue,
            Red,
            Green,
            Yellow,
            White,
            Orange
        };

        private Object[,] _matrizCores = new Object[3, 3];

        public Object[,] MatrizCores
        {
            get { return _matrizCores; }
            set { _matrizCores = value; }
        }

       

        
    }
}
