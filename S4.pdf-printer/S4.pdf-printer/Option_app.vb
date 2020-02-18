Imports System.IO
Public Class Option_app
    Public save_metod As String = Convert.ToString(True)
    Public Username As String = Convert.ToString(True)
    Public default_folder_parh As String = "C:\IM\IMWork"

    Public ImagePath As String = get_reesrt_value("ImagePath", Application.StartupPath & "\об изменении не сообщается.png")
    Public Image_Angle As String = get_reesrt_value("Image_Angle", "5")
    Public PicX As String = get_reesrt_value("PicX", Convert.ToString("200"))
    Public PicY As String = get_reesrt_value("PicY", Convert.ToString("190"))

    Public fileDel As String = get_reesrt_value("fileDel", Convert.ToString(False))
    Public ShtampCreate As String = get_reesrt_value("ShtampCreate", Convert.ToString(False))
    Public add_SGN_INFO As String = get_reesrt_value("add_SGN_INFO", Convert.ToString(False))


    Public UserNameX As String = get_reesrt_value("UserNameX", Convert.ToString("10"))
    Public UserNameY As String = get_reesrt_value("UserNameY", Convert.ToString("5"))
    Public UserName_Sign As String = get_reesrt_value("UserName_Sign", Convert.ToString(False))

    Public PrintTimeX As String = get_reesrt_value("PrintTimeX", Convert.ToString("15"))
    Public PrintTimeY As String = get_reesrt_value("PrintTimeY", Convert.ToString("5"))
    Public PrintTime_Sign As String = get_reesrt_value("PrintTime_Sign", Convert.ToString(False))

    Public InvNumX As String = get_reesrt_value("InvNumX", Convert.ToString("15"))
    Public InvNumY As String = get_reesrt_value("InvNumY", Convert.ToString("10"))
    Public InvNum_Sign As String = get_reesrt_value("InvNum_Sign", Convert.ToString(False))

    Public DatePodpX As String = get_reesrt_value("DatePodpX", Convert.ToString("53"))
    Public DatePodpY As String = get_reesrt_value("DatePodpY", Convert.ToString("20"))
    Public DatePodp_Sign As String = get_reesrt_value("DatePodp_Sign", Convert.ToString(False))

    Private Sub Option_app_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        create_options()

        RadioButton1.Checked = Convert.ToBoolean(save_metod)
        RadioButton2.Checked = Not Convert.ToBoolean(save_metod)
        TextBox2.Text = ImagePath
        PictureBox1.Image = New Bitmap(ImagePath)

        TextBox1.Text = default_folder_parh
        TextBox3.Text = Image_Angle
        PicX_Tb.Text = PicX
        PicY_Tb.Text = PicY

        CheckBox1.Checked = fileDel
        CheckBox2.Checked = ShtampCreate
        CheckBox3.Checked = add_SGN_INFO

        UserNameX_tb.Text = UserNameX
        UserNameY_tb.Text = UserNameY
        UserName_Sign_Cb.Checked = Convert.ToBoolean(UserName_Sign)

        PrintTimeX_Tb.Text = PrintTimeX
        PrintTimeY_Tb.Text = PrintTimeY
        PrintTimeX_Sign_Cb.Checked = Convert.ToBoolean(PrintTime_Sign)

        InvNumX_Tb.Text = InvNumX
        InvNumY_Tb.Text = InvNumY
        InvNum_Sign_Cb.Checked = Convert.ToBoolean(InvNum_Sign)

        DatePodpX_Tb.Text = DatePodpX
        DatePodpY_Tb.Text = DatePodpY
        DatePodp_Sign_Cb.Checked = Convert.ToBoolean(DatePodp_Sign)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        save_options()
        Me.Close()
    End Sub
    Public Sub create_options()
        save_metod = get_reesrt_value("save_metod", save_metod)

        Username = get_reesrt_value("Username", Username)

        default_folder_parh = get_reesrt_value("default_folder_parh", default_folder_parh)
        Form1.default_folder_parh = default_folder_parh

        ImagePath = get_reesrt_value("ImagePath", ImagePath)

        Image_Angle = get_reesrt_value("Image_Angle", Image_Angle)
        PicX = get_reesrt_value("PicX", PicX)
        PicY = get_reesrt_value("PicY", PicY)

        fileDel = get_reesrt_value("fileDel", Convert.ToString(False))
        ShtampCreate = get_reesrt_value("ShtampCreate", Convert.ToString(False))
        add_SGN_INFO = get_reesrt_value("add_SGN_INFO", add_SGN_INFO)

        UserNameX = get_reesrt_value("UserNameX", UserNameX)
        UserNameY = get_reesrt_value("UserNameY", UserNameY)
        UserName_Sign = get_reesrt_value("UserName_Sign", UserName_Sign)

        PrintTimeX = get_reesrt_value("PrintTimeX", PrintTimeX)
        PrintTimeY = get_reesrt_value("PrintTimeY", PrintTimeY)
        PrintTime_Sign = get_reesrt_value("PrintTime_Sign", PrintTime_Sign)

        InvNumX = get_reesrt_value("InvNumX", InvNumX)
        InvNumY = get_reesrt_value("InvNumY", InvNumY)
        InvNum_Sign = get_reesrt_value("InvNum_Sign", InvNum_Sign)

        DatePodpX = get_reesrt_value("DatePodpX", DatePodpX)
        DatePodpY = get_reesrt_value("DatePodpY", DatePodpY)
        DatePodp_Sign = get_reesrt_value("DatePodp_Sign", DatePodp_Sign)
    End Sub
    Sub save_options()
        set_reesrt_value("save_metod", Convert.ToString(RadioButton1.Checked))

        set_reesrt_value("default_folder_parh", TextBox1.Text)
        default_folder_parh = TextBox1.Text
        set_reesrt_value("ImagePath", TextBox2.Text)
        ImagePath = TextBox2.Text
        set_reesrt_value("Image_Angle", TextBox3.Text)
        Image_Angle = TextBox3.Text

        fileDel = Convert.ToString(CheckBox1.Checked)
        set_reesrt_value("fileDel", fileDel)
        ShtampCreate = Convert.ToString(CheckBox2.Checked)
        set_reesrt_value("ShtampCreate", ShtampCreate)
        add_SGN_INFO = Convert.ToString(CheckBox3.Checked)
        set_reesrt_value("add_SGN_INFO", add_SGN_INFO)

        PicX = PicX_Tb.Text : set_reesrt_value("PicX", PicX)
        PicY = PicY_Tb.Text : set_reesrt_value("PicY", PicY)

        UserNameX = UserNameX_tb.Text : set_reesrt_value("UserNameX", UserNameX)
        UserNameY = UserNameY_tb.Text : set_reesrt_value("UserNameY", UserNameY)
        UserName_Sign = UserName_Sign_Cb.Checked.ToString : set_reesrt_value("UserName_Sign", UserName_Sign)

        PrintTimeX = PrintTimeX_Tb.Text : set_reesrt_value("PrintTimeX", PrintTimeX)
        PrintTimeY = PrintTimeY_Tb.Text : set_reesrt_value("PrintTimeY", PrintTimeY)
        PrintTime_Sign = PrintTimeX_Sign_Cb.Checked.ToString : set_reesrt_value("PrintTime_Sign", PrintTime_Sign)

        InvNumX = InvNumX_Tb.Text : set_reesrt_value("InvNumX", InvNumX)
        InvNumY = InvNumY_Tb.Text : set_reesrt_value("InvNumY", InvNumY)
        InvNum_Sign = InvNum_Sign_Cb.Checked.ToString : set_reesrt_value("InvNum_Sign", InvNum_Sign)

        DatePodpX = DatePodpX_Tb.Text : set_reesrt_value("DatePodpX", DatePodpX)
        DatePodpY = DatePodpY_Tb.Text : set_reesrt_value("DatePodpY", DatePodpY)
        DatePodp_Sign = DatePodp_Sign_Cb.Checked.ToString : set_reesrt_value("DatePodp_Sign", DatePodp_Sign)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Option_app_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        Me.KeyPreview = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.OpenFileDialog1.Filter = "Рисунок(*.png)|"


        ' Allow the user to select multiple images.
        Me.OpenFileDialog1.Multiselect = False
        Me.OpenFileDialog1.Title = "Укажите ссылку на Штамп"
        OpenFileDialog1.InitialDirectory = Path.GetDirectoryName(Image_Angle)
        Dim dr As DialogResult = Me.OpenFileDialog1.ShowDialog()
        If (dr = System.Windows.Forms.DialogResult.OK) Then
            ' Read the files
            Dim file, fileformat As String
            file = OpenFileDialog1.FileName
            fileformat = file.Substring(file.LastIndexOf(".") + 1)
            If UCase(fileformat) = UCase("png") Then
                TextBox2.Text = file
            Else
                MsgBox("Штамп должен быть в формате .png ")
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        addImageinPB()
    End Sub
    Public Sub addImageinPB()
        PictureBox1.Image = New Bitmap(TextBox2.Text)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        'PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY = CDbl(TextBox4.Text))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        With Form1.ITS4App
            Dim samleId As Integer
            .SelectSample(1729, 0)
            Dim s4class As Object = .GetClassificatorInterface

        End With
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Process.Start("http://www.evernote.com/l/AjIedbtETVdJAosvHnMxrbOHdfLEpwUu8JM/")
    End Sub
End Class