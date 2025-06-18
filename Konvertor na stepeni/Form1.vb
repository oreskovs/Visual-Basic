Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked() Then
            TextBox2.Text = Format(TextBox1.Text * 9 / 5 + 32, "###.00")
        End If
        If RadioButton2.Checked() Then
            TextBox1.Text = Format((TextBox2.Text - 32) * 5 / 9, "###.00")
        End If
        If TextBox1.Text > 20 Then
            BackColor = Color.Firebrick
        ElseIf TextBox1.Text <= 20 And TextBox1.Text > 0 Then
            BackColor = Color.MistyRose
        ElseIf TextBox1.Text < 0 And TextBox1.Text > -20 Then
            BackColor = Color.PaleTurquoise
        Else
            BackColor = Color.DeepSkyBlue
        End If
    End Sub

    Private Sub resetiraj()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Enabled = True
        TextBox2.Enabled = False
        resetiraj()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Enabled = False
        TextBox2.Enabled = True
        resetiraj()
    End Sub
End Class
