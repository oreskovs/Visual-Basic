Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False

        ListBox1.BackColor = Color.White


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text = "" Then
            MsgBox("Napisi nesto vo text box")
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
        Else
            ListBox1.Items.Add(TextBox1.Text)
        End If


        If RadioButton1.Checked = True Then
            ListBox1.BackColor = Color.Red
        ElseIf RadioButton2.Checked = True Then
            ListBox1.BackColor = Color.Yellow
        ElseIf RadioButton3.Checked = True Then
            ListBox1.BackColor = Color.Green
        Else
            ListBox1.BackColor = Color.White
        End If
    End Sub
End Class
