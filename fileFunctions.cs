using System;
namespace WindowsFormsApp1

public static class fileFunctions {
    public string openFileFunc(string pathToFile) {
        String line;
        string output;
        try
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(pathToFile);

            //Read the first line of text
            line = sr.ReadLine();

            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the lie to console window
                Console.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
                output += line + Environment.NewLine;
            }

            //close the file
            sr.Close();
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        return output;
    }

    public string findAndReplaceFunc(string data, string toSearch, string replaceStr)
    {
        //this function will find and replace part of a string
        //returns the modified string
        string tempData = data;
        size_t pos = tempData.find(toSearch);
        //only replace is something is found
        if (pos != string::npos)
        {
            tempData.replace(pos, toSearch.size(), replaceStr);
        }

        return tempData;
    }

    public void writeToFile(string fileLocation, string data)
    {
        ofstream myfile;
        myfile.open(fileLocation);
        myfile << data;
        myfile.close();
    }

}