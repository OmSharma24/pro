Module Quit
    'Quit option
    Public Sub Quit1()
        Console.ForegroundColor = ConsoleColor.DarkRed
        Console.WriteLine("Thank You for playing Celebrity Dogs")
        Console.WriteLine("(press any key to exit...)")
        Console.ReadKey(True) 'You Console.ReadKey() because the user presses any key

        MsgBox("Are you sure you want to quit?")
    End Sub
End Module
