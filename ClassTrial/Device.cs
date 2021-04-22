using System;
namespace ClassTrial
{
    public class Device
    {
        public string name { get; set; }
        public double price { get; set; }
        public string device_code { get; set; }
        public string manuf { get; set; }

        public Device(string n, double p, string d_c, string manu)
        {
            this.name = n;
            this.price = p;
            this.device_code = d_c;
            this.manuf = manu;
        }

        public string getName()
        {
            return name + " " + price;
        }

        public double getPrice()
        {
            return price;
        }

        public string getDevice_Code()
        {
            return device_code;
        }

        public string getManufacture()
        {
            return manuf;
        }

    }
}
