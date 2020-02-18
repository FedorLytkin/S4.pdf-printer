Imports System.IO

Public NotInheritable Class AboutBox1

    Public Fl_ReadMePath As String = Application.StartupPath & "\ReadMe.txt"
    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Установить заголовок формы.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("О программе {0}", ApplicationTitle)
        ' Инициализировать текст, отображаемый в окне "О программе".
        ' TODO: настроить сведения о сборке приложения в области "Приложение" диалогового окна 
        '    свойств проекта (в меню "Проект").
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Версия {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = "Разработчик: Айдарханов Насипберли
email: aidarhanovn@gmail.com
тел: +7 (931) 007 93 16"
        Me.TextBoxDescription.Text = My.Application.Info.Description & vbCr & Me.TextBoxDescription.Text
        Me.TextBoxDescription.Text = Read_ReadMeTXT()
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
    Function Read_ReadMeTXT() As String
        Dim read_Text As String = ""

        Dim strFile As String = Fl_ReadMePath
        Dim fileExists As Boolean = File.Exists(strFile)
        If fileExists Then
            Using r As StreamReader = New StreamReader(Fl_ReadMePath, System.Text.Encoding.GetEncoding(1251))
                Do While (Not r.EndOfStream)
                    read_Text += r.ReadLine() + Environment.NewLine ' &= r.ReadLine & Environment.NewLine 
                Loop
            End Using
        Else
            read_Text = Me.TextBoxDescription.Text
        End If
        Return read_Text
    End Function
End Class
