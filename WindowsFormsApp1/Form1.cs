using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Helper Functions
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
             *  data: a string to be manipulated
             *  toSearch: a string of the data you want to find
             *  replaceStr: the text you want to replace the toSearch text with
             * Return Value:
             *  returns the modified string
             */
            //StringBuilder has a Replace() function built in, strings do not
            if (data.Length != 0)
            {
                StringBuilder builder = new StringBuilder(data);
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
            fileText = openFileFunc(pathToFile);
            string defaultText = fileText;
            richTextBox1.Text = fileText;
            string editedText;
            editedText = findAndReplaceFunc(fileText, toSearch, replaceStr);
            richTextBox1.AppendText(Environment.NewLine + editedText);
            richTextBox1.AppendText(Environment.NewLine + "Writing data to the file...");
            writeToFile(pathToFile, editedText);
            richTextBox1.AppendText(Environment.NewLine + "New text is:");
            fileText = openFileFunc(pathToFile);
            richTextBox1.AppendText(Environment.NewLine + fileText);
            writeToFile(pathToFile, defaultText);
        }
        //Form1
        public Form1()
        {
            InitializeComponent();
        }
        //tracks which tweak is using checkBox1, set inside treeView1_AfterSelect method
        int tweak = 0;
        string modDirectory = "C:\\git_local"; //default value for testing
        //this function handles mouse clicks on the treeView1
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //checkBox1 is only visible as needed
            checkBox1.Visible = false;
            //check which child node (menu item) has been clicked on
            //then update richTextBox1 text
            if (e.Node.Text == "Spawn Rate")
            {
                //select richTextBox1 gui item and add text
                //@ in front a string creates a multiline string
                richTextBox1.Text = (@"To change the chances of capturing unique spawn leaders and lords, and remove the predetermined chances - credits to VonDegurechaff and Vetrogor
                                    Every 120 hours, a random value between 0 and 100(0...99) gets rolled and saved, let's call it 'x'. Once you defeat a unique spawn, the leader will be captured if x + (prisoner_management_skill * 5) >= 60. In case of lords, the value 'x' is rolled after each battle per lord, so the chance to capture them isn't prerolled." +
                                    "Regardless of the outcome of trying to capture a unique spawn leader, x gets immediately reset to a random value between 0 and 100.This is only done if you participate in that battle, not if some lords wreck the spawn without you. So if you never battle any spawn, that value 'x' is only rerolled every 5 days.If you beat up one however, regardless of having actually captured the spawn-leader or not, the value is rolled again, independently of the usual 5 - day cycle.It is also worth to note that if either Ithilrandir or Aeldarian is present in a battle against another unique spawn, then 'x' is replaced with straight - 100, meaning that unique spawns leaders will always escape after such fights.With this tweak, we can sort of bypass that penalty.");
            }
            if (e.Node.Text == "Order Stronghold")
            {
                //update text of richTextBox1
                richTextBox1.Text = ("This tweak will allow you to garrison troops into the Stronghold, or to take them out. As of v3.9.4, due to the Hideout feature, you'll have to pay 75% of the wages of the garrison once you've touched it (added or removed a troop), as well as an extra of 500 denars for the upkeep of the crew in there. At least the Order Stronghold will never be attacked, so your troops will always be safe there.");
                checkBox1.Visible = true;
                checkBox1.Text = "Enable tweak";
                tweak = 1;
                
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if checkBox1 is checked
            if (checkBox1.Checked)
            {
                //check which tweak is used
                if (tweak == 1)
                {

                    callAllFileFuncs(modDirectory + "\\test.txt", "Writing text a file.", "Changing the text of a file.");


                }
            }
        }


        private void selectDirectoryButton_Click(object sender, EventArgs e)
        {
            //this function will 1. open the folder browser 2. save the path to modDirectory
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Select a folder";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    //store the path
                    modDirectory = dlg.SelectedPath;
                    textBox1.Text = "Current Diretory:" + System.Environment.NewLine + modDirectory;
                    //dynamically readjust textBox1 width
                    Size size = TextRenderer.MeasureText(textBox1.Text, textBox1.Font);
                    textBox1.Width = size.Width;
                }
            }
        }

        private void testTweaksButton_Click(object sender, EventArgs e)
        {
            callAllFileFuncs(modDirectory + "\\test.txt", "Writing text a file.", "Changing the text of a file.");
        }
    }
}
