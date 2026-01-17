Option Explicit

Imports System

Module Program
    Sub Main(args As String())
        ' ============ Top of editable area (don't change anything above this line)
        'Stop
        console.writeline ("enter email")
        dim emailadress as string
        emailadress = console.readline()
        console.writeline ("enter the same email again")
        dim emailadress2 as string 
        emailadress2= console.readline()
        if emailadress = emailadress2 then
            console.writeline("match")
        else 
            console.writeline ("do not match")
        end if     
        ' ============ Bottom of editable area (don't change anything below this line)
    End Sub
End Module
