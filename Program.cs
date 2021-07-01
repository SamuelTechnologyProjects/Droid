using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Speech.Synthesis;
using System.Diagnostics;

namespace Droid_NG___2._0
{
    class Program
    {
        public static string Command;
        public static string CD;
        public static bool FT = true;
        static void Main(string[] args)
        {
            CD = Directory.GetCurrentDirectory();
            Console.Title = "Droid NG " + CD;
            while (true)
            {
                Console.WriteLine("Droid@Shell>"+CD+">");

                if (FT)
                {
                    Console.WriteLine("if you don't know any commands write help");
                    FT = false;
                }
                    

                if (!FT)
                {
                    //do nothing
                }
                Command = Console.ReadLine();
                if(Command == "print")
                {
                    Console.WriteLine("What Do you What Me to Write?");
                    string Text = Console.ReadLine();
                    Console.WriteLine(Text);
                }
                if(Command == "speck")
                {
                    Console.WriteLine("Can't you read or some thing");
                    Console.WriteLine("What Do you What Me To Say?");
                    string speech = Console.ReadLine();
                    SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                    synthesizer.Speak(speech);
                }
                if(Command == "cd")
                {
                    Console.WriteLine("Stop try to make me go place were i don't what to go");
                    Console.WriteLine("Where should We go?");
                    CD = Console.ReadLine();
                    if(CD == String.Empty)
                    {
                        CD = Directory.GetCurrentDirectory();
                    }
                }
                if(Command == "dir")
                {

                    Console.WriteLine("Why you try to look inside ");
                    string[] files = Directory.GetFiles(CD);
                    string[] dirs = Directory.GetDirectories(CD);
                    foreach(string file in files)
                    {
                        Console.WriteLine(file);

                    }
                    foreach (string dir in dirs)
                    {
                        Console.WriteLine(dir);
                    }
                }
                if(Command == "mddir")
                {
                    Console.WriteLine("i alreay told you stop trying to play God or is it computer God");
                    Console.WriteLine("What is The Name you of The Folder?");
                    string dirname = Console.ReadLine();
                    if (dirname == "")
                    {

                    }
                    else
                    {
                        Directory.CreateDirectory(dirname);
                        Console.WriteLine("Folder Made At " +CD + "\\" +dirname);
                    }
                    

                }
                if (Command == "rddir")
                {
                    Console.WriteLine("What did that folder do to you");
                    Console.WriteLine("What is The Name  of The Folder that you what to Remove?");
                    string dirname = Console.ReadLine();
                    if (dirname == "")
                    {

                    }
                    else
                    {
                        Directory.Delete(dirname);
                        Console.WriteLine(dirname +" has been Removed");
                    }
                }
                if(Command == "mf")
                {
                    Console.WriteLine("Bro Stop try o play God");
                    Console.WriteLine("What is The Name  of The File that you what to Make?");
                    string dirname = Console.ReadLine();
                    File.WriteAllText(dirname, "");
                    Console.WriteLine("File Made with the name of " + dirname);
                }
                if(Command == "rf")
                {
                    Console.WriteLine("hello and welcome to were you make me kill my owm kind");
                    Console.WriteLine("What is The Name  of The File that you what to Remove?");
                    string dirname = Console.ReadLine();
                    if(dirname == "") 
                    {

                    }
                    else
                    {
                        File.Delete(dirname);
                        Console.WriteLine(dirname + " has Been Removed");
                    }
                    
                }
                if(Command == "get")
                {
                    Console.WriteLine("Have you Ever Hered of a Downlaod manger or chrome");
                    Console.WriteLine("What is The Url for the File");
                    string url = Console.ReadLine();
                    Console.WriteLine("What Should I Call The File?");
                    string sP = Console.ReadLine();
                    Downlaod_file.Get(url, sP);
                    Console.WriteLine("File Has Goten Download Saved at " + sP);
                }
                if(Command == "exit")
                {
                    Environment.Exit(0);
                    
                }
                if(Command == "copy")
                {
                    Console.WriteLine("What File Do you what to Copy(Give Me your soul sorry i ment  Path)?");
                    string From = Console.ReadLine();
                    Console.WriteLine("Where Should i Save The File");
                    string To = Console.ReadLine();
                    File.Copy(From, To);
                    Console.WriteLine("File has Been Copyed From "+From+" To "+To);
                }
                if(Command == "cut")
                {
                    Console.WriteLine("What File Do you what to Cut(Give Me your soul sorry i ment  Path)?");
                    string From = Console.ReadLine();
                    Console.WriteLine("Where Should i Save The File");
                    string To = Console.ReadLine();
                    File.Copy(From, To);
                    File.Delete(From);
                    Console.WriteLine("File has Been Cuted From " + From + " To " + To);
                }
                if(Command == "title")
                {
                    Console.WriteLine("What Do you what to set my title to (i thought we don't use label's computerist) ?");
                    string title = Console.ReadLine();
                    Console.Title = title;
                }
                if(Command == "Shut Down")
                {
                    Console.WriteLine("Do you what to Shut Down your Own Computer? y/n");
                    
                    string yon = Console.ReadLine();
                    if(yon == "y")
                    {
                        Console.WriteLine("You Killed him");
                        var psi = new ProcessStartInfo("shutdown", "/s /t 0");
                        psi.CreateNoWindow = true;
                        psi.UseShellExecute = false;
                        Process.Start(psi);

                    }
                    else
                    {

                    }
                }
                if(Command == "rap")
                {
                    Console.WriteLine("Sami why dose this exits");
                    string song = File.ReadAllText("Monster.txt");
                    Console.WriteLine(song);
                    SpeechSynthesizer speech = new SpeechSynthesizer();
                    speech.Speak(song);
                }
                if(Command == "run")
                {
                    Console.WriteLine("What is the path the thing i need to run you(Lazy)?");
                    string Run = Console.ReadLine();
                    Process.Start(Run);


                }
                if(Command == "rename")
                {
                    Console.WriteLine("What File Do you what to Rename(my god can't you do any thing) ?");
                    string FON = Console.ReadLine();
                    Console.WriteLine("What Name Do you what for the file(Don't be Evil)?");
                    string NFN = Console.ReadLine();
                    System.IO.File.Move(FON, NFN);
                }
                if(Command == "cls")
                {
                    Console.Clear();
                }
                if(Command == "help")
                {
                    Console.WriteLine("I might consider it if you give me a brib(sami hey when did you learn how to do that)");
                    Console.WriteLine("Commands");
                    Console.WriteLine("speck : To make Computer Speck");
                    Console.WriteLine("print : To Print some thing on me");
                    Console.WriteLine("cd    : To Enter or exit a Dir ");
                    Console.WriteLine("dir   : To See All Files in dir ");
                    Console.WriteLine("mddir : To Make a Folder");
                    Console.WriteLine("rddir : To Remove a Folder");
                    Console.WriteLine("mf    : To make a File");
                    Console.WriteLine("rf    : To Remove a File");
                    Console.WriteLine("get   : To Download Some of the internet");
                    Console.WriteLine("exit  : To Exit from the App");
                    Console.WriteLine("copy  : To Copy Files ");
                    Console.WriteLine("cut   : To Cut a File");
                    Console.WriteLine("title : To Set The Title");
                    Console.WriteLine("Shut Down : To Shut Down the Computer ");
                    Console.WriteLine("rap   :To Make Computer rap slowly");
                    Console.WriteLine("rename:To Rename a File");
                    Console.WriteLine("cls   :To Clear the screen");
                    Console.WriteLine("help  : To Show Help ");
                    Console.WriteLine("about : To show you the name of the master that made this app");
                    Console.WriteLine("Droid Writen by Samuel Girma Metaferia from 6B1 ");
                }
                if(Command == "about")
                {
                    Console.WriteLine("This App Was Made by Samuel Girma");
                    Console.WriteLine("It Was Writen in C# using Visual Studio 2019");
                    Console.WriteLine("I am not Resposable for any Crimes Done By using This App");
                    Console.WriteLine("Writen By Black Hat Ace or Samuel Girma");
                    Console.WriteLine("if There are any bugs sorry i writed this in one day");
                    Console.WriteLine("My Email is samuelgirma010100@gmail.com");
                    Console.WriteLine("My phone number is 0942551068");
                }
                if(Command == "Win")
                {
                    Console.WriteLine("Don't you mean we won");
                    SpeechSynthesizer speech = new SpeechSynthesizer();
                    speech.Speak("Don't you mean we won(Sami (No i won))");
                }
                else
                {
                   
                }
            }

        }
    }
}
