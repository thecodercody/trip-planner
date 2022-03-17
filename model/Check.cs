using System;
using System.Threading.Tasks;
class Check {
    
    //create single check object for program
    private static Check check = new Check();

    //ensure the constructor is never invoked
    private Check() {}

    //provide access to the check object
    public static Check getCheck() {
        return check;
    }

    //show check
    public void show() {
        //welcome the user
        Console.BackgroundColor = ConsoleColor.Red;
        System.Console.WriteLine("                              INVALID INPUT!                            ");
        Console.ResetColor();
    }

    public bool mainMenu(int option) {
        if(option < 1 || option > 3)
            return false;
        return true;
    }
}