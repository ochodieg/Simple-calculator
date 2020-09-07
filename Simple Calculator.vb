'Ivan Ochoa
'RCET0265
'Fall 2020
'Simple Calculator
'https://github.com/LuisTorres0419/SimpleCalculator.git

Option Strict On
Option Explicit On
Option Compare Text


Module Module1

    Sub Main()
        Dim betterData As Boolean
        Dim userInput1, userInput2, userRespons As String
        Dim firstNumber, seconNumber As Integer

        Do
            Console.WriteLine("press q to Quit")

            Do

                Try

                    Console.WriteLine("Please enter a number")

                    userInput1 = Console.ReadLine()

                    firstNumber = CInt(userInput1)

                    Console.WriteLine("enter a second number")

                    userInput2 = Console.ReadLine()

                    seconNumber = CInt(userInput2)

                    betterData = True

                Catch ex As Exception

                    Console.WriteLine("thats a big stinky no no, my friend")

                    betterData = False


                    If userInput1 = "q" Or userInput2 = "q" Then

                        Exit Sub

                    End If

                End Try

            Loop Until betterData = True

            Console.Clear()

            Do

                Console.WriteLine("are we adding, or multiplying? ")

                userRespons = Console.ReadLine()

                If userRespons = "Add" Or userRespons = "+" Then

                    Console.WriteLine("You entered: " & firstNumber & " + " & seconNumber & " that = " &
                                      firstNumber + seconNumber)

                ElseIf userInput1 = "q" Or userInput2 = "q" Then

                    Exit Sub

                ElseIf userRespons = "multiply" Or userRespons = "*" Then

                    Console.WriteLine("You entered: " & firstNumber & " * " & seconNumber & " that = " &
                                      firstNumber * seconNumber)

                ElseIf userRespons <> "multiply" Or userRespons <> "*" Or userRespons <> "Add" Or userRespons <>
                    "+" Then

                    Console.WriteLine("no can do")

                End If

            Loop Until userRespons = "multiply" Or userRespons = "*" Or userRespons = "Add" Or userRespons = "+"

            Console.ReadLine()

            Console.Clear()
        Loop

    End Sub

End Module
