using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolverCube.Entity
{
    public class Cubo
    {
        private Face _top;
        private Face _bottom;
        private Face _left;
        private Face _right;
        private Face _front;
        private Face _back;

        enum Directions
        {
            AntiClockWise,
            ClockWise
        };
        enum Degrees
        {
            _90,
            _180,
            _270,
        };


        public Face Top
        {
            get { return _top; }
            set { _top = value; }
        }
        

        public Face Bottom
        {
            get { return _bottom; }
            set { _bottom = value; }
        }
        

        public Face Left
        {
            get { return _left; }
            set { _left = value; }
        }
        

        public Face Right
        {
            get { return _right; }
            set { _right = value; }
        }
        

        public Face Front
        {
            get { return _front; }
            set { _front = value; }
        }
        

        public Face Back
        {
            get { return _back; }
            set { _back = value; }
        }

        //public void RotateTop(Directions direction, Degrees degrees)
        //{

        //}
        //public void RotateBottom(Directions direction, Degrees degrees)
        //{

        //}
        //public void RotateLeft(Directions direction, Degrees degrees)
        //{

        //}
        //public void RotateRight(Directions direction, Degrees degrees)
        //{

        //}
        //public void RotateFront(Directions direction, Degrees degrees)
        //{

        //}
        //public void RotateBack(Directions direction, Degrees degrees)
        //{

        //}
        public Face GetBestFace()
        {
            int tempPontos = 0;
            int pontos = VerifyCrossInit(Front, Top, Bottom, Left, Right);
            Face bestFace = Front;

            if ((tempPontos = VerifyCrossInit(Right, Top, Bottom, Front, Back)) > pontos)
            {
                bestFace = Right;
                pontos = tempPontos;
            }
            if ((tempPontos = VerifyCrossInit(Back, Top, Bottom, Right, Left)) > pontos)
            {
                bestFace = Back;
                pontos = tempPontos;
            }
            if ((tempPontos = VerifyCrossInit(Left, Top, Bottom, Back, Front)) > pontos)
            {
                bestFace = Left;
                pontos = tempPontos;
            }
            if ((tempPontos = VerifyCrossInit(Top, Back, Front, Left, Right)) > pontos)
            {
                bestFace = Top;
                pontos = tempPontos;
            }
            if ((tempPontos = VerifyCrossInit(Bottom, Front, Back, Left, Right)) > pontos)
            {
                bestFace = Bottom;
            }
            return bestFace;
        }

        public int VerifyCrossInit(Face reference, Face above, Face bellow, Face left, Face right)
        {
            int pontos = 0;
            if ((reference.MatrizCores[2, 2] == reference.MatrizCores[1, 2]) && (above.MatrizCores[3, 2] == above.MatrizCores[2, 2])) pontos++;
            if ((reference.MatrizCores[2, 2] == reference.MatrizCores[2, 1]) && (left.MatrizCores[2, 3] == left.MatrizCores[2, 2])) pontos++;
            if ((reference.MatrizCores[2, 2] == reference.MatrizCores[2, 3]) && (right.MatrizCores[2, 1] == right.MatrizCores[2, 2])) pontos++;
            if ((reference.MatrizCores[2, 2] == reference.MatrizCores[3, 2]) && (bellow.MatrizCores[1, 2] == bellow.MatrizCores[2, 2])) pontos++;
            return pontos;
        }




    }
    
}
