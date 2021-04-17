Public Class Form3

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim g As Integer = TextBox1.Text
        If f = 1 Then
            If RadioButton1.Checked = True Then
                TextBox1.Text = TextBox1.Text - 1
                TextBox2.Text = TextBox2.Text + 1
            End If
        End If
        If f = 2 Then
            If RadioButton1.Checked = True Then
                TextBox1.Text = TextBox1.Text - 1
                TextBox2.Text = TextBox2.Text + 1
            End If
        End If
        If f = 3 Then
            If RadioButton1.Checked = True Then
                TextBox1.Text = TextBox1.Text - 1
                TextBox2.Text = TextBox2.Text + 1
            End If
        End If
        If f = 4 Then
            If RadioButton1.Checked = True Then
                TextBox1.Text = TextBox1.Text - 1
                TextBox2.Text = TextBox2.Text + 1
            End If
        End If
        If f = 5 Then
            If RadioButton3.Checked = True Then
                TextBox1.Text = TextBox1.Text - 1
                TextBox2.Text = TextBox2.Text + 1
            End If
        End If
        If f = 6 Then
            If RadioButton2.Checked = True Then
                TextBox1.Text = TextBox1.Text - 1
                TextBox2.Text = TextBox2.Text + 1
            End If
        End If
        If f = 7 Then
            If RadioButton1.Checked = True Then
                TextBox1.Text = TextBox1.Text - 1
                TextBox2.Text = TextBox2.Text + 1
            End If
        End If
        If f = 8 Then
            If RadioButton1.Checked = True Then
                TextBox1.Text = TextBox1.Text - 1
                TextBox2.Text = TextBox2.Text + 1
            End If
        End If
        If f = 9 Then
            If RadioButton2.Checked = True Then
                TextBox1.Text = TextBox1.Text - 1
                TextBox2.Text = TextBox2.Text + 1
            End If
        End If
        If f = 10 Then
            If RadioButton2.Checked = True Then
                TextBox1.Text = TextBox1.Text - 1
                TextBox2.Text = TextBox2.Text + 1
            End If
        End If








        Dim i As Integer = rand.Next(0, 2)
        comp.Add("Computer's answer is correct!")
        comp.Add("Computer's answer is wrong!")
        MessageBox.Show(comp(i))
        If i = 0 Then
            TextBox1.Text = TextBox1.Text + 1
            TextBox2.Text = TextBox2.Text - 1
        Else
            TextBox1.Text = TextBox1.Text
            TextBox2.Text = TextBox2.Text
        End If
        Do
            Dim h As Integer = rand.Next(11)
            Label3.Text = list(h)
            If Label3.Text = list(h) Then
                RadioButton1.Text = ans1(h)
            End If
        Loop Until g = 0
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub
End Class