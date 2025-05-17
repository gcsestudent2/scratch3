Option Explicit

Imports System

Module Program
    Sub Main(args As String())
        Dim arr As Integer() = {3,4,6,7,11,14,17,18,34,42}
        Console.Write("What number would you like to find ?")
        Dim value As Integer = Convert.ToInt32(Console.ReadLine)
        Dim found As Boolean = False
        Dim finished As Boolean = False
        Dim i As Integer = 0
        Dim down As Integer = False
        While (found = False) And (finished = False)
            Stop
            If arr(i) = value Then 
                found = True
            Else
                If arr(i) > value Then
                    down = True
                    i = i - 1
                Else
                    If (arr(i) < value) and (down = True) Then
                        finished = True
                    Else
                        i = i + 4
                    End If
                End If
            End If
        
        End While
        
        Console.WriteLine(found) 
 
    End Sub
End Module
