Public Class Form2
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim g As Integer = Form3.TextBox1.Text
        Dim f As Integer = Form3.TextBox2.Text
        Form3.Show()
        Form3.Label4.Text = TextBox1.Text
        list.Add("What is the longest chord in the circle?")
        ans1.Add("Diameter")
        ans2.Add("Radius")
        ans3.Add("Circumference")
        list.Add("What is the area of a triangle?")
        ans1.Add("Base x height x 1/2")
        ans2.Add("Base x height")
        ans3.Add("(Base1+ Base2)/2")
        list.Add("Area of a circle with a radius of 8")
        ans1.Add("64 Pi")
        ans2.Add("16 cm2")
        ans3.Add("4 Pi")
        list.Add("Equation for the volume of a sphere")
        ans1.Add("4/3(pi)(r)(r)(r)")
        ans2.Add("4(pi)(r)(r)")
        ans3.Add("2/3(Base x Height)")
        list.Add("ASN. The diagonals of a kite bisect each other")
        ans1.Add("A")
        ans2.Add("S")
        ans3.Add("N")
        list.Add("ASN. Alternate interior angles are equal")
        ans1.Add("A")
        ans2.Add("S")
        ans3.Add("N")
        list.Add("ASN. A square is a rhombus")
        ans1.Add("A")
        ans2.Add("S")
        ans3.Add("N")
        list.Add("ASN. Right triangles are proportional")
        ans1.Add("A")
        ans2.Add("S")
        ans3.Add("N")
        list.Add("ASN. A radius is equal to a chord of a circle")
        ans1.Add("A")
        ans2.Add("S")
        ans3.Add("N")
        list.Add("Square root of 4")
        ans1.Add("2")
        ans2.Add("8")
        ans3.Add("16")
        list.Add("Square root of 4,761")
        ans1.Add("69")
        ans2.Add("144")
        ans3.Add("169")
        Form3.Label3.Text = list(f)
        If Form3.Label3.Text = list(f) Then
            Form3.RadioButton1.Text = ans1(f)
            Form3.RadioButton2.Text = ans2(f)
            Form3.RadioButton3.Text = ans3(f)
        End If
        Me.Close()
    End Sub
End Class