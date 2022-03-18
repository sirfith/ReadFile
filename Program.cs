// See https://aka.ms/new-console-template for more information
{
    // The files used in this example are created in the topic
    // How to: Write to a Text File. You can change the path and
    // file name to substitute text files of your own.

    int mon = DateTime.Today.Month;
    int da = DateTime.Today.Day;
    int yer = DateTime.Today.Year;
    var time = DateTime.Now;

    //Console.WriteLine("{0}.{1}.{2}", mon, da, yer);
    //Console.WriteLine("{0}{1}{2}", mon, da, yer);
    // You could also write(although it's not really recommended):
    //Console.WriteLine(mon + "." + da + "." + yer);
    //   And, with the release of C# 6.0, you have string interpolation expressions:
    //Console.WriteLine($"{mon}.{da}.{yer}");  // note the $ prefix.
    //string date = ($"{mon}{da}{yer}");  // note the $ prefix.
    //Console.WriteLine(date);
    string fileName = @"C:/Temp/ADAREPT.D011521.txt";
    //Console.WriteLine(fileName);
    // Example #1
    // Read the file as one string.
    //   string text = System.IO.File.ReadAllText(fileName);

    // Display the file contents to the console. Variable text is a string.
    //     Console.WriteLine("Contents of {0} \n {1}",fileName, text);
    // Keep the console window open in debug mode.
    // Console.WriteLine("Press any key to continue.");
    // System.Console.ReadKey();
    // Example #2
    // Read each line of the file into a string array. Each element
    // of the array is one line of the file.
    string[] lines = System.IO.File.ReadAllLines(fileName);
    string s = "-------------------------------------------------------------------------------";
    string s1 = "Data Base Name          =";
    string s2 = "Data Base Number        =";
    string s3 = "U N U S E D   S T O R A G E";
    string s4 = "* File Options *";
    string s5 = "Contents of PPT";
    string s6 = "Contents of Database";
    string s7 = "***";
    bool b8 = false;
    // Display the file contents by using a foreach loop.
    Console.WriteLine("Contents of {0}", fileName);
    foreach (string line in lines)
   {
 
        bool b = line.Contains(s);
        bool b1 = (line.ToUpper().Contains(s1.ToUpper()));
        bool b2 = (line.ToUpper().Contains(s2.ToUpper()));
        bool b3 = line.Contains(s3);
        bool b4 = (line.ToUpper().Contains(s4.ToUpper()));
        bool b5 = (line.ToUpper().Contains(s5.ToUpper())); ;
        bool b6 = (line.ToUpper().Contains(s6.ToUpper())); ;
        bool b7 = (line.Contains(s7));

        // Use a tab to indent each line of the file. 
        // Console.WriteLine("\t" + line);
        //  Console.WriteLine(line);
        //  Console.WriteLine("{0} {1} {2} {3} {4} {5}",b,b1,b2,b3,b4,b5);
        if (!b7)
        {
            if (b4 || b5)
            {
                //  Console.WriteLine(line);
                b8 = false;
            }

            if (b3 || b6)
            {
                //   Console.WriteLine(line); 
                b8 = true;
                // Console.WriteLine("'{0}' is in the string '{1}': {2}",
                //        s2, line, b1);
                // int index = line.IndexOf(s2);
                // if (index >= 0)
                //    Console.WriteLine("'{0} begins at character position {1}",
                //                  s2, index + 1);
                // Console.WriteLine("Press any key to continue.");
                // System.Console.ReadKey();
            }
            if (b1 || b2 || b8)
            {
                Console.WriteLine(line);
                //        Console.WriteLine("'{0}' is in the string '{1}': {2}",
                //             s1, line, b);
                //    Console.WriteLine("Press any key to continue.");
                //  System.Console.ReadKey();
            }
        }
        // Keep the console window open in debug mode.
        // Console.WriteLine("Press any key to exit.");
        // System.Console.ReadKey();
    }
}