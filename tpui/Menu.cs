using System;
class Menu {
    
    //create single menu object for program
    private static Menu menu = new Menu();

    //ensure the constructor is never invoked
    private Menu() {}

    //provide access to the menu object
    public static Menu getMenu() {
        return menu;
    }

    //show menu
    public void show() {
            Console.ResetColor();
            System.Console.WriteLine();
            System.Console.WriteLine("1. View list of all planned trips");
            System.Console.WriteLine("2. View/Modify a specific planned trip");
            System.Console.WriteLine("3. Plan a new trip");
            Console.BackgroundColor = ConsoleColor.Gray;
            System.Console.WriteLine();
            Console.ResetColor();
            System.Console.Write("Please choose an option: ");        
    }
}