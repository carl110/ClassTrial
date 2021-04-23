using System;
using System.IO;
namespace ClassTrial
{
    public class App
    {
        private Device[] deviceArray = new Device[0];
        private int currentDevice = 0;
        public bool showFullInfo;

        public App()
        {
            string deviceLocation = "/Users/carlwainwright/Desktop/deviceList.txt";
            string[] name = importFromTxt(deviceLocation).Item1;
            double[] price = importFromTxt(deviceLocation).Item2;
            string[] deviceID = importFromTxt(deviceLocation).Item3;
            string[] manufacturer = importFromTxt(deviceLocation).Item4;

            Array.Resize(ref deviceArray, name.Length);

            for (int i = 0; i < name.Length; i++)
            {
                deviceArray[i] = new Device(name[i], price[i], deviceID[i], manufacturer[i]);
            }

            
        }

       

        public string getPreviousDevice()
        {
            if (currentDevice == 0)
            {
                currentDevice = deviceArray.Length - 1;
            }
            else
            {
                currentDevice--;
            }
            return getDeviceInfo(currentDevice, deviceArray.Length);
        }

        public string getNextDevice()
        {
            if (currentDevice == deviceArray.Length - 1)
            {
                currentDevice = 0;
            }
            else
            {
                currentDevice++;
            }
            return getDeviceInfo(currentDevice, deviceArray.Length);
        }

        public string getFirstDevice()
        {
            currentDevice = 0;

            return getDeviceInfo(currentDevice, deviceArray.Length);
        }

        public string getLastDevice()
        {
            currentDevice = deviceArray.Length - 1;

            return getDeviceInfo(currentDevice, deviceArray.Length);
        }

        public string getCurrentDevice()
        {
            return getDeviceInfo(currentDevice, deviceArray.Length);
        }

        public string getDeviceInfo(int currentDevNumber, int numOfDevices)
        {
            String DeviceInfo =
        "\n----------------------------------------\n\n" +
        "|\t\tDevice Information \n|\n" +
        "|\t\t   --------\n" +
        "|\t\t   " + (currentDevNumber + 1) + " of " + numOfDevices +"\n" +
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

        private static Tuple<string[], double[], string[], string[]> importFromTxt(string fileLocation)
        {
            string[] name = new string[0];
            string[] price2 = new string[0];
            double[] price = new double[0];
            string[] device_code = new string[0];
            string[] manuf = new string[0];
            //Create int for ‘countRow’ = 0
            int countRow = 0;
            //Create int for ‘countColumn’ = 0
            int countColumn = 0;
            //Create int for 'rowNum' = 0
            int rowNum = 0;
            //Create int for 'columnNum' = 0
            int columnNum = 0;
            //Check if file location exists
            if (File.Exists(fileLocation))
            {//Loop all lines of text from ‘fileLocation’
                foreach (var row in File.ReadAllLines(fileLocation))
                {//Loop all words separated by a space from ‘fileLocation’
                    foreach (var column in row.Trim().Split(','))
                    {//Increase ‘countColumn’ by 1
                        countColumn++;
                    }
                    //Increase ‘countRow’ by 1
                    countRow++;
                }
                //Update ‘countColumn’ = ‘countColumn’ / ‘countRow’
                countColumn /= countRow;
                //Create empty 2Darray ‘myArray’ with rows = ‘countRow’ and columns = ‘countColumn’
                string[,] myArray = new string[countRow, countColumn];
                //Loop over each line of text from ‘fileLocation’
                foreach (var row in File.ReadAllLines(fileLocation))
                {//Update ‘columnNum’ = 0
                    columnNum = 0;
                    //Loop all words separated by a space from ‘fileLocation’
                    foreach (var column in row.Trim().Split(','))
                    {//Append each new string to ‘myArrray ‘ at index of 'rowNum' and 'columnNum'
                        myArray[rowNum, columnNum] = column;
                        //Increase 'columnNum by 1
                        columnNum++;
                    }
                    //Increase ‘rowNum’ by 1                   
                    rowNum++;
                }

                name = new string[rowNum];
                price2 = new string[rowNum];
                price = new double[rowNum];
                device_code = new string[rowNum];
                manuf = new string[rowNum];
                //return myArray;
                for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    name[i] = myArray[i, 0];
                    price[i] = Convert.ToDouble(myArray[i, 1]);
                    device_code[i] = myArray[i, 2];
                    manuf[i] = myArray[i, 3];

                }

                return Tuple.Create(name, price, device_code, manuf);
            }
            else
            {//Print "This file does not exist"
                Console.WriteLine("This file does not exist");
                //return new string[0, 0];
                return Tuple.Create(name, price, device_code, manuf);
            }


        }


    }
}
