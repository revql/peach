﻿namespace peach;

internal class Shell
{
    internal static int LIMIT_INPUT { get; set; } = 0;

    internal static void Start()
    {
        LIMIT_INPUT = Data.Process.Length + 3;

        while (true)
        {
            Input.PrintInput();
            string command = Input.GetInput();

            // here.
        }
    }
}
