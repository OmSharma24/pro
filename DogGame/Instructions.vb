
Module Module1
    Public Sub Instruction()


        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.WriteLine("Welcome to celebrity dogs
In this game there is pack of cards representing famous dogs. 

They have categories such as:  
* Exercise		- 1-5
* Intelligence 		- 1-100
* Friendliness		- 1-10
* Drool 		- 1-10 
The game will be played against the computer. It consists of a series of round. Player is kindly asked to enter the number of cards in the pack. The player and the computer receive half cards each from the pack of cards. 

The player is shown the first card. Then asked to choose one out of four categories, from above.

If the player chooses exercise, friendliness or intelligence then - 
A. If the players card is equal to or higher than the computer's card then both player's card is put at the bottom of the player's piles of cards. 
B. If the player's card is lower than the computer's card then both cards are put at the bottom of the computer's pile of cards. 

If the category chose was drool, then - 
A. If the players card is equal or lower than the computers card card then both cards are put at the bottom player's pile of cards. 
B. If the players card is higher than the computer's card then both cards are put at the bottom of the computers pile of cards. 

If the player won the comparison then they won that round and the next card is revealed and they choose a category for that round. ")
        Console.WriteLine("(press any key to continue...)")
        Dim key = Console.ReadKey(True).Key

        If key = ConsoleKey.Enter Then
            Main()
        End If
        'Loop

    End Sub
End Module
