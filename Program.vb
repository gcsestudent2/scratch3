Option Explicit

Imports System

Module Program
    Sub Main(args As String())
        ' ============ Top of editable area (don't change anything above this line)
      dim arr as integer() = {4,1,6}
      dim swapsMade as boolean
      dim i as integer
      dim t as integer
      Stop
      swapsMade = false
      WHILE swapsMade = false
        swapsMade = true
        i = 0
        WHILE i < 2
          if arr(i+1) < arr(i) THEN
            t = arr(i)
            console.writeline("arr=(" & arr(0) & "," & arr(1) & "," & arr(2) &  "), swapsMade=" & swapsMade & ", i=" & i & ", t=" & t)
            arr(i) = arr(i+1)
            arr(i+1) = t
            swapsMade = false
          ELSE
            console.writeline("arr=(" & arr(0) & "," & arr(1) & "," & arr(2) &  "), swapsMade=" & swapsMade & ", i=" & i & ", t=" & t)
          END IF
          i = i+1
        END WHILE
      END WHILE
        ' ============ Bottom of editable area (don't change anything below this line)
    End Sub
End Module 