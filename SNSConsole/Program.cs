﻿using System;

namespace SNSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SNSOperations snsOperations = new SNSOperations();
            snsOperations.DeleteTopic();
            Console.ReadLine();
        }
    }
}
