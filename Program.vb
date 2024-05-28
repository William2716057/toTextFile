Imports System.IO
Imports System.Runtime.CompilerServices

Module WriteToFile
	Sub Main()
		'Promt to enter text
		Console.Write("Enter text to store in file: ")
		Dim userInput As String = Console.ReadLine()
		' Full path
		Dim filePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "output.txt")

		' Write input to file
		Try
			File.AppendAllText(filePath, userInput & Environment.NewLine)
			Console.WriteLine("Saved successfully")
		Catch ex As Exception
			Console.WriteLine("Error writing to file: " & ex.Message)
		End Try
		' Wait for keypress before closing
		Console.ReadKey()

	End Sub
End Module
