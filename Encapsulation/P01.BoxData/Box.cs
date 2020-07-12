using System;
using System.Collections.Generic;
using System.Text;

namespace P01.BoxData
{
   public class Box
    {
        private const double SIDE_MIN_VALUE = 0;
        private const string INVALID_SIDE_MESSAGE =
            "{0} cannot be zero or negative.";


        private double lenght;
        private double width;
        private double height;
        public Box(double lenght,double width,double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }
        public double Lenght
        {
            get => this.lenght;
            private set
            {
                ValidateSide(value,nameof(this.Lenght));
                this.lenght = value;
            }

        }
        public double Width
        {
            get => this.width;
            private set
            {
                ValidateSide(value, nameof(this.Width));
                this.width = value;
            }
        }
        public double Height
        {
            get => this.height;
            private set
            {
                ValidateSide(value, nameof(this.Height));
                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            var result =2* ((this.Lenght * this.Width) + (this.Lenght * this.Height) + (this.Width * this.Height));
            return result;
        }

        public  double LateralSurfaceArea()
        {
            var result = (2 * this.Lenght * this.Height) + (2 * this.Width * this.Height);
            return result;
        }

        public double Volume()
        {
            var result = this.Width * this.Lenght * this.Height;
            return result;
        }

        private void ValidateSide(double value,string sideName
            )
        {
            if (value <= SIDE_MIN_VALUE)
            {
                throw new ArgumentException
                    (string.Format(INVALID_SIDE_MESSAGE, sideName));
            }
        }


    }
}
