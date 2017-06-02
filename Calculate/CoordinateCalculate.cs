using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccumulatingCode.Calculate
{
    using Business;

    internal class CoordinateCalculate
    {
        /// <summary>
        /// 已知三点坐标及某点到三点的距离，
        /// 求该点坐标
        /// </summary>
        /// <param name="pA">A坐标</param>
        /// <param name="pB">B坐标</param>
        /// <param name="pC">C坐标</param>
        /// <param name="dA">到A的距离</param>
        /// <param name="dB">到B的距离</param>
        /// <param name="dC">到C的距离</param>
        /// <returns></returns>
        public Point getCoordinateFromDistances(Point pA, Point pB, Point pC, double dA, double dB, double dC)
        {
            Point point = new Point();
            double x;

            point.Y = GetY(pA.X, pB.X, pC.X, pA.Y, pB.Y, pC.Y, dA, dB, dC);

            //Y与X的坐标公式有对称性，故只需将X和Y对换
            point.X = GetY(pA.Y, pB.Y, pC.Y, pA.X, pB.X, pC.X, dA, dB, dC);

            return point;
        }

        /// <summary>
        /// 根据平面三点坐标
        /// 及到三点的距离，求X坐标
        /// 考虑三点共线情况
        /// </summary>
        /// <param name="pA">A坐标</param>
        /// <param name="pB">B坐标</param>
        /// <param name="pC">C坐标</param>
        /// <param name="dA">到A距离</param>
        /// <param name="dB">到B距离</param>
        /// <param name="dC">到C距离</param>
        /// <param name="x">X坐标</param>
        /// <returns></returns>
        public bool getXCoordinate(Point pA, Point pB, Point pC, double dA, double dB, double dC,out double x)
        {
            x = 0;

            //有共点现象
            if (pA.Equal(pB) || pA.Equal(pC) || pB.Equal(pC)) 
                return false;

            //三点共线且与Y轴平行
            if(pA.X==pB.X && pB.X==pC.X)
            {
                x = pA.X;
                return true;
            }

            //三点共线
            else if (pB.X != pA.X &&  pC.X!=pA.X)
            {
                //斜率
                double kAB = (pB.Y - pA.Y) / (pB.X - pA.X);
                double kAC = (pC.Y - pA.Y) / (pC.X - pA.X);

                //三点共线且平行于X轴
                if(kAB==0 && kAC==0)
                {
                    //取距离最近的2点
                    Point tempPoint1=pA, tempPoint2=pC;
                    Point tempPoint = dA>dB?pA:pB;

                    double x1 = 0, x2 = 0;

                    double tempD = Math.Max(dA, dB);
                    double tempD1=dA, tempD2=dC;

                    if(dA>dB)
                    {
                        tempPoint1 = pB;
                        tempD1 = dB;
                    }
                    if(tempD<dC)
                    {
                        tempPoint2 = tempPoint;
                        tempD2 = tempD;
                    }

                    x=(tempD1*tempD1 - tempD2*tempD2 + tempPoint2.X*tempPoint2.X - tempPoint1.X*tempPoint1.X)/(2*(tempPoint2.X-tempPoint1.X));

                    return true;
                }
                //三点共线且与X轴或Y轴不平行
                else if(kAB==kAC)
                {
                    x=(dB * dB - dA * dA + pA.X * pA.X - pB.X * pB.X) / (2 * (pA.X - pB.X));
                    return true;
                }
                
            }
            else
            {
                double tempX1 = (pC.Y - pA.Y) * (dA * dA - dB * dB - pA.SquaresDistance + pB.SquaresDistance);
                double tempX2 = (pB.Y - pA.Y) * (dA * dA - dC * dC + pC.SquaresDistance - pA.SquaresDistance);
                double tempX3 = (pB.Y - pA.Y) * (pA.X - pC.X) - (pC.Y - pA.Y) * (pA.X - pB.X);

                x = (tempX1 - tempX2) / (2 * tempX3);
                return true;
            }
            
            return false;

        }

        /// <summary>
        /// 根据平面三点坐标
        /// 及到三点的距离，求Y坐标
        /// </summary>
        public static double GetY(double x1, double x2, double x3, double y1, double y2, double y3, double d1, double d2, double d3)
        {
            double fenzi = (x3 - x1) * (d1 * d1 - d2 * d2 - y1 * y1 + y2 * y2 - x1 * x1 + x2 * x2)
                - (x2 - x1) * (d1 * d1 - d3 * d3 + y3 * y3 - y1 * y1 + x3 * x3 - x1 * x1);
            double fenmu = (x2 - x1) * (2 * y1 - 2 * y3) - (x3 - x1) * (2 * y1 - 2 * y2);

            //三点共线
            if (fenmu == 0)
            {
                throw new Exception("三点共线！");
            }

            return fenzi / fenmu;
        }

    }
}
