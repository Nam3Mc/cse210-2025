using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        InputTaker newInput = new InputTaker();
        await newInput.Menu();
    }
}