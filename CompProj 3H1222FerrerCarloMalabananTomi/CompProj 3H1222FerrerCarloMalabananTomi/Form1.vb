Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to exit?", "Exit game", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.OK Then
            Me.Close()
        ElseIf result = Windows.Forms.DialogResult.Cancel Then

        End If
    End Sub
End Class
