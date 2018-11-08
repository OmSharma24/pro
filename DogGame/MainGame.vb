Module PlayGAME

    Public Sub Play()

        Dim fileNum As Integer
        Dim dogs As New List(Of String) 'Declare a new list of dogs
        fileNum = FreeFile()

        FileOpen(fileNum, "C:\Users\omsha\Downloads\game.txt", OpenMode.Input)

        If IO.File.Exists("C:\Users\omsha\Downloads\game.txt") Then

            While Not EOF(fileNum)
                dogs.Add(LineInput(fileNum))
            End While

            FileClose(fileNum)
        Else

            Console.WriteLine("could not find the file")
        End If

        Cats(dogs) 'Pass the list into the subroutine "C:\Users\omsha\Downloads\game.txt"
    End Sub

    Function ReadNames(file)
        Dim fileNum As Integer
        Dim dogs As New List(Of String) 'Declare a new list of dogs
        fileNum = FreeFile()

        FileOpen(fileNum, file, OpenMode.Input)

        If IO.File.Exists(file) Then

            While Not EOF(fileNum)
                dogs.Add(LineInput(fileNum))
            End While

            FileClose(fileNum)
        Else

            Console.WriteLine("could not find the file")
        End If

        Return dogs
    End Function

    Public Sub Cats(data As List(Of String)) 'cats is for category

        Dim name As String
        Dim message As String = " "

        Console.Write("Please enter your name!")

        name = Console.ReadLine()
        Console.ReadKey()
        Do
            Dim number As Integer
            ' Dim category As New Dictionary(Of String, Array)
            Do
                Console.Clear()
                Console.ForegroundColor = ConsoleColor.DarkRed

                Console.WriteLine("Chose a number!")
                Console.WriteLine("The  number must be greater than 4, less than 30 & IT SHOULDN'T BE AN ODD NUMBER")

                number = Int(Console.ReadLine())
                
                If number >= 4 And number <= 30 Then


                    If number Mod 2 = 0 Then

                        Exit Do

                    Else
                        Console.WriteLine("Please enter another number")
                    End If
                Else
                    Console.WriteLine("The number must be greater than 4 and less than 30!")
                End If

            Loop
            '  Dim cardsPlay As Integer = number

            Dim rounds As Integer = 1
            Dim playerPack As New Queue(Of Dictionary(Of String, of ))
            Dim playerPack As New Queue(Of Dictionary(Of String, of))
            Dim computerPack As New Queue(Of String)

            Dim randomEngine As New Random()

            'Do While
            Console.Clear()


                Console.ReadKey()
                Console.WriteLine("Round {0}
", rounds)


                Do
                    Console.ReadLine()

                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.DarkRed

                    Console.WriteLine("PLEASE CHOOSE A CATEGORY OR QUIT")

                    Console.WriteLine("
            1. Exercise 
            2. Intelligence 
            3. Friendly
            4. Drool
            5. Quit")

                    Dim chosenCategory As String = Console.ReadLine()
                    Dim quit As String = "x"

                    'Dim rounds As Integer = 0



                    If chosenCategory = "1" Then
                        message = name & "'s Card:
chosen category: Exercise"


                    ElseIf chosenCategory = "2" Then
                        message = name & "'s Card:
chosen category: Intelligence"
                    ElseIf chosenCategory = "3" Then
                        message = name & "'s Card
chosen category: Freindly"
                    ElseIf chosenCategory = "4" Then
                        message = name & "'s Card
chosen category: Drool"
                    ElseIf chosenCategory = "5" Then
                        Console.Clear()
                        Console.ForegroundColor = ConsoleColor.DarkYellow
                        Console.WriteLine("Thank You for playing Celebrity Dogs")
                        Console.WriteLine("(press any key to exit...)")
                        Console.ReadKey(True) 'You Console.ReadKey() because the user presses any key

                        MsgBox("Are you sure you want to quit?")
                        '(Console.ReadLine() = "x") Then
                        Environment.Exit(0)
                        'ElseIf chosenCategory > "5" Then
                        '    Console.WriteLine("Invalid Input! please choose your category again!")
                    Else


                    End If

                    Console.Clear()
                    ' Console.WriteLine("please enter, 'Enter' 5 times!")
                    Console.ReadKey(True)

                    Console.Clear()

                    Console.WriteLine(message)
                    Dim q As New Queue(Of String)

                    Dim randomEngine As New Random()

                    Randomize()

                    Dim index As Integer = randomEngine.Next(0, data.Count - 1) 'Data.count is the number of items in the data list (dogs)

                    Console.WriteLine(data(index))
                    q.Enqueue(data(index))

                    Randomize()

                    Dim exercise As Integer = randomEngine.Next(1, 5)

                    Randomize()
                    Dim intelligence As Integer = randomEngine.Next(1, 100)

                    Randomize()

                    Dim friendly As Integer = randomEngine.Next(1, 10)

                    Randomize()
                    Dim drool As Integer = randomEngine.Next(1, 10)


                    Select Case chosenCategory
                        Case "1"
                            Console.WriteLine("Exercise: 
" & exercise
                                              )

                        Case "2"
                            Console.WriteLine("Intelligence: " & intelligence
                                              )

                        Case "3"
                            Console.WriteLine("Friendly: " & friendly
                                              )

                        Case "4"
                            Console.WriteLine("Drool: " & drool)

                    End Select

                    Dim currentCard As String = q(data(index))
                    q.Dequeue()

                    q.Enqueue(currentCard)





                    'Dim q As New Queue(Of Integer) = New Queue(Of Integer)()
                    ' q.Enqueue(exercise)

                    ' Console.WriteLine("Please enter 'enter' to see the computers card...")

                    '
                    'computer cards 
                    '


                    Dim winnerLoser As New Dictionary(Of String, Int16)()

                    Console.ReadLine()

                    Console.Write("
Computers Card:
Dog name:")
                    Dim playersCategory As String = " "
                    'Dim number As Integer
                    Dim category As New Dictionary(Of String, Array)
                    Dim categoryChosen As String = Console.ReadLine()
                    ' Dim computerscategory As String = chosenCategory
                    Randomize()
                    Dim d As Queue(Of String) = New Queue(Of String)()
                    Dim randomEngine2 As New Random()


                    Dim index2 As Integer = randomEngine.Next(0, data.Count - 1) 'Data.count is the number of items in the data list (dogs)

                    Console.WriteLine(data(index2))
                    d.Enqueue(data(index2))

                    Randomize()

                    Dim exercise2 As Integer = randomEngine.Next(1, 5)

                    'Console.WriteLine(exercise)

                    Randomize()
                    Dim intelligence2 As Integer = randomEngine.Next(1, 100)
                    'Console.WriteLine(intelligence)

                    Randomize()
                    Dim friendly2 As Integer = randomEngine.Next(1, 10)
                    'Console.WriteLine(friendly)
                    Randomize()

                    Dim drool2 As Integer = randomEngine.Next(1, 10)
                    Dim playerWinner As Integer = 0
                    Dim computerWinner As Integer = 0

                    'Console.Clear()

                    Dim dogName1 As String = q(data(index))
                    Dim dogName2 As String = d(data(index))

                    q.Dequeue()
                    d.Dequeue()

                    'COMPARISION
                    Select Case chosenCategory
                        Case "1"
                            Console.WriteLine(exercise2)
                            Randomize()

                            If exercise = exercise2 Then
                                Console.WriteLine("
No one has won this round")
                                ' Console.ReadKey()


                            ElseIf exercise > exercise2 Then
                                'exercise is greater then the exercise2
                                Console.WriteLine("
You have won this round.")
                                q.Enqueue(dogName2)
                                q.Enqueue(dogName1)
                                'Console.ReadKey()
                                playerWinner += 1
                                'Console.ReadKey()
                                Console.WriteLine("
Number of rounds you have won {0}
                                ", playerWinner)

                            ElseIf exercise < exercise2 Then
                                Console.WriteLine("
Computer has won this round.")
                                q.Enqueue(dogName2)
                                q.Enqueue(dogName1)
                                'Console.ReadKey()
                                computerWinner += 1
                                Console.WriteLine("
Number of rounds Computer has won {0}
                                ", computerWinner)
                                'Console.ReadKey()

                            End If

                        Case "2"
                            Console.WriteLine(intelligence2)
                            Randomize()
                            '                            Console.ReadKey()

                            If intelligence = intelligence2 Then
                                Console.WriteLine("
No one has won this round")
                                '                               Console.ReadKey()
                            ElseIf intelligence > intelligence2 Then
                                'exercise is greater then the exercise2
                                Console.WriteLine("
You have won this round.")
                                q.Enqueue(dogName2)
                                q.Enqueue(dogName1)
                                '                              Console.ReadKey()
                                playerWinner += 1
                                ''                             Console.ReadKey()
                                Console.WriteLine("
Number of rounds you have won {0}
                                ", playerWinner)
                                '                           Console.ReadKey()
                                winnerLoser.Add(name, 1)

                            ElseIf intelligence < intelligence2 Then
                                Console.WriteLine("
Computer has won this round.")
                                q.Enqueue(dogName2)
                                q.Enqueue(dogName1)
                                '                          Console.ReadKey()
                                computerWinner += 1
                                Console.WriteLine("
Number of rounds Computer has won {0}
                                ", computerWinner)
                                '                         Console.ReadKey()
                                winnerLoser.Add(computerWinner, 1)
                            End If

                        Case "3"
                            Console.WriteLine(friendly2)
                            Randomize()

                            If friendly = friendly2 Then
                                Console.WriteLine("
No one has won this round")
                                '                        Console.ReadKey()

                            ElseIf friendly > friendly2 Then
                                'exercise is greater then the exercise2
                                Console.WriteLine("
You have won this round.")
                                q.Enqueue(dogName2)
                                q.Enqueue(dogName1)
                                '                       Console.ReadKey()
                                '                      Console.ReadKey()
                                Console.WriteLine("
Number of rounds you have won {0}
                                ", playerWinner)
                                '                     Console.ReadKey()

                            ElseIf friendly < friendly2 Then
                                Console.WriteLine("
Computer has won this round.")
                                q.Enqueue(dogName2)
                                q.Enqueue(dogName1)
                                '                    Console.ReadKey()
                                computerWinner += 1
                                Console.WriteLine("
Number of rounds Computer has won {0}
                                ", computerWinner)
                                '                   Console.ReadKey()
                            End If


                        Case "4"
                            Console.WriteLine(drool2)
                            Randomize()

                            If drool = drool2 Then
                                Console.WriteLine("
Player wins the round")
                                q.Enqueue(dogName2)
                                q.Enqueue(dogName1)
                                '                  Console.ReadKey()
                                '                 Console.ReadKey()
                                Console.WriteLine("
Number of rounds you have won {0}
                                ", playerWinner)


                                '                Console.ReadKey()
                            ElseIf drool < drool2 Then
                                'exercise is greater then the exercise2
                                Console.WriteLine("
You have won this round.")
                                q.Enqueue(dogName2)
                                q.Enqueue(dogName1)
                                '               Console.ReadKey()

                            ElseIf drool > drool2 Then
                                Console.WriteLine("
Computer has won this round.")
                                q.Enqueue(dogName2)
                                q.Enqueue(dogName1)
                                '              Console.ReadKey()
                                computerWinner += 1
                                Console.WriteLine("Number of rounds Computer has won {0}
                                ", computerWinner)
                                Console.ReadKey()
                            End If


                            If computerWinner > playerWinner Then
                                Console.WriteLine(computerWinner)
                                Console.WriteLine("computer has won")
                                '             Console.ReadKey()
                            ElseIf playerWinner > computerWinner Then
                                Console.WriteLine(playerWinner)
                                Console.WriteLine(name & " has won")
                                '            Console.ReadKey()
                            End If


                            '   For Each student As KeyValuePair(Of String, Int16) In winnerLoser
                            '      Console.WriteLine("Key: {0}, Value: {1}", student.Key, student.Value)
                            ' Next
                            'Console.WriteLine()
                            'Console.WriteLine("Number of key/value pair in Dictionary:")
                            ' Console.WriteLine("Count: {0}", winnerLoser.Count)
                            'Console.ReadLine()


                    End Select

                    ' q.Dequeue()
                    Console.ReadKey() 'this is what i have modified 11/2/2018
                    Exit Do
                    Console.ReadKey()
                Loop

                rounds += 1
            Loop
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.DarkYellow
            Console.WriteLine("End of 'Celebrity Dogs'")
                        Console.ReadKey(True)

                        MsgBox("Thank you for playing")
                       
                        Environment.Exit(0)

            'Loop


            Console.ReadKey()

        Loop
        'Next




    End Sub


End Module









