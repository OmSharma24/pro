
Module Menu

    Sub Main()
        Console.ForegroundColor = ConsoleColor.Blue
        Console.Clear()
        Dim title As String = "Welcome to celebrity Dogs"


        Dim leftMargin = Console.WindowWidth / 2 - title.Length / 2 '|
        writeCentered(title, 1, leftMargin)                         ' } this is the code to write the title in the middle before the menu option.
        Console.ReadKey(True)                                       '|

        'menu for the game
        Dim theMenu As New ConsoleMenu
        Console.ForegroundColor = ConsoleColor.Blue
        theMenu.AddMenuItem("Play", New Action(AddressOf Play))
        theMenu.AddMenuItem("Instruction", New Action(AddressOf Instruction))
        theMenu.AddMenuItem("Quit", New Action(AddressOf Quit1))

        theMenu.RunMenu()
    End Sub

    Public Sub writeCentered(line As String, y As Integer, leftMargin As Integer
                             )
        If line Is Nothing Then line = String.Empty
        Dim leftPad = Console.WindowWidth \ 2 - line.Length \ 2 - leftMargin

        Console.SetCursorPosition(leftMargin, y)
        If leftPad > 0 Then Console.Write(Space(leftPad))
        Console.Write(line)
    End Sub

    Public Class ConsoleMenu
        'Public Class ConsoleMenu
        Private menuItems As New Dictionary(Of String, Action)
        Private selectedIndex As Integer

        Public Sub AddMenuItem(caption As String, actionToRun As Action)
            menuItems(caption) = actionToRun
        End Sub

        Public Sub RunMenu()
            selectedIndex = 0
            Console.Clear()
            Console.ResetColor()
            Dim fColor As ConsoleColor = Console.ForegroundColor
            Dim bColor As ConsoleColor = Console.BackgroundColor

            Dim maxKeyLength = menuItems.Keys.Max(Of Integer)(Function(keyStr As String)
                                                                  Return keyStr.Length
                                                              End Function)
            Dim leftMargin = Console.WindowWidth \ 2 - maxKeyLength \ 2


            writeCentered("Menu", 1, leftMargin
                          )

            Do
                For i = 0 To menuItems.Keys.Count - 1
                    If i = selectedIndex Then
                        Console.BackgroundColor = fColor
                        Console.ForegroundColor = bColor
                    Else
                        Console.ForegroundColor = fColor
                        Console.BackgroundColor = bColor
                    End If
                    writeCentered(menuItems.Keys(i), i + 2, leftMargin
                                  )
                Next
                Console.ResetColor()
                Select Case Console.ReadKey(True).Key
                    Case ConsoleKey.UpArrow
                        selectedIndex -= 1
                        If selectedIndex < 0 Then selectedIndex += menuItems.Count
                    Case ConsoleKey.DownArrow
                        selectedIndex += 1
                        If selectedIndex > menuItems.Count - 1 Then selectedIndex -= menuItems.Count
                    Case ConsoleKey.Enter
                        Console.Clear()
                        menuItems(menuItems.Keys(selectedIndex))() 'Invoke the desired method/action
                        Exit Do
                    Case ConsoleKey.Escape
                        Exit Do
                End Select
            Loop
            Console.Clear()
        End Sub
    End Class


End Module
