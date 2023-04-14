Module ConsoleGraph

    Sub Main()
        'Define an array of values to graph
        Dim values() As Integer = {3, 7, 2, 5, 4, 6, 9, 1, 8, 2, 5, 3, 7, 6, 4, 15, 11, 2, 17, 10}

        'Call the DrawGraph function with the values array
        DrawGraph(values)

        'Wait for user input before exiting
        Console.ReadLine()
    End Sub

    Sub DrawGraph(ByVal values() As Integer)
        'Set the max items count in values - 37 because of the default length of the console
        If (values.Length > 37) Then Console.WriteLine("Max. 37 values!") : Exit Sub

        'Determine the maximum value in the array
        Dim maxValue As Integer = values.Max()

        'Define console colors for the graph
        Dim backgroundColor As ConsoleColor = ConsoleColor.White
        Dim foregroundColor As ConsoleColor = ConsoleColor.Black
        Dim barColor As ConsoleColor = ConsoleColor.DarkGreen '.Red

        'Set console colors to the defined values
        Console.BackgroundColor = backgroundColor
        Console.ForegroundColor = foregroundColor

        'Loop through each possible value from the maximum value to 1
        For i As Integer = maxValue + 2 To 1 Step -1
            'Write the current value on the y-axis with a padding of 2
            Console.Write($"{i,2}|  ")

            'Loop through each value in the array
            For Each value As Integer In values
                'Reset the background color to the default value
                Console.BackgroundColor = backgroundColor

                'If the value is greater than or equal to the current y-axis value, set the background color to the bar color
                If value >= i Then
                    Console.BackgroundColor = barColor
                    Console.Write("   ")
                Else
                    Console.Write("   ")
                End If

                'Reset the background color to the default value
                Console.BackgroundColor = backgroundColor
            Next

            'Move to the next line
            Console.WriteLine("  ")
        Next

        'Draw the x-axis
        Console.WriteLine("  +" & New String("-"c, values.Length * 3) & "--  ")

        'Write the x-axis values with a padding of 2
        Console.Write("    ")
        For i As Integer = 1 To values.Length
            Console.Write($" {i,2}")
        Next

        'Move to the next line
        Console.WriteLine("   ")

        'Reset the console colors to their default values
        '#Console.BackgroundColor = backgroundColor
        Console.ForegroundColor = foregroundColor
    End Sub

End Module
