Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "qwerty") Then
            Me.Close()
        Else
            MessageBox.Show("Invalid Password $")
        End If
    End Sub
End Class
