namespace WindowsFormsApp1
// JavaScript source code
function openAndReadFile(filepath) {
    //this function opens the file specified at filepath
    //reads and returns the content as a string
    file = fopen(getScriptPath("info.txt"), 0);


    file_length = flength(file);
    var content = fread(file, file_length);
    return content;
}