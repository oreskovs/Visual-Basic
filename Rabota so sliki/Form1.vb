Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox5.Image = Image.FromFile("C:\Users\Stojance Oreskov\Desktop\mickey.png")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            PictureBox3.Load(OpenFileDialog1.FileName)
        End If
    End Sub
End Class
