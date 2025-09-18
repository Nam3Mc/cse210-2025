// for this program i'm retriving information form a webside  
// i just get random verses and then used the clases to organize it and  
// display on the screem hidding words randomly 
// i also hacve the option of memorizin ine verse or 2 verses
// the program was growing to much so i did not add mote features 
// it contains the 3 clasess and some more i used to handled errors 
// i also have a menu with the 2 options to memorize a simple verse 
// or multople verse both retrived form internet 

class Program
{
    static async Task Main(string[] args)
    {
        InputTaker newInput = new InputTaker();
        await newInput.Menu();
    }
}