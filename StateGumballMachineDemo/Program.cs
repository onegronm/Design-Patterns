﻿using System;

namespace StateGumballMachineDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine);

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();

            Console.WriteLine(gumballMachine);
        }
    }
}
