using System;
using System.IO;
namespace ClassTrial
{
    public class App
    {
        private Device[] deviceArray = new Device[10];
        private int currentDevice = 0;
        public bool showFullInfo;

        public App()
        {
            deviceArray[0] = new Device("Envy Photo Printer", 89.99, "0123", "HP");
            deviceArray[1] = new Device("Zen Beam Projector", 29.99, "0124", "ASUS");
            deviceArray[2] = new Device("Belt Sander - 850W", 48.99, "0125", "GUILD");
            deviceArray[3] = new Device("S&S Video Baby Monitor", 129.99, "0126", "VTECH");
            deviceArray[4] = new Device("Wet & Dry El. Shaver", 60.99, "0127", "REMINGTON");
            deviceArray[5] = new Device("Astro Fi Telescope", 579.99, "0128", "CELESTRON");
            deviceArray[6] = new Device("Waterproof MP3 Player", 99.99, "0129", "SONY");
            deviceArray[7] = new Device("Microwave Oven 900W", 739.99, "0130", "PANASONIC");
            deviceArray[8] = new Device("Fog Free Mirror", 17.99, "0131", "CROYDEX");
            deviceArray[9] = new Device("Curl Hair Dryer", 97.99, "0132", "BABYLISS");
        }

        public string getPreviousDevice()
        {
            if (currentDevice == 0)
            {
                currentDevice = 9;
            }
            else
            {
                currentDevice--;
            }
            return getDeviceInfo(currentDevice);
        }

        public string getNextDevice()
        {
            if (currentDevice == 9)
            {
                currentDevice = 0;
            }
            else
            {
                currentDevice++;
            }
            return getDeviceInfo(currentDevice);
        }

        public string getFirstDevice()
        {
            currentDevice = 0;

            return getDeviceInfo(currentDevice);
        }

        public string getLastDevice()
        {
            currentDevice = 9;

            return getDeviceInfo(currentDevice);
        }

        public string getCurrentDevice()
        {
            return getDeviceInfo(currentDevice);
        }

        public string getDeviceInfo(int currentDevNumber)
        {
            String DeviceInfo =
        "\n----------------------------------------\n\n" +
        "|\t\tDevice Information \n|\n" +
        "|\t\t   --------\n" +
        "|\t\t   " + (currentDevNumber + 1) + " of 10\n" +
        "|\t\t   --------\n|\t\t\n" +
        "|    Name: " + deviceArray[currentDevNumber].getName() + "\n|\n" +
        "|    Price: " + deviceArray[currentDevNumber].getPrice() + " Euro \n";

            if (!showFullInfo)
                DeviceInfo = DeviceInfo + "\n-----------------------------------------";
            else
                DeviceInfo = DeviceInfo + "\n\n\n|  More info:\n|\n" +
    "|    Code: " + deviceArray[currentDevNumber].getDevice_Code() + "\n" +
    "|    Manufacturer: " + deviceArray[currentDevNumber].getManufacture() + "\n\n" +
    "-------------------------------------\n\n";

            return DeviceInfo;
        }


    }
}
