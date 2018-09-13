Imports System.IO
Public Class Option_app
    Public save_metod As String = Convert.ToString(True)
    Public stamp_create As String = Convert.ToString(False)
    Public Username As String = Convert.ToString(True)
    Public default_folder_parh As String = "C:\IM\IMWork"
    Public ImagePath As String = get_reesrt_value("ImagePath", Application.StartupPath & "\об изменении не сообщается.png")
    Public Image_Angle As String = get_reesrt_value("Image_Angle", "5")
    Public fileDel As String = get_reesrt_value("fileDel", Convert.ToString(False))
    Public ShtampCreate As String = get_reesrt_value("ShtampCreate", Convert.ToString(False))

    Private Sub Option_app_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        create_options()

        RadioButton1.Checked = Convert.ToBoolean(save_metod)
        RadioButton2.Checked = Not Convert.ToBoolean(save_metod)
        TextBox2.Text = ImagePath
        PictureBox1.Image = New Bitmap(ImagePath)

        TextBox1.Text = default_folder_parh
        TextBox3.Text = Image_Angle
        CheckBox1.Checked = fileDel
        CheckBox2.Checked = ShtampCreate
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        save_options()
        Me.Close()
    End Sub
    Public Sub create_options()
        save_metod = get_reesrt_value("save_metod", save_metod)

        stamp_create = get_reesrt_value("stamp_create", stamp_create)

        Username = get_reesrt_value("Username", Username)

        default_folder_parh = get_reesrt_value("default_folder_parh", default_folder_parh)
        Form1.default_folder_parh = default_folder_parh

        ImagePath = get_reesrt_value("ImagePath", ImagePath)

        Image_Angle = get_reesrt_value("Image_Angle", Image_Angle)
        fileDel = get_reesrt_value("fileDel", Convert.ToString(False))
        ShtampCreate = get_reesrt_value("ShtampCreate", Convert.ToString(False))

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
        set_reesrt_value("ShtampCreate", fileDel)
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