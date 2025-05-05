Imports System

Module Program
    Sub Main(args As String())
       For index As Integer = 1 To 100
           Threading.Thread.Sleep(1000)
           Stop
           Console.WriteLine("Hello World!")
       Next index
    End Sub
End Module
