using System;

namespace helperFunctions
{

    class helperFunctions
    {
        //Helper Functions
        public string multilineToSinglelineFunc(string inputString)
        {
            /* Purpose:
            *  convert multiline string into single line
            *  and change double space "  " into single " "
            * Paramaters:
            *  inputString: a string to convert to single line
            * Return Value:
            *  return the modified string
            */
            //convert multiline string into single line
            inputString = inputString.Replace(Environment.NewLine, " ");
            inputString = inputString.Replace("\r\n", " ");
            inputString = inputString.Replace("  ", " ");
            return inputString;
        }
        public string openFileFunc(string pathToFile)
        {
            /* Purpose:
            *  this function will open a file and read it's contents
            * Paramaters:
            *  pathToFile: a windows file path
            * Return Value:
            *  return the opened files contents as a string
            */
            String line;
            string output = "";
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader file = new StreamReader(pathToFile);
                //Read the first line of text
                line = file.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    output += line;
                    output += Environment.NewLine;
                    //Read the next line
                    line = file.ReadLine();
                }
                //close the file
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return output;
        }
        public string findAndReplaceFunc(string data, string toSearch, string replaceStr)
        {
            /* Purpose:
             *  this function will find and replace part of a string
             * Paramaters:
             *  data: a string to be manipulated (does not work with multiline strings)
             *  toSearch: a string of the data you want to find
             *  replaceStr: the text you want to replace the toSearch text with
             * Return Value:
             *  returns the modified string if data.length > 0
             *  returns data if no data provided
             */
            //StringBuilder has a Replace() function built in, strings do not
            if (data.Length != 0)
            {
                StringBuilder builder = new StringBuilder(data);
                toSearch = multilineToSinglelineFunc(toSearch);
                replaceStr = multilineToSinglelineFunc(replaceStr);
                builder.Replace(toSearch, replaceStr);
                string tempData = builder.ToString();
                return tempData;
            }
            //if no data, return no data
            return data;
        }

        public void writeToFile(string pathToFile, string data)
        {
            /* Purpose:
            *  this function will write data to a file
            * Paramaters:
            *  pathToFile: a windows file path
            *  data: the data you wish to write to the file
            * Return Value:
            *  none
            */
            StreamWriter file = new StreamWriter(pathToFile);
            file.Write(data);
            file.Close();
        }

        public void callAllFileFuncs(string pathToFile, string toSearch, string replaceStr)
        {
            /* Purpose:
           *  this function will call openFileFunc(), findAndReplaceFunc(), writeToFileFunc()
           * Paramaters:
           *  pathToFile: a windows file path
           *  toSearch: a string of the data you want to find
           *  replaceStr: the text you want to replace the toSearch text with
           * Return Value:
           *  none
           */
            string fileText;
            //get the file text
            fileText = openFileFunc(pathToFile);
            string editedText;
            //find and replace
            editedText = findAndReplaceFunc(fileText, toSearch, replaceStr);
            //write edited data back to the file
            writeToFile(pathToFile, editedText);

        }

    }
}