Module Module1
    Sub Main()
        Console.WriteLine("CBool(5 <> 8)=" & CBool(5 <> 8))
        Console.WriteLine("CShort(321.33)=" & CShort(321.33))
        Console.WriteLine("Cint(45.23)=" & CInt(45.23))
        Console.WriteLine("CLng(16234.45)=" & CLng(16234.45))
        Console.WriteLine("CLng(16234.55)=" & CLng(16234.55))
        Console.WriteLine("CSng(84.3456331)=" & CSng(84.3456331))
        Console.WriteLine("CSng(84.3456387)=" & CSng(84.3456387))
        Console.WriteLine("CDbl(321.34459D)=" & CDbl(321.34459D))
        Console.WriteLine("CByte(117.89)=" & CByte(117.89))
        Console.WriteLine("CChar(""Happy"")=" & CChar("Happy"))
        Console.WriteLine("CStr(243.433)=" & CStr(243.433))
        Console.WriteLine("CStr(#12/19/2013#)=" & CStr(#12/19/2013#))
        Console.WriteLine("CDec(323244.9032)=" & CDec(323244.9032))
        Console.WriteLine("CDate(""2013/12/19"")=" & CDate("2013/12/19"))
        Console.WriteLine("CDate(""2:45:23 AM"")=" & CDate("2:45:23 AM"))
        Console.WriteLine()
        Console.Read() '暫停
    End Sub
End Module
