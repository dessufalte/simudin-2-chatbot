Public Class Form1
    Dim pes As String
    Dim jaw As String
    Sub blackp()
        Panel1.BackColor = Color.Black
        Panel2.BackColor = Color.Black
        RichTextBox2.BackColor = Color.Black
        RichTextBox2.ForeColor = Color.Pink
        RichTextBox1.BackColor = Color.Pink
        RichTextBox1.ForeColor = Color.Black
        RichTextBox2.Font = New Font("Showcard Gothic", 12)
        RichTextBox1.Font = New Font("Showcard Gothic", 12)
        Label1.Font = New Font("Showcard Gothic", 12)
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Pink
        TextBox1.Font = New Font("Showcard Gothic", 12)
        TextBox1.BackColor = Color.Black
        TextBox1.ForeColor = Color.Pink
        Label1.Text = "BP FANS"
    End Sub
    Sub deaevmod()
        Panel1.BackColor = Color.DarkSeaGreen
        Panel2.BackColor = Color.DarkSeaGreen
        RichTextBox2.BackColor = Color.White
        RichTextBox2.ForeColor = Color.Black
        RichTextBox1.BackColor = Color.Cornsilk
        RichTextBox1.ForeColor = Color.Black
        RichTextBox2.Font = New Font("Comic Sans MS", 12)
        RichTextBox1.Font = New Font("Comic Sans MS", 12)
        Label1.Font = New Font("Comic Sans MS", 12)
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Black
        TextBox1.Font = New Font("Comic Sans MS", 12)
        TextBox1.BackColor = Color.DarkSeaGreen
        TextBox1.ForeColor = Color.Black
        Label1.Text = "Simudin"
    End Sub
    Sub devmod()
        On Error GoTo errh
        Panel1.BackColor = Color.White
        Panel2.BackColor = Color.White
        RichTextBox2.BackColor = Color.Black
        RichTextBox2.ForeColor = Color.White
        RichTextBox1.BackColor = Color.Black
        RichTextBox1.ForeColor = Color.White
        RichTextBox2.Font = New Font("Courier New", 10, FontStyle.Regular)
        RichTextBox1.Font = New Font("Courier New", 10, FontStyle.Regular)
        Label1.Font = New Font("Courier New", 10, FontStyle.Regular)
        Label1.BackColor = Color.Black
        Label1.ForeColor = Color.White
        TextBox1.Font = New Font("Courier New", 10, FontStyle.Regular)
        TextBox1.BackColor = Color.Black
        TextBox1.ForeColor = Color.White
        Label1.Text = "sDInDeV"
        AxScriptControl1.AddCode(RichTextBox2.Text)
        Exit Sub
errh:
        RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + Err.Description
    End Sub
    Sub hitung()
        Dim jawb As Integer
        On Error GoTo errorhandler
        jawb = AxScriptControl1.Eval(RichTextBox2.Text)
        RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Jawabanya " + jawb.ToString
        RichTextBox2.Text = ""
        Exit Sub
errorhandler:
        RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "sulit"
        RichTextBox2.Text = ""
    End Sub
    Sub percakapan()
        Dim rands As New Random
        Dim rasd As New Random
        Dim integ As Integer
        Dim salaha As String = "Gue cuma bisa baca huruf kecil"
        Dim salahb As String = "Nanya yang jelaslah"
        Dim salahc As String = "gue nggak paham, coba tanyakan sama mbah www.google.com"
        StrConv(RichTextBox2.Text, VbStrConv.Lowercase)
        If InStr(RichTextBox2.Text, "namamu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Nama gua " + Label1.Text
        ElseIf InStr(RichTextBox2.Text, "nama mu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + Label1.Text + " doang"
        ElseIf InStr(RichTextBox2.Text, "nama kau") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "nama beta " + Label1.Text
        ElseIf InStr(RichTextBox2.Text, "namo") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Nama wak " + Label1.Text
        ElseIf InStr(RichTextBox2.Text, "namo ang") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Nama den " + Label1.Text
        ElseIf InStr(RichTextBox2.Text, "nama kamu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Nama aku " + Label1.Text
        ElseIf InStr(RichTextBox2.Text, "namaku") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "gua dah tau nama lo " + TextBox1.Text
        ElseIf InStr(RichTextBox2.Text, "nama aku") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "sudahlah gua udah tau kok, nama lo pasti " + TextBox1.Text
        ElseIf InStr(RichTextBox2.Text, "namo rang") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "arang tau lo nyo"
        ElseIf InStr(RichTextBox2.Text, "namo den") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "aden lah tau namo ang"
        ElseIf InStr(RichTextBox2.Text, "tinggalmu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "di batusangkar, dekat rumah gadang di situ"
        ElseIf InStr(RichTextBox2.Text, "tinggal kamu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "di solok"
        ElseIf InStr(RichTextBox2.Text, "tingga") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "di siko lah"
        ElseIf InStr(RichTextBox2.Text, "ang tingga") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "di cik talingo"
        ElseIf InStr(RichTextBox2.Text, "kamu tinggal") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "di komputer"
        ElseIf InStr(RichTextBox2.Text, "kau tinggal") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "dekat smp 1 padang"
        ElseIf InStr(RichTextBox2.Text, "kamu sekolah") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "di smp 1 padang"
        ElseIf InStr(RichTextBox2.Text, "sekolahmu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "di smansapapa"
        ElseIf InStr(RichTextBox2.Text, "ang sekolah") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "di ujuang bukik"
        ElseIf InStr(RichTextBox2.Text, "sekolah ang") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "di pasaman, tu baa"
        ElseIf InStr(RichTextBox2.Text, "sekolah kamu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "di tempat kamu bersekolah"
        ElseIf InStr(RichTextBox2.Text, "sekolah kau") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "di dalam sumua"
        ElseIf InStr(RichTextBox2.Text, "sekolah") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Nanyanya yang jelas lah"
        ElseIf InStr(RichTextBox2.Text, "kelas kamu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "kelas 11 MIPA 8"
        ElseIf InStr(RichTextBox2.Text, "kelas berap") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "saya kelas ramo-ramo"
        ElseIf InStr(RichTextBox2.Text, "kelas bara") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "kelas tk"
        ElseIf InStr(RichTextBox2.Text, "kampungmu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Tanah pak lambiak"
        ElseIf InStr(RichTextBox2.Text, "kampung kamu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "di desa"
        ElseIf InStr(RichTextBox2.Text, "kampuang") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "di kota tangah hutan"
        ElseIf InStr(RichTextBox2.Text, "hitunglah") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "gunakan rangkaian operasi mtk dan tekan F5"
        ElseIf InStr(RichTextBox2.Text, "devmodact") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Devmode active"
            devmod()
        ElseIf InStr(RichTextBox2.Text, "devmoddea") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Devmode deactive(Use F7)"
            deaevmod()
        ElseIf InStr(RichTextBox2.Text, "blackpinkers") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "DU DDU DU DUD"
            blackp()
        ElseIf InStr(RichTextBox2.Text, "abadi") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "hanya Allah yang abadi"
        ElseIf InStr(RichTextBox2.Text, "abang") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "yo diak"
        ElseIf InStr(RichTextBox2.Text, "abad") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "abad 21,5"
        ElseIf InStr(RichTextBox2.Text, "habis") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "tambah lagi"
        ElseIf InStr(RichTextBox2.Text, "abnormal") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "tidak ada manusia yang sempurna"
        ElseIf InStr(RichTextBox2.Text, "absen") Then
            PictureBox1.Left = -171
            PictureBox1.Visible = True
            Timer1.Enabled = True
        ElseIf InStr(RichTextBox2.Text, "pa cabut mendekor") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "mmmmm karena mau menjemput buku fisika..."
        ElseIf InStr(RichTextBox2.Text, "kampungan") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Gue orang kota gaptek"
        ElseIf InStr(RichTextBox2.Text, "astagfirullah") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "manga ?"
        ElseIf InStr(RichTextBox2.Text, "assalamualaikum") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "waalaikumsalam"
        ElseIf InStr(RichTextBox2.Text, "jahat") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "astagfirullah"
        ElseIf InStr(RichTextBox2.Text, "pak ustad") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "sia.."
        ElseIf InStr(RichTextBox2.Text, "suka dia") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "cieee..."

            PictureBox1.Left = -171
            PictureBox1.Visible = True
            Timer1.Enabled = True
        ElseIf InStr(RichTextBox2.Text, "abang") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "abang kini ditanah abang"
        ElseIf InStr(RichTextBox2.Text, "barbar") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "barbar, jan ngegas"
            ahsiap()

        ElseIf InStr(RichTextBox2.Text, "cuk mabar") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "siip mabar"
            absed()
        ElseIf InStr(RichTextBox2.Text, "ahsia") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "ahsiap santai"
            absed()
            For jum = 1 To 10
                Timer1.Enabled = True
                If Timer1.Enabled = True Then
                    jum += 1
                End If
            Next
        ElseIf InStr(RichTextBox2.Text, "kampuang") And InStr(RichTextBox2.Text, "mato") Then
            If InStr(RichTextBox2.Text, "mato") Then
                RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "kampuang nan jauh dimato"
            Else
                percakapan()
            End If

            ElseIf InStr(RichTextBox2.Text, "kampuang") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + ""
        ElseIf InStr(RichTextBox2.Text, "bfg") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "ggg"
        ElseIf InStr(RichTextBox2.Text, "#developer") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Wah, lihat ini , www.blue-acid.blogspot.com, bukan spam"
        ElseIf InStr(RichTextBox2.Text, "halo") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "hai"
        ElseIf InStr(RichTextBox2.Text, "hai") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "halo"
        ElseIf InStr(RichTextBox2.Text, "hello") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "hei"
        ElseIf InStr(RichTextBox2.Text, "hei") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "hello"
        ElseIf InStr(RichTextBox2.Text, "anji") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "koq ngegas"
        ElseIf InStr(RichTextBox2.Text, "cuma bi") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "terserah lo"
        ElseIf InStr(RichTextBox2.Text, "kece") Then
        ElseIf InStr(RichTextBox2.Text, "bul") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "lo yang bule"
            Dim df As DataFormats.Format
            df = DataFormats.GetFormat(DataFormats.Bitmap)
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "cuman gue yang kece" + vbCrLf
            inspot()
            If Me.RichTextBox1.CanPaste(df) Then
                Me.RichTextBox1.Paste(df)
            End If
        ElseIf InStr(RichTextBox2.Text, "save") Then
            Dim strr As System.IO.StreamWriter
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "disave"
            Try

                strr = New IO.StreamWriter("crcp.datae")
                strr.Write(RichTextBox1.Text)
                strr.Close()
            Catch ex As Exception
                RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "gagal menyimpan //solusi"
            End Try
        ElseIf InStr(RichTextBox2.Text, "open") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "membuka"

            Try
                   Dim strw As IO.StreamReader
                strw = New IO.StreamReader("enc.crypt")
                TextBox2.Text = strw.ReadToEnd
                If RichTextBox2.Text = "open" + TextBox2.Text Then
                    Dim sdd As IO.StreamReader
                    sdd = New IO.StreamReader("crcp.datae")
                    RichTextBox1.Text = sdd.ReadToEnd
                ElseIf TextBox2.Text = "" Then
                    Dim sdd As IO.StreamReader
                    sdd = New IO.StreamReader("crcp.datae")
                    RichTextBox1.Text = sdd.ReadToEnd
                Else
                    RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Password salah"
                End If
            Catch ex As Exception
                RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "gagal membuka ketik dxdiag.system.required untuk membuat password"
            End Try
        ElseIf InStr(RichTextBox2.Text, "clear") Then
            RichTextBox1.Text = ""
        ElseIf InStr(RichTextBox2.Text, "copy") Then
            RichTextBox1.Copy()
        ElseIf InStr(RichTextBox2.Text, "detik ka") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + New Random(3434).ToString
        ElseIf InStr(RichTextBox2.Text, "dxdiag.system.required") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + vbCrLf + New Random(2324454).ToString
            Dim intef = rasd.Next(995935756)
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Percakapan di enkripsi, simpan password ini " + intef.ToString
            Dim strr As System.IO.StreamWriter
            strr = New IO.StreamWriter("enc.crypt")
            strr.Write(intef)
            strr.Close()
        ElseIf InStr(RichTextBox2.Text, "wudhu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Gue sdg gak solat"
        ElseIf InStr(RichTextBox2.Text, "wudu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Nih, sudah"
        ElseIf InStr(RichTextBox2.Text, "dimas") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "D-M-A-M Dimas Amma...."
        ElseIf InStr(RichTextBox2.Text, "dimeh") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "lh dima si Amm*** meh"
        ElseIf InStr(RichTextBox2.Text, "zaki") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Do pr suak ki"
        ElseIf InStr(RichTextBox2.Text, "dzaky") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Admin segala grup"
        ElseIf InStr(RichTextBox2.Text, "kepin") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "@rzkydmas,@alfrzt.de,@imamay03"
        ElseIf InStr(RichTextBox2.Text, "imam a") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Makmum al yaasin"
        ElseIf InStr(RichTextBox2.Text, "agamamu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Ndk mau bilang, nanti rasis...."
        ElseIf InStr(RichTextBox2.Text, "agama loe") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Agama terbesar kedua di dunia"
        ElseIf InStr(RichTextBox2.Text, "agama ang") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Urang minang tu islam, baa ko"
        ElseIf InStr(RichTextBox2.Text, "agama kamu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "sssh jangan blang tu nnti rasis"
        ElseIf InStr(RichTextBox2.Text, "solat") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Lihat ini www.google.com\search=solat"
        ElseIf InStr(RichTextBox2.Text, "sholat") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Sekarang solat..."
        ElseIf InStr(RichTextBox2.Text, "makan kamu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "saya makan batu. krik krik...."
        ElseIf InStr(RichTextBox2.Text, "makan ang") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "makan kue bolu"
        ElseIf InStr(RichTextBox2.Text, "makananmu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Listrik `````"
        ElseIf InStr(RichTextBox2.Text, "makan loe") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "KFC makanan pokok gue"
        ElseIf InStr(RichTextBox2.Text, "jam") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "sekarang jam ;" + Now.ToLongTimeString
        ElseIf InStr(RichTextBox2.Text, "abjad") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "ABCDEFGHIJKLMNOPQRSTUVWXYZ, semua ada 27 huruf"
        ElseIf InStr(RichTextBox2.Text, "alfabet") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "abcd, itu?"
        ElseIf InStr(RichTextBox2.Text, "absolut") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Ads, www.blue-acid.blogspot.com"
            absed()
        ElseIf InStr(RichTextBox2.Text, "acak-acak") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "nih gue susun"
        ElseIf InStr(RichTextBox2.Text, "acak acak") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "nih gue susunin"
        ElseIf InStr(RichTextBox2.Text, "teka-teki") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Teka teki mungkin tersedia di versi selanjutnya, lihat nih www.blue-acid.blogspot.com"
        ElseIf InStr(RichTextBox2.Text, "yo!") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "ooooooo"
        ElseIf InStr(RichTextBox2.Text, "teka teki") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "ngak ada"
        ElseIf InStr(RichTextBox2.Text, "acara a") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "OMDI . di mtsn"
        ElseIf InStr(RichTextBox2.Text, "pr") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "ndk do do"
        ElseIf InStr(RichTextBox2.Text, "puasa") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Sm . sy blm makan dari pagi"
        ElseIf InStr(RichTextBox2.Text, "pakak") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Jlh talingo den ndk ado"
        ElseIf InStr(RichTextBox2.Text, "hiduang") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "D0000. M4R4H S4Y4"
        ElseIf InStr(RichTextBox2.Text, "buly") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Stop cyber bullying, www.kominfo.gov"
        ElseIf InStr(RichTextBox2.Text, "main") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Main ap?"
        ElseIf InStr(RichTextBox2.Text, "visual basic") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "coba tekan F7"
        ElseIf InStr(RichTextBox2.Text, "hack") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "di F7 tekan"
        ElseIf InStr(RichTextBox2.Text, "blackpink") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "bagi penggemar BP ketik blackpinkers"
        ElseIf InStr(RichTextBox2.Text, "paket") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "sudah habis"
        ElseIf InStr(RichTextBox2.Text, "lagu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "mungkin di versi selanjutnya ada lagu player"
        ElseIf InStr(RichTextBox2.Text, "musik") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "musik di versi 2.4"
        ElseIf InStr(RichTextBox2.Text, "bahasa") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "minang,indo,indomie"
        ElseIf InStr(RichTextBox2.Text, "bahaso") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "minang,indonesia"
        ElseIf InStr(RichTextBox2.Text, "indonesia") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "cintailah produk indonesia"
        ElseIf InStr(RichTextBox2.Text, "smansa") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "biru baru seru allahuakbar"
        ElseIf InStr(RichTextBox2.Text, "pagi") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "pagi pagi pagi"
        ElseIf InStr(RichTextBox2.Text, "siang") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "lapar nih"
        ElseIf InStr(RichTextBox2.Text, "bisa") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "ketikan apa aja deh"
        ElseIf InStr(RichTextBox2.Text, "versi") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "2.3 beta, secepatnya di upgrade mungkin"
        ElseIf InStr(RichTextBox2.Text, "pacar") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "gue jomblo fisabillilah"
        ElseIf InStr(RichTextBox2.Text, "jalan") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "nih dah jalan"
        ElseIf InStr(RichTextBox2.Text, "zhey") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "you are alayers sejati"
            absed()
        ElseIf InStr(RichTextBox2.Text, "anjay") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "anjay mabar"
        ElseIf InStr(RichTextBox2.Text, "bangsat") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "sudah jangan kebanyakan memerikan pencerahan"
        ElseIf InStr(RichTextBox2.Text, "bacot") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "gue bacoters sejati"
        ElseIf InStr(RichTextBox2.Text, "ibuk") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "buk apo"
        ElseIf InStr(RichTextBox2.Text, "haa") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "hiha"
        ElseIf InStr(RichTextBox2.Text, "hey") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "hey tayo"
        ElseIf InStr(RichTextBox2.Text, "botak") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "yang tidak solat jumat botak"
        ElseIf InStr(RichTextBox2.Text, "meme") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "//meme.com"
        ElseIf InStr(RichTextBox2.Text, "hobi") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "main simudin"
        ElseIf InStr(RichTextBox2.Text, "hoby") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "main hp ko ndak ado hp mati langsuang"
        ElseIf InStr(RichTextBox2.Text, "minum") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "minum komen urang"
        ElseIf InStr(RichTextBox2.Text, "kantuik") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "prooooooot,maaf habis minum soda"
        ElseIf InStr(RichTextBox2.Text, "kentut") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "prooooooot,kamu kentut ya..."
        ElseIf InStr(RichTextBox2.Text, "baca") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "baca hati orang"
        ElseIf InStr(RichTextBox2.Text, "baco") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "baco pikiran urang"
        ElseIf InStr(RichTextBox2.Text, "tidak") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "yaah......"
        ElseIf InStr(RichTextBox2.Text, "ndak") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "ndeh...."
        ElseIf InStr(RichTextBox2.Text, "salah") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "tidak.....!"
        ElseIf InStr(RichTextBox2.Text, "hukuman") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "apa!?"
        ElseIf InStr(RichTextBox2.Text, "nangis") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "uwek,uwek,uwek"
        ElseIf InStr(RichTextBox2.Text, "marah") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "?"
        ElseIf InStr(RichTextBox2.Text, "ragu") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "...?"
        ElseIf InStr(RichTextBox2.Text, "keluarga") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "keluarga simudin"
        ElseIf InStr(RichTextBox2.Text, "silis") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "hi...urang gilo di pasa"
        ElseIf InStr(RichTextBox2.Text, "pasa") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "pasar busuak"
        ElseIf InStr(RichTextBox2.Text, "filem") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "filem sponsbob"
        ElseIf InStr(RichTextBox2.Text, "film") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "film upin ipin"
        ElseIf InStr(RichTextBox2.Text, "movie") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "upi ipin the movie"
        ElseIf InStr(RichTextBox2.Text, "idul fitri") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "kapan idul fitri?"
        ElseIf InStr(RichTextBox2.Text, "idul adha") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "sapi siapa yang di qurban kan?"
        ElseIf InStr(RichTextBox2.Text, "berkelahi") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "saya tidak mau berkelahi"
        ElseIf InStr(RichTextBox2.Text, "bacakak") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "ndak doh"
        ElseIf InStr(RichTextBox2.Text, "takut") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "kalau saya pemberani"
        ElseIf InStr(RichTextBox2.Text, "takuik") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "ndak ah"
        ElseIf InStr(RichTextBox2.Text, "penakut") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "ngak!"
        ElseIf InStr(RichTextBox2.Text, "panakuik") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "ndak mungkin"
        ElseIf InStr(RichTextBox2.Text, "quite") Then
            Dim strr As System.IO.StreamWriter
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "disave"
            Try

                strr = New IO.StreamWriter("crcp.datae")
                strr.Write(RichTextBox1.Text)
                strr.Close()
            Catch ex As Exception
                RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "gagal menyimpan //solusi"
            End Try
            Application.Exit()
        ElseIf InStr(RichTextBox2.Text, "kaya") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "kalau saya pemberani"
        ElseIf InStr(RichTextBox2.Text, "Jam b") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "Sekarang jam " + DateAndTime.TimeString + " . kan bisa liat di bawah"
        ElseIf InStr(RichTextBox2.Text, "takut") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "kalau saya pemberani"
        ElseIf InStr(RichTextBox2.Text, "takut") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "kalau saya pemberani"
        ElseIf InStr(RichTextBox2.Text, "takut") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "kalau saya pemberani"
        ElseIf InStr(RichTextBox2.Text, "takut") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "kalau saya pemberani"
        ElseIf InStr(RichTextBox2.Text, "takut") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "kalau saya pemberani"
        ElseIf InStr(RichTextBox2.Text, "takut") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "kalau saya pemberani"
        ElseIf InStr(RichTextBox2.Text, "takut") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "kalau saya pemberani"
        ElseIf InStr(RichTextBox2.Text, "takut") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "kalau saya pemberani"
        ElseIf InStr(RichTextBox2.Text, "takut") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "kalau saya pemberani"
        ElseIf InStr(RichTextBox2.Text, "takut") Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "kalau saya pemberani"

        Else
            integ = rands.Next(3)
            If integ = 0 Then
                RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "....." + vbCrLf + Label1.Text + " : " + salaha
            ElseIf integ = 1 Then
                RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "....." + vbCrLf + Label1.Text + " : " + salahb
            ElseIf integ = 2 Then
                RichTextBox1.Text = RichTextBox1.Text + vbCrLf + TextBox1.Text + " : " + RichTextBox2.Text + vbCrLf + Label1.Text + " : " + "....." + vbCrLf + Label1.Text + " : " + salahc
            Else
                RichTextBox1.Text = RichTextBox1.Text + vbCrLf + Label1.Text + " : " + "gua masih butuh belajar"
            End If

        End If
        RichTextBox2.Text = ""
    End Sub
    Sub inspot()
        Dim strImagePath As String = "1f60e.png"
        Dim img As Image
        img = Image.FromFile(strImagePath)
        Clipboard.SetDataObject(img)
        Dim df As DataFormats.Format
        df = DataFormats.GetFormat(DataFormats.Bitmap)
     
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StrConv(RichTextBox2.Text, VbStrConv.Lowercase)
        percakapan()
        If TextBox1.Text = "Alang" Then
            RichTextBox1.Text = RichTextBox1.Text + vbCrLf + Label1.Text + " : " + "Alang - Alang"

        End If
    End Sub
    Private Sub RichTextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles RichTextBox2.KeyUp
        If e.KeyCode = Keys.Enter Then
            StrConv(RichTextBox2.Text, VbStrConv.Lowercase)
            percakapan()
        ElseIf e.KeyCode = Keys.F5 Then
            hitung()
        ElseIf e.KeyCode = Keys.F7 Then
            devmod()
        End If
    End Sub
    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        Dim namam As String
        namam = InputBox("Masukan Nama", "Ubah Nama")
        If namam = "" Then
            MsgBox("Nama salah")
        Else
            Label1.Text = namam
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        RichTextBox1.Focus()
    End Sub
    Sub absed()
        PictureBox1.Left = -171
        PictureBox1.Visible = True
        Timer1.Enabled = True
        PictureBox2.Left = -171
        PictureBox2.Visible = True
        Timer1.Enabled = True
    End Sub
    Sub ahsiap()
        PictureBox1.Left = -171
        PictureBox1.Visible = True
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Left += 5
        For fin = 250 To 300
            If PictureBox1.Left = fin Then
                PictureBox1.Visible = False
                Timer1.Enabled = False
            End If
        Next
        PictureBox2.Left += 5
        For fin = 250 To 300
            If PictureBox2.Left = fin Then
                PictureBox2.Visible = False
                Timer1.Enabled = False
            End If
        Next
    End Sub

    Private Sub RichTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles RichTextBox1.KeyDown
        e.SuppressKeyPress = True
    End Sub
    Private Sub RichTextBox1_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles RichTextBox1.LinkClicked
        Process.Start(e.LinkText.ToString)
        If e.LinkText = "//solusi" Then
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.ShowDialog()
    End Sub
    Sub bacsd()
        Try
            Dim strw As IO.StreamReader
            strw = New IO.StreamReader("UserData.dat")
            TextBox1.Text = strw.ReadToEnd
            Dim dsds As IO.StreamReader
            dsds = New IO.StreamReader("Creps.dats")
            RichTextBox1.Text = strw.ReadToEnd
        Catch ex As Exception
            MsgBox("Silahkan Sign Up Terlebih Dahulu", MsgBoxStyle.Information)
            Form7.ShowDialog()
        End Try
    End Sub
    Sub saved()
        Dim strr As New IO.StreamWriter("Creps.dats")
        strr.Write(RichTextBox1.Text)
        strr.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Anda belum menyimpan, simpan sekarang", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            saved()
            Application.Exit()
        ElseIf MsgBox("Anda belum menyimpan, simpan sekarang", MsgBoxStyle.YesNoCancel) = MsgBoxResult.No Then
            Application.Exit()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
    End Sub
    Sub Losd()
        Dim strw As IO.StreamReader
        Dim sds As String
        strw = New IO.StreamReader("encrop.datae")
        sds = strw.ReadToEnd
        If InputBox("Masukan Password:", "Masukan Password") = sds Then
            bacsd()
        Else
            MsgBox("Password Salah!", MsgBoxStyle.Exclamation, "Password Salah")
            Form7.ShowDialog()
            Me.Close()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        saved()
    End Sub
End Class
