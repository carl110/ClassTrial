using System;
using System.IO;
namespace ClassTrial
{
    public class DataPull
    {

        public DataPull()
        {

        }


        static void exportToTextFile(string[,] myArray)
        {   //Create file to write to
            System.IO.StreamWriter myFile = new System.IO.StreamWriter("/Users/carlwainwright/Desktop/Docs for ICT Apprentiship/fileNames.txt");
            //create a string
            string output = "";
            //Loop row
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                //Loop column
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    //add array item to string
                    output += " " + myArray[i, j].ToString();
                }
                //write each row on a new line in text file
                myFile.WriteLine(output);
                //clear output string to ready for next input on loop
                output = "";
            }
            //Close the editing of the created file
            myFile.Close();
        }



    }

}




