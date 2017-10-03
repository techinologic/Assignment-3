Public Class Form1

    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click

        Dim n As Integer = txtInput.Text
        Dim print As String = ""

        For i = 1 To n
            For j = 1 To n - i
                print = print & "#"
            Next
            print = print & "&" & ControlChars.CrLf

            For j = 1 To (i - 1) * 2
                print = print & "%"
            Next
            print = print & "*" & ControlChars.CrLf
            lstResult.Items.Add(print)
            print = ""
        Next

    End Sub
End Class
