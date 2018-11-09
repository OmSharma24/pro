Module ComputerDeck
    Public Sub computersDeck()

        Dim DogFile As Integer
        Dim dogs As New List(Of String) 'Declare a new list of dogs
        DogFile = FreeFile()



        FileOpen(DogFile, "C:\Users\omsha\Downloads\game.txt", OpenMode.Input)
        If IO.File.Exists("C:\Users\omsha\Downloads\game.txt") Then
            'Dim temporary As String = LineInput(1)
            While Not EOF(DogFile)
                dogs.Add(LineInput(DogFile)) 'Append to the list
                'Console.WriteLine(LineInput(DogFile))
            End While
                        FileClose(DogFile) 'closing the dog file 
                Else
            Console.WriteLine("could not find the file")
        End If
        computersCats(dogs) 'Pass the list into the subroutine
    End Sub


    'important code of the game 
    'this will be how to generate cards


    Public Sub computersCats(data As List(Of String)) 'cats is for category

        Dim chosenCategory As Integer
        Dim playersCategory As String = "1"
        Dim category As New Dictionary(Of String, Array)
        ''''Dim chosencategory As String = 'Console.ReadLine()
        Dim computerscategory As String = chosencategory
        Randomize()

        Console.WriteLine("
Computers deck:")
        Console.ReadKey()



        If chosenCategory = "exercise" Then
            Console.WriteLine("Computers' category: exercise")
            Dim randomEngine2 As New Random()
            Randomize()
            Dim index2 As Integer = randomEngine2.Next(0, data.Count - 1) 'Data.count is the number of items in the data list (dogs)

            Console.WriteLine(data(index2))
            Dim exercise2 As Integer = randomEngine2.Next(1, 5)


        ElseIf playersCategory = "intelligence" Then
            Console.WriteLine("Computers' category: ingtelligence")
            Dim randomEngine2 As New Random()
            Randomize()
            Dim index2 As Integer = randomEngine2.Next(0, data.Count - 1) 'Data.count is the number of items in the data list (dogs)

            Dim intelligence2 As Integer = randomEngine2.Next(1, 100)
            'Console.WriteLine(intelligence)

            Console.WriteLine(data(index2))
        ElseIf playersCategory = "friendly" Then
            Console.WriteLine("Computers' category: friendly")
            Dim randomEngine2 As New Random()
            Randomize()
            Dim index2 As Integer = randomEngine2.Next(0, data.Count - 1) 'Data.count is the number of items in the data list (dogs)

            Console.WriteLine(data(index2))
        ElseIf playersCategory = "drool" Then
            Console.WriteLine("Computers' category: drool")
            Dim randomEngine2 As New Random()
            Randomize()
            Dim index2 As Integer = randomEngine2.Next(0, data.Count - 1) 'Data.count is the number of items in the data list (dogs)

            Console.WriteLine(data(index2))

        End If

        Dim randomEngine As New Random()
        Randomize()

        Dim index As Integer = randomEngine.Next(0, data.Count - 1) 'Data.count is the number of items in the data list (dogs)

        Console.WriteLine(data(index))

        Randomize()

        Dim exercise As Integer = randomEngine.Next(1, 5)

        'Console.WriteLine(exercise)

        Randomize()
        Dim intelligence As Integer = randomEngine.Next(1, 100)
        'Console.WriteLine(intelligence)

        Randomize()
        Dim friendly As Integer = randomEngine.Next(1, 10)
        'Console.WriteLine(friendly)

        Randomize()
        Dim drool As Integer = randomEngine.Next(1, 10)
        'Console.WriteLine(drool)

        Select Case chosencategory
            Case "1"
                Console.WriteLine(exercise
                                      )
            Case "2"
                Console.WriteLine(intelligence
                                      )
            Case "3"
                Console.WriteLine(friendly
                                      )
            Case "4"
                Console.WriteLine(drool)
        End Select

        Console.ReadKey()


        ' Loop
        Console.ReadKey()


        'Next
    End Sub
End Module
