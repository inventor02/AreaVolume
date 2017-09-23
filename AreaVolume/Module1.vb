Module Module1
    Sub Main()
        Dim theOption As String
        
        Console.WriteLine("Area and Volume Calculator")
        Console.WriteLine("--------------------------")
        Console.WriteLine("1) Area")
        Console.WriteLine("2) Volume")
        Console.Write("Select option:")
        theOption = Console.ReadLine()
        
        Console.WriteLine()
        
        If theOption = "1"
            Area()
        Else If theOption = "2"
            Volume()
        Else 
            Console.WriteLine("You done goofed. Invalid option.")
        End If
        
        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")
        
        Console.ReadLine()
    End Sub
    
    Sub Area()
        Dim height As String
        Dim width As String
        
        Dim heightAsSingle As Single
        Dim widthAsSingle As Single
        
        Console.Write("Enter height: ")
        height = Console.ReadLine()
        
        Console.Write("Enter width: ")
        width = Console.ReadLine()
        
        Try
            heightAsSingle = Convert.ToSingle(height)
            widthAsSingle = Convert.ToSingle(width)
        Catch ex As Exception
            Console.WriteLine()
            Console.WriteLine("Invalid input.")
            Return
        End Try
        
        Console.WriteLine()
        Console.WriteLine("Area: " & heightAsSingle * widthAsSingle)
    End Sub
    
    Sub Volume()
        Dim height As String
        Dim width As String
        Dim depth As String
        
        Dim heightAsSingle As Single
        Dim widthAsSingle As Single
        Dim depthAsSingle As Single
        
        Console.Write("Enter height: ")
        height = Console.ReadLine()
        
        Console.Write("Enter width: ")
        width = Console.ReadLine()
        
        Console.Write("Enter depth: ")
        depth = Console.ReadLine()
        
        Try
            heightAsSingle = Convert.ToSingle(height)
            widthAsSingle = Convert.ToSingle(width)
            depthAsSingle = Convert.ToSingle(depth)
        Catch ex As Exception
            Console.WriteLine()
            Console.WriteLine("Invalid input.")
            Return
        End Try
        
        Console.WriteLine()
        Console.WriteLine("Volume: " & heightAsSingle * widthAsSingle * depthAsSingle)
    End Sub
End Module
