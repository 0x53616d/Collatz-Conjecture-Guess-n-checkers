Public Class Form1
    Shared Mathing As Boolean
    Shared numbertodo As Int64
    Shared numbertodoorig As Int64
    Shared highestnum As Int64
    Shared mathcount As Int64
    Public Async Sub DoMathBadly()
        'Convert string of number to integer
        numbertodo = NumberToStartAt.Text
        numbertodoorig = numbertodo
        'Overwrite last highest number
        highestnum = numbertodo
        Do While Mathing = True
            'Check for new highest number
            If numbertodo > highestnum Then
                highestnum = numbertodo
            End If

            'Do collatz math
            If IsOdd(numbertodo) Then
                numbertodo = ((numbertodo * 3) + 1)
                mathcount = mathcount + 1
            ElseIf IsOdd(numbertodo) = False Then
                numbertodo = numbertodo / 2
                mathcount = mathcount + 1
            End If

            'Log work
            If CheckBox1.Checked = True Then
                My.Computer.FileSystem.WriteAllText("E:\Dextop\stupid\Collatz Conjecture Rough Log.txt", numbertodo.ToString + Environment.NewLine, True)
            End If
            'Stop at loop numbers
            If numbertodo = 1 Then
                'Log
                If CollatzLog.Text = "" Then
                    CollatzLog.AppendText(numbertodoorig.ToString + ": " + mathcount.ToString + ", " + highestnum.ToString)
                Else
                    CollatzLog.AppendText(Environment.NewLine + numbertodoorig.ToString + ": " + mathcount.ToString + ", " + highestnum.ToString)
                    CollatzLog.SelectionStart = CollatzLog.Text.Length
                    CollatzLog.ScrollToCaret()
                End If
                My.Computer.FileSystem.WriteAllText("E:\Dextop\stupid\Collatz Conjecture Log.txt", numbertodoorig.ToString + ": " + mathcount.ToString + ", " + highestnum.ToString + Environment.NewLine, True)
                'Restart with new number
                NumberToStartAt.Text = numbertodoorig + 1
                Await Task.Delay(5)
                'Convert string of number to integer
                numbertodo = NumberToStartAt.Text
                numbertodoorig = numbertodo
                'Overwrite last highest number
                highestnum = numbertodo
                'Math operation count resetter
                mathcount = 0
            End If
        Loop
    End Sub

    Function IsOdd(number As Integer) As Boolean
        Dim tNum As Integer
        tNum = number
        Dim tNumDiv2 = tNum / 2
        If tNumDiv2.ToString.Contains(".") Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Mathing = True
        If My.Computer.FileSystem.FileExists("E:\Dextop\stupid\Collatz Conjecture Log.txt") And My.Computer.FileSystem.FileExists("E:\Dextop\stupid\Collatz Conjecture Rough Log.txt") Then
            My.Computer.FileSystem.DeleteFile("E:\Dextop\stupid\Collatz Conjecture Log.txt")
            If CheckBox1.Checked = True Then
                My.Computer.FileSystem.DeleteFile("E:\Dextop\stupid\Collatz Conjecture Rough Log.txt")
            End If
        End If
        DoMathBadly()
    End Sub
    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        Mathing = False
    End Sub

End Class