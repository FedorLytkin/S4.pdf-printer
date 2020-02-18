<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Option_app
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Option_app))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PicY_Tb = New System.Windows.Forms.TextBox()
        Me.PicX_Tb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DatePodpY_Tb = New System.Windows.Forms.TextBox()
        Me.DatePodpX_Tb = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrintTimeY_Tb = New System.Windows.Forms.TextBox()
        Me.PrintTimeX_Tb = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.InvNumY_Tb = New System.Windows.Forms.TextBox()
        Me.InvNumX_Tb = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserNameY_tb = New System.Windows.Forms.TextBox()
        Me.UserNameX_tb = New System.Windows.Forms.TextBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.InvNum_Sign_Cb = New System.Windows.Forms.CheckBox()
        Me.DatePodp_Sign_Cb = New System.Windows.Forms.CheckBox()
        Me.UserName_Sign_Cb = New System.Windows.Forms.CheckBox()
        Me.PrintTimeX_Sign_Cb = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(206, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Сохранить"
        Me.ToolTip1.SetToolTip(Me.Button1, "Сохранить изменения")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(295, 194)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 24)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Отмена"
        Me.ToolTip1.SetToolTip(Me.Button2, "Отменить и выйти")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 18)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(137, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Сохранять копию PDF"
        Me.ToolTip1.SetToolTip(Me.RadioButton1, "Приложение сохранит копию с Пометкой в другой папке")
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 41)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(99, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Заменять PDF"
        Me.ToolTip1.SetToolTip(Me.RadioButton2, "Приложение вместо Оригинала, заменить копией. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Оригинал при этом уничтожится")
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(149, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(47, 24)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "..."
        Me.ToolTip1.SetToolTip(Me.Button3, "Указать папку, где будут сохраняться файлы")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "изображение, накладываемое в выгружаемый документа")
        Me.PictureBox1.UseWaitCursor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.GhostWhite
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(150, 19)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(206, 44)
        Me.TextBox2.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.TextBox2, "Путь к изображению штампа")
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(202, 14)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(157, 44)
        Me.TextBox1.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Папка, где будут сохраняться файлы")
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 13)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(284, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Удалять файл в каталоге, при удалении из списка"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "При ВКЛ опции удаляемый из Списка документ будет удален в каталоге, где он хранит" &
        "ся")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(6, 76)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(164, 17)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "Записывать подпись из S4"
        Me.ToolTip1.SetToolTip(Me.CheckBox3, "При ВКЛ опции удаляемый из Списка документ будет удален в каталоге, где он хранит" &
        "ся")
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 67)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Метод открытия PDF"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(376, 192)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CheckBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(368, 166)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Общие"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CheckBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(368, 166)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Штамп"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(9, 6)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(122, 17)
        Me.CheckBox2.TabIndex = 18
        Me.CheckBox2.Text = "Проставить штамп"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.PicY_Tb)
        Me.GroupBox2.Controls.Add(Me.PicX_Tb)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 135)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Параметры штампа"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(279, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Y"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(194, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "X"
        '
        'PicY_Tb
        '
        Me.PicY_Tb.Location = New System.Drawing.Point(299, 106)
        Me.PicY_Tb.Name = "PicY_Tb"
        Me.PicY_Tb.Size = New System.Drawing.Size(57, 20)
        Me.PicY_Tb.TabIndex = 17
        Me.PicY_Tb.Text = "190"
        '
        'PicX_Tb
        '
        Me.PicX_Tb.Location = New System.Drawing.Point(214, 106)
        Me.PicX_Tb.Name = "PicX_Tb"
        Me.PicX_Tb.Size = New System.Drawing.Size(57, 20)
        Me.PicX_Tb.TabIndex = 18
        Me.PicX_Tb.Text = "200"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Угол поворота (в градусах):"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(150, 69)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 26)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Обзор"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(157, 106)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(20, 20)
        Me.TextBox3.TabIndex = 15
        Me.TextBox3.Text = "5"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.CheckBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(368, 166)
        Me.TabPage4.TabIndex = 2
        Me.TabPage4.Text = "Список документов"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(368, 166)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Позиция текста"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(251, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Координаты указаны в DPI (Не в миллиметрах)!"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DatePodp_Sign_Cb)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.DatePodpY_Tb)
        Me.GroupBox6.Controls.Add(Me.DatePodpX_Tb)
        Me.GroupBox6.Location = New System.Drawing.Point(183, 75)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(174, 63)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Подп.и Дата"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(91, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Y"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "X"
        '
        'DatePodpY_Tb
        '
        Me.DatePodpY_Tb.Location = New System.Drawing.Point(111, 16)
        Me.DatePodpY_Tb.Name = "DatePodpY_Tb"
        Me.DatePodpY_Tb.Size = New System.Drawing.Size(57, 20)
        Me.DatePodpY_Tb.TabIndex = 0
        Me.DatePodpY_Tb.Text = "20"
        '
        'DatePodpX_Tb
        '
        Me.DatePodpX_Tb.Location = New System.Drawing.Point(26, 16)
        Me.DatePodpX_Tb.Name = "DatePodpX_Tb"
        Me.DatePodpX_Tb.Size = New System.Drawing.Size(57, 20)
        Me.DatePodpX_Tb.TabIndex = 0
        Me.DatePodpX_Tb.Text = "53"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PrintTimeX_Sign_Cb)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.PrintTimeY_Tb)
        Me.GroupBox4.Controls.Add(Me.PrintTimeX_Tb)
        Me.GroupBox4.Location = New System.Drawing.Point(183, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(174, 63)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Время печати"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Y"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "X"
        '
        'PrintTimeY_Tb
        '
        Me.PrintTimeY_Tb.Location = New System.Drawing.Point(111, 16)
        Me.PrintTimeY_Tb.Name = "PrintTimeY_Tb"
        Me.PrintTimeY_Tb.Size = New System.Drawing.Size(57, 20)
        Me.PrintTimeY_Tb.TabIndex = 0
        Me.PrintTimeY_Tb.Text = "5"
        '
        'PrintTimeX_Tb
        '
        Me.PrintTimeX_Tb.Location = New System.Drawing.Point(26, 16)
        Me.PrintTimeX_Tb.Name = "PrintTimeX_Tb"
        Me.PrintTimeX_Tb.Size = New System.Drawing.Size(57, 20)
        Me.PrintTimeX_Tb.TabIndex = 0
        Me.PrintTimeX_Tb.Text = "15"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.InvNum_Sign_Cb)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.InvNumY_Tb)
        Me.GroupBox5.Controls.Add(Me.InvNumX_Tb)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 75)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(174, 63)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Инвентарный номер"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Y"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "X"
        '
        'InvNumY_Tb
        '
        Me.InvNumY_Tb.Location = New System.Drawing.Point(111, 16)
        Me.InvNumY_Tb.Name = "InvNumY_Tb"
        Me.InvNumY_Tb.Size = New System.Drawing.Size(57, 20)
        Me.InvNumY_Tb.TabIndex = 0
        Me.InvNumY_Tb.Text = "10"
        '
        'InvNumX_Tb
        '
        Me.InvNumX_Tb.Location = New System.Drawing.Point(26, 16)
        Me.InvNumX_Tb.Name = "InvNumX_Tb"
        Me.InvNumX_Tb.Size = New System.Drawing.Size(57, 20)
        Me.InvNumX_Tb.TabIndex = 0
        Me.InvNumX_Tb.Text = "15"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.UserName_Sign_Cb)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.UserNameY_tb)
        Me.GroupBox3.Controls.Add(Me.UserNameX_tb)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(174, 63)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Имя пользователя"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Y"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "X"
        '
        'UserNameY_tb
        '
        Me.UserNameY_tb.Location = New System.Drawing.Point(111, 16)
        Me.UserNameY_tb.Name = "UserNameY_tb"
        Me.UserNameY_tb.Size = New System.Drawing.Size(57, 20)
        Me.UserNameY_tb.TabIndex = 0
        Me.UserNameY_tb.Text = "5"
        '
        'UserNameX_tb
        '
        Me.UserNameX_tb.Location = New System.Drawing.Point(26, 16)
        Me.UserNameX_tb.Name = "UserNameX_tb"
        Me.UserNameX_tb.Size = New System.Drawing.Size(57, 20)
        Me.UserNameX_tb.TabIndex = 0
        Me.UserNameX_tb.Text = "10"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 196)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(380, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton1.Text = "Справка"
        '
        'InvNum_Sign_Cb
        '
        Me.InvNum_Sign_Cb.AutoSize = True
        Me.InvNum_Sign_Cb.Location = New System.Drawing.Point(9, 42)
        Me.InvNum_Sign_Cb.Name = "InvNum_Sign_Cb"
        Me.InvNum_Sign_Cb.Size = New System.Drawing.Size(70, 17)
        Me.InvNum_Sign_Cb.TabIndex = 2
        Me.InvNum_Sign_Cb.Text = "В печать"
        Me.InvNum_Sign_Cb.UseVisualStyleBackColor = True
        '
        'DatePodp_Sign_Cb
        '
        Me.DatePodp_Sign_Cb.AutoSize = True
        Me.DatePodp_Sign_Cb.Location = New System.Drawing.Point(6, 42)
        Me.DatePodp_Sign_Cb.Name = "DatePodp_Sign_Cb"
        Me.DatePodp_Sign_Cb.Size = New System.Drawing.Size(70, 17)
        Me.DatePodp_Sign_Cb.TabIndex = 2
        Me.DatePodp_Sign_Cb.Text = "В печать"
        Me.DatePodp_Sign_Cb.UseVisualStyleBackColor = True
        '
        'UserName_Sign_Cb
        '
        Me.UserName_Sign_Cb.AutoSize = True
        Me.UserName_Sign_Cb.Location = New System.Drawing.Point(3, 40)
        Me.UserName_Sign_Cb.Name = "UserName_Sign_Cb"
        Me.UserName_Sign_Cb.Size = New System.Drawing.Size(70, 17)
        Me.UserName_Sign_Cb.TabIndex = 2
        Me.UserName_Sign_Cb.Text = "В печать"
        Me.UserName_Sign_Cb.UseVisualStyleBackColor = True
        '
        'PrintTimeX_Sign_Cb
        '
        Me.PrintTimeX_Sign_Cb.AutoSize = True
        Me.PrintTimeX_Sign_Cb.Location = New System.Drawing.Point(6, 40)
        Me.PrintTimeX_Sign_Cb.Name = "PrintTimeX_Sign_Cb"
        Me.PrintTimeX_Sign_Cb.Size = New System.Drawing.Size(70, 17)
        Me.PrintTimeX_Sign_Cb.TabIndex = 2
        Me.PrintTimeX_Sign_Cb.Text = "В печать"
        Me.PrintTimeX_Sign_Cb.UseVisualStyleBackColor = True
        '
        'Option_app
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 221)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Option_app"
        Me.Text = "Настройки"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DatePodpY_Tb As TextBox
    Friend WithEvents DatePodpX_Tb As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PrintTimeY_Tb As TextBox
    Friend WithEvents PrintTimeX_Tb As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents InvNumY_Tb As TextBox
    Friend WithEvents InvNumX_Tb As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UserNameY_tb As TextBox
    Friend WithEvents UserNameX_tb As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PicY_Tb As TextBox
    Friend WithEvents PicX_Tb As TextBox
    Friend WithEvents DatePodp_Sign_Cb As CheckBox
    Friend WithEvents PrintTimeX_Sign_Cb As CheckBox
    Friend WithEvents InvNum_Sign_Cb As CheckBox
    Friend WithEvents UserName_Sign_Cb As CheckBox
End Class
