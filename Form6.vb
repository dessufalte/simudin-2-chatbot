Public Class Form6
    Sub bacsd()
        Try
            Dim strw As IO.StreamReader
            strw = New IO.StreamReader("UserData.dat")
            TextBox1.Text = strw.ReadToEnd
            Dim strr As IO.StreamReader
            strr = New IO.StreamReader("enc.crypt")
            Label4.Text = strr.ReadToEnd
        Catch ex As Exception
            MsgBox("Silahkan Sign Up Terlebih Dahulu", MsgBoxStyle.Information)
            Form7.ShowDialog()
        End Try
    End Sub
    Sub savedd()
        Dim nmad As String = TextBox1.Text
        Dim strr As System.IO.StreamWriter
        strr = New IO.StreamWriter("UserData.dat")
        strr.Write(nmad)
        strr.Close()
        bacsd()
    End Sub
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bacsd()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form7.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        savedd()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strw As IO.StreamReader
        Dim strrs As String
        Dim pasbar As String
        strw = New IO.StreamReader("encrop.datae")
        strrs = strw.ReadToEnd
        If InputBox("Masukan Password yang lama: ", "Password Edit") = strrs Then
            pasbar = InputBox("Masukan Password Baru: ", "Password Edit")
            Dim strr As System.IO.StreamWriter
            strr = New IO.StreamWriter("encrop.datae")
            strr.Write(pasbar)
            strr.Close()
        Else
            MsgBox("Password Anda Salah", MsgBoxStyle.Exclamation, "Password Salah")
        End If
    End Sub
End Class