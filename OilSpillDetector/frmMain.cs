using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/*
Name: Fawaz Rizwan
Date (Start - End): April 11, 2023 - April 14, 2023
Program Name: OilSpillDetector
Program Description: To make a program that will detect the area of interest and the number of oil globs in an oil spill by reading a txt file
*/
namespace OilSpillDetector
{
    public partial class frmMain : Form
    {
        static StreamReader sr = new StreamReader("input.txt");     // Create StreamReader variable that will read the input.txt file
        static int NumberOfRows;        // Create a variable that will be equal to the number of rows in the 2d array that will hold the oil spill data
        static int NumberOfColumns;     // Create a variable that will be equal to the number of columns in the 2d array that will hold the oil spill data
        static char[,] OilSpillData;    // Create array of type char that will hold each character in the input file (holding the oil spill data)
        static char SkipCharacter1;     // Create a variable that will store a character we do not want stored in the OilSpillData array when reading the input.txt file
        static char SkipCharacter2;     // Create a variable that will store a character we do not want stored in the OilSpillData array when reading the input.txt file
        static bool Repeat = true;      // Create bool that will check if repetition is true to see if we need to read the next map in the input.txt file
        static int[] Coordinates = new int[2];      // Create variable that will hold the coordinates of the Area of interest. index 0 is the row and index 1 is the column.
        static char[,] CopiedArray;                 // Create an array of type char that will copy all the values of the OilSpillData array into it so that we can output the map in its original format.


        public frmMain()
        {
            InitializeComponent();
        }

        // When the user presses the load button, the input.txt file will read one of the maps (you have to click load again to read the next map), the area of interest will be detected, the OilSpillData array will be copied, the number of globs will be outputted, the map will be outputted in the txt file, and this process will repeat if there are more maps in the input.txt file.
        private void btnLoad_Click(object sender, EventArgs e)
        {
            // If repeat is true, then repeat everything method does.
            if (Repeat == true)
            {
                ReadOil();      // Read the input.txt file
                DetectArea(OilSpillData, ref lblAreaOfInterest);    // Find the area of interest. This method uses the OilSpillData as a parameter for looping through the values and the lblAreaOfInterest label as a parameter for output.
                CopiedArray = new char[OilSpillData.GetLength(0), OilSpillData.GetLength(1)];   // Set the size of the copy array to the same size of the length of the OilSpillData array
                copyArray(OilSpillData);    // This method will copy the values of the OilSpillData array to the CopiedArray. This method uses the OilSpillData array as a parameter.
                lblGlobNum.Visible = true;  // Make the label for the glob number visible
                lblGlobNum.Text = "Number of Globs: " + DetectGlobs(CopiedArray, Coordinates[0], Coordinates[1]).ToString();     // Output the number of globs in the text of lblGlobNum label by using the DetectGlobs array that detects the numnber of globs using the parameters, the copied array, the row coordinate of the area of interest, the column coordinate of the area of interest

                // For loop will output all the indexes of the OilSpillData
                for (int i = 0; i < OilSpillData.GetLength(0); i++)     // i is for the rows of the array
                {
                    for (int j = 0; j < OilSpillData.GetLength(1); j++)     // j is for the columns of the array
                    {
                        txtOilSpillVisual.AppendText(OilSpillData[i, j].ToString());        // Append the OilSpillData array characters in the textbox. This will keep adding to the text in the textbox instead of replacing the text in it. Learned from: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.textboxbase.appendtext?view=netframework-4.8
                    }

                    txtOilSpillVisual.AppendText("\r\n");       // Add a carriage return and a new line so that after each row, a new row starts
                }
                Repeat = false;     // Make repeat false so that the function will not repeat 
            }

            string Check = sr.ReadLine();   // This will read right after the final line.
            // If the line check is empty then make repeat true so that the function will run again if the user presses the load button
            if (Check == "")
            {
                Repeat = true;  // Make repeat true
            }
        }
        
        // This function will read the input.txt file
        void ReadOil()
        {
            txtOilSpillVisual.Text = null;      // Make the oil spill display text box empty so that the old map displayed will be erased from the text box
            NumberOfRows = int.Parse(sr.ReadLine());    // Read the first line of the txt file which represents the number of rows in the array
            NumberOfColumns = int.Parse(sr.ReadLine());     // Read the second line of the txt file which represents the number of columns in the array
            OilSpillData = new char[NumberOfRows, NumberOfColumns];     // Assign the size of the OilSpillData array using the row and column size read from the txt file

            // Assign each index of the array a character by reading the txt file
            // The i is for the index of the rows
            for (int i = 0; i < NumberOfRows; i++)
            {
                // The j is for the index of the columns
                for (int j = 0; j < NumberOfColumns; j++)
                {
                    // Check if there is a new line or carriage return character escape sequences in the txt file
                    // If there are any then store them in skip characters variables so that they will not be included in the OilSpillDataArray
                    if (sr.Peek() == '\n' || sr.Peek() == '\r')
                    {
                        SkipCharacter1 = (char)sr.Read();       // Store the value that wants to be skipped in this variable
                        SkipCharacter2 = (char)sr.Read();       // Store the value that wants to be skipped in this variable
                    }
                    OilSpillData[i, j] = (char)sr.Read();       // Store each character in the array. Convert the value to type char. Learned to convert to type char from: https://learn.microsoft.com/en-us/dotnet/api/system.io.streamreader.read?view=net-7.    
                }
            }
        }

        // This method will find the area of interest. The parameters used is a 2d char array called DataArray which will represent the oil spill data, and the label for area of interest is referenced to the area of interest label so that the area of interest will be outputted
        void DetectArea(char[,] DataArray, ref Label AreaOfInterest)
        {
            // This will look through each of the elements of the array to find which one is the area of interest
            // The i is for the index of the rows
            for (int i = 0; i < DataArray.GetLength(0); i++)
            {
                // The j is for the index of the columns
                for (int j = 0; j < DataArray.GetLength(1); j++)
                {
                    if (DataArray[i, j] == 'A')
                    {
                        Coordinates[0] = i;     // Store the Row number in an coordinates array
                        Coordinates[1] = j;     // Store the Column number in cooridinates array
                        AreaOfInterest.Visible = true;      // Make the area of interst label visible
                        AreaOfInterest.Text = "Area of interest at row " + (Coordinates[0] + 1) + " column " + (Coordinates[1] + 1);    // Display the area of interest coordinates
                    }
                }
            }
        }

        // This method will copy the OilSpillData array elements into a copy array. The parameter ArrayToCopy will take the array we want to copy.
        void copyArray(char[,] ArrayToCopy)
        {
            // Loop through the copy array and the original array to assign the values of each element in the original array to the copy array
            // The i is for the index of the rows
            for (int i = 0; i < ArrayToCopy.GetLength(0); i++)
            {
                // The j is for the index of the columns
                for (int j = 0; j < ArrayToCopy.GetLength(1); j++)
                {
                    CopiedArray[i, j] = ArrayToCopy[i, j];  // Copy the values of the original array to the copied array
                }
            }
        }

        // I am using the concept of recursion here. Recursion is a technique where a function calls itself repeatedly until a terminating conditon is met. Once the terminating condition is met all results are combined to get the final result. In this case I am calling the function itself recursively to check for GLobs at immediate Up, Down, Left and right positions. In our case the terminating condition is when the immediate next up/down/left/right spot is not Glob (i.e, #) or Area of interest (i.e A). also each time my program visits a Glob I mark it as "G" so I don't end up counting it more than once.
        // This method will detect the number of globs using recrusion. The char array data will take in the OilSpillData array, the AreaOfInterestRow parameter will take in the row number of the area of interest, the AreaOfInterestColumn parameter will take in the column number of the area of interest.
        // This method is of type int will return the Count variable which represents the total number of globs
        static int DetectGlobs(char[,] OilData, int AreaOfInterestRow, int AreaOfInterestColumn)
        {
            // Checking if the current cell value is a glob
            // If the row and column number of the area of interest is greater than or equal to 0 and is less than the size of the array (so that index is not out of bounds) and if the row/column is either a glob or area of interest then execute the if statement
            if (AreaOfInterestRow >= 0 && AreaOfInterestRow < OilData.GetLength(0) && AreaOfInterestColumn >= 0 && AreaOfInterestColumn < OilData.GetLength(1) && (OilData[AreaOfInterestRow, AreaOfInterestColumn] == '#' || OilData[AreaOfInterestRow, AreaOfInterestColumn] == 'A'))
            {
                // Change the value of the character if it is a glob so that the same character will not be read twice
                OilData[AreaOfInterestRow, AreaOfInterestColumn] = 'G';
                // Counting the current Glob or Area of interest as 1
                int Count = 1;

                // Checking the AreaOfInterest is not out of bound from the array at the top
                if (AreaOfInterestRow > 0)   
                {
                // Calling the function recursively to check spot at immediate UP position from the current position.
                    Count += DetectGlobs(OilData, AreaOfInterestRow - 1, AreaOfInterestColumn);
                }

                // Checking the AreaOfInterest is not out of bound from the array at the bottom
                if (AreaOfInterestRow < OilData.GetLength(0))
                {
                    // Calling the function recursively to check spot at immediate DOWN position from the current position.
                    Count += DetectGlobs(OilData, AreaOfInterestRow + 1, AreaOfInterestColumn);
                }

                // Checking the AreaOfInterest is not out of bound from the array on the left side
                if (AreaOfInterestColumn > 0)
                {
                    // Calling the function recursively to check spot at immediate LEFT position from the current position.
                    Count += DetectGlobs(OilData, AreaOfInterestRow, AreaOfInterestColumn - 1);
                }

                // Checking the AreaOfInterest is not out of bound from the array on the right side
                if (AreaOfInterestColumn < OilData.GetLength(1))
                {
                    // Calling the function recursively to check spot at immediate RIGHT position from the current position.
                    Count += DetectGlobs(OilData, AreaOfInterestRow, AreaOfInterestColumn + 1);
                }

                // returning the total count once all UP, DOWN, LEFT and RIGHT position Globs has been checked and counted.
                return Count;
            }
            else
            {
                return 0;   // If the value in the Oil data is not a glob then return 0
            }
        }

        // When the exit button is clicked, the program will close
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();       // Close the program
        }
    }
}
