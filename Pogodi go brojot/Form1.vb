Public Class Form1

    Dim generator As New Random
    Dim broj As Integer
    Dim br_obidi As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        broj = generator.Next(100)
        br_obidi = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        br_obidi = br_obidi + 1
        Label3.Text = "Број на обиди " & br_obidi
        If TextBox1.Text = broj Then
            Label4.ForeColor = Color.IndianRed
            Label4.Text = "Браво погоди!"
            Label4.Font = New Font("Courier Bold", 14)
            Button1.Enabled = False
            TextBox1.Enabled = False
        ElseIf TextBox1.Text > broj Then
            Label4.Text = "Замислениот број е помал"
        Else
            Label4.Text = "Замислениот број е поголем"
        End If
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        broj = generator.Next(100)
        br_obidi = 0
        Label4.ForeColor = Color.Black
        Label4.Font = New Font("Courier", 9)
        Button1.Enabled = True
        TextBox1.Enabled = True
        Label3.Text = ""
        Label4.Text = ""
        TextBox1.Text = ""
    End Sub
End Class
