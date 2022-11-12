Public Class Form7
    Sub generate()
        Dim rgbs As New Random
        Dim intef = rgbs.Next(995935756)
        Dim strr As System.IO.StreamWriter
        strr = New IO.StreamWriter("enc.crypt")
        strr.Write(intef.ToString)
        strr.Close()
        Label4.Text = intef
    End Sub
    Sub nama()
        Dim nmad As String = TextBox1.Text
        Dim passd As String = TextBox2.Text
        Dim strr As IO.StreamWriter
        Dim passte As IO.StreamWriter
        strr = New IO.StreamWriter("UserData.dat")
        strr.Write(nmad)
        strr.Close()
        passte = New IO.StreamWriter("encrop.datae")
        passte.Write(passd)
        passte.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            generate()
        Catch ex As Exception
            MsgBox("Bug, lihat www.blue-acid.blogspot.com ,")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim stre As IO.StreamWriter
        Try
            stre = New IO.StreamWriter("Creps.dats")
            stre.Write("")
            stre.Close()
            Form1.RichTextBox1.Text = ""
            nama()
            Timer2.Enabled = True
        Catch ex As Exception
            MsgBox("Bug, lihat www.blue-acid.blogspot.com ,")
        End Try


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer2.Enabled = False
        Form6.Show()
        Me.Close()

    End Sub
End Class