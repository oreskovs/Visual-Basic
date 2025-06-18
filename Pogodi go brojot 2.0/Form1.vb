Public Class Form1

    Dim broj As Integer
    Dim generator As New Random
    Dim br_obidi As Integer
    Dim vreme As Integer



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        broj = generator.Next(100)
        br_obidi = 0
        Timer1.Start()
        vreme = Timer1.Interval
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        br_obidi = br_obidi + 1
        Label3.Text = "Број на обиди " & br_obidi
        ListBox1.Items.Add(TextBox1.Text)
        If TextBox1.Text = broj Then
            Label4.Text = "Браво погоди!"
            Label4.Font = New Font("Courier Bold", 15)
            Label4.ForeColor = Color.IndianRed
            TextBox1.Enabled = False
            Button1.Enabled = False
            Timer1.Stop()
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
        TextBox1.Enabled = True
        TextBox1.Text = " "
        Label3.Text = " "
        Label4.Text = " "
        ListBox1.Items.Clear()
        Label4.Font = New Font("Courier", 10)
        Label4.ForeColor = Color.Black
        Button1.Enabled = True
        Timer1.Start()
        vreme = Timer1.Interval
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        vreme = vreme - 1
        If vreme = 0 Then
            Timer1.Stop()
            Label4.Text = "Времето истече! Обиди се повторно!"
            Label4.Font = New Font("Courier Bold", 15)
            Label4.ForeColor = Color.IndianRed
            Button1.Enabled = False
            TextBox1.Enabled = False
        Else
            TextBox2.Text = vreme & " сек"
        End If
    End Sub


End Class
