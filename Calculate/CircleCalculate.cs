using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccumulatingCode.Calculate
{
    using Business;

    public class CircleCalculate
    {
        /// <summary>
        /// 求三点共圆的圆心坐标
        /// </summary>
        /// <param name="pointA">A坐标</param>
        /// <param name="pointB">B坐标</param>
        /// <param name="pointC">C坐标</param>
        /// <returns></returns>
        public Point getCenterCoordinateOfCircle(Point pointA,Point pointB,Point pointC)
        {
            Point point=new Point();

            //圆心X的临时计算变量
            double tempX1 = (pointA.SquaresDistance - pointB.SquaresDistance) * (pointA.Y - pointC.Y);
            double tempX2 = (pointA.SquaresDistance - pointC.SquaresDistance) * (pointA.Y - pointB.Y);
            double tempX3 = (pointA.Y - pointC.Y) * (pointA.X - pointB.X)
                            - (pointA.Y - pointB.Y) * (pointA.X - pointC.X);

            //圆心Y的临时计算变量
            double tempY1 = (pointA.SquaresDistance - pointB.SquaresDistance) * (pointA.X - pointC.X);
            double tempY2 = (pointA.SquaresDistance - pointC.SquaresDistance) * (pointA.X - pointB.X);
            double tempY3 = (pointA.Y - pointB.Y) * (pointA.X - pointC.X)
                            - (pointA.Y - pointC.Y) * (pointA.X - pointB.X);

            point.X = (tempX1 - tempX2) / (2 * tempX3);
            point.Y = (tempY1 - tempY2) / (2 * tempY3);

            return point;
        }
    }

}
