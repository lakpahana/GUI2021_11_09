using System;
using System.Collections.Generic;
using System.Text;

namespace GUI2021_11_09
{
    public class Car1
    {
        private double mileage;
        private double speed;
        public string Color { get; private set; }
        public string Model { get; private set; }
        public string Make { get; private set; }
        public Car1()
        {

        }

        public double Speed
        {
            get { return speed; }
            set
            {
                if(value > 200)
                {
                    speed = 200;
                }else if(value < -30)
                {
                    speed = -30;
                }
                else
                {
                    speed = value;

                }
            }
        }

        public double Mileage
        {
            get { return mileage; }
            //can read but cannot set
            private set
            {
                mileage = value;
            }
        }

        public void Move(double distance)
        {
            Mileage = Mileage + distance;
        }
    }
}
