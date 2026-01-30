Option Explicit

Imports System

Module Program
    Sub Main(args As String())
        ' ============ Top of editable area (don't change anything above this line)

        ' Write a VB.Net program that allows an private airline charter company to 
        ' calculate how much a group booking should cost. The program should:
        ' • allow the user to enter one destination from 
        '   the following three options : paris, new york, berlin
        ' • allow the user to enter the number of passengers 
        ' • calculate the cost for the group booking by
        '   o charging £150 for every passenger regardless 
        '     of the destination
        '   o adding a surcharge depending on the destination 
        '     regardless of how many passengers there are 
        '     (£500 for paris, £750 for berlin, £2000 for 
        '     new york)
        ' • output the final cost

        'Stop
      '  console.writeline ("enter choice for destination (1 for paris, 2 for new york, 3 for berlin) :")
       ' dim destination_code as string
        'destination_code = console.readline()

     dim user as string 
     dim destination as string
        dim passengers as integer  
        dim cost as integer 
        Stop
          console.writeline (" user enter destination")
          console.writeline (" 0 = paris,1 = new york,2 = berlin")
         destination=console.readline ()
          console.writeline (" number of passengers") 
          passengers=console.readline ()
          if destination = "0" then 'paris 
            cost = 150
          elseif destination = "1" then 'new york
           cost = 2000
          elseif destination = "2" then 'berlin 
           cost = 750 
          else 
          console.writeline ("bad answer")
          end if  

        '  console.writeline ("150 for every passenger")  
        'if user enters "paris" THEN
          'totalcost 
         ' passenger cost = passengers x150 
        'elseif user inputs "berlin" THEN
        ' totalcost = passengers x750
     'else if user inputs "new york" THEN 
      '   totalcost = passengers x 2000
     'console.writeline = passenger cost + destination charge 
     'end if 

        ' ============ Bottom of editable area (don't change anything below this line)
    End Sub
End Module 