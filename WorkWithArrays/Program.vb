Imports System
Imports System.Runtime.InteropServices.JavaScript.JSType

Module Program
    Sub Main(args As String())
        Dim nElems As Long = 0
        Console.Clear()
        Console.WriteLine("Input a count of elements in array")
        Int64.TryParse(Console.ReadLine(), nElems)
        Dim iArray(nElems)
        For i = 0 To nElems - 1
            Console.WriteLine("Input an element N {0}", i + 1)
            Int32.TryParse(Console.ReadLine(), iArray(i))
        Next
        Console.WriteLine("Inputed array:")
        For i = 0 To nElems - 1
            Console.Write(iArray(i).ToString() + " ")
        Next
        Console.Read()
    End Sub
End Module
