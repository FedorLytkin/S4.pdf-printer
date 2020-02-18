Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Text
Imports System.Drawing.Printing
Imports System.IO.FileStream

Public Class Form1

    Public ITS4App As S4.TS4App
    Public S4Username As String
    Public default_folder_parh As String = get_reesrt_value("default_folder_parh", "C:\IM\IMWork")

    Private Sub СоздатьToolStripButton_Click(sender As Object, e As EventArgs)
        'Dim pdfDoc As New Document
        'Dim pdfwrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("0012.063.03.02.001 Вал.pdf", FileMode.Open))

        'pdfDoc.Open()
        'pdfDoc.Add(New Paragraph(Now))
        ''pdfDoc.NewPage()
        ''pdfDoc.Add(New Paragraph("ПРоверка прошла успешно - " & Now))
        'pdfDoc.Close()
        'create_newpdf()
    End Sub
    Function new_filename(oldFileName As String) As String
        new_filename = oldFileName.Substring(0, oldFileName.LastIndexOf(".")) & "1.pdf"
    End Function
    Sub create_newpdfwithTiff(TIFfileName As String, OTD_REGNUM As String, OTD_reg As String)
        Dim newFile = TIFfileName.Substring(0, TIFfileName.LastIndexOf(".")) & ".pdf"
        Try
            Dim PageSize As iTextSharp.text.Rectangle
            Dim srcImage As Bitmap = New Bitmap(TIFfileName)
            PageSize = New iTextSharp.text.Rectangle(0, 0, srcImage.Width, srcImage.Height)

            Dim ms As MemoryStream = New MemoryStream
            Dim doc As Document = New iTextSharp.text.Document(PageSize, 0, 0, 0, 0)
            iTextSharp.text.pdf.PdfWriter.GetInstance(doc, ms).SetFullCompression()

            'Dim fs As FileStream = New FileStream(newFile, FileMode.Create, FileAccess.Write)
            'Dim writer As PdfWriter = PdfWriter.GetInstance(doc, ms)
            doc.Open()

            Dim Image = iTextSharp.text.Image.GetInstance(TIFfileName)
            doc.Add(Image)
            Try
                doc.Close()

                File.WriteAllBytes(newFile, ms.ToArray())
                create_newpdf(newFile, OTD_REGNUM, OTD_reg, True)
            Catch ex As Exception
                MsgBox("Ошибка при сохранении '" & newFile & "'.Возможно он открыт в другом приложении" & vbNewLine & ex.Message)
            End Try

        Catch ex As Exception
            MsgBox("Windows не удается найти '" & newFile & "'.Проверьте правильность написания пути и попробуйте еще раз" & vbNewLine & ex.Message)
        End Try
    End Sub
    Sub create_newpdf(PDFfileName As String, OTD_REGNUM As String, OTD_reg As String, FirstDoc As Boolean)
        Dim oldFile = PDFfileName
        Dim newFile = new_filename(PDFfileName)
        Dim delta As Double
        If FirstDoc Then
            delta = 50
        Else
            delta = 0
        End If
        Try
            Dim reader As PdfReader = New PdfReader(oldFile)
            Dim size As Rectangle = reader.GetPageSizeWithRotation(1)
            Dim document As Document = New Document(size)
            ' open the writer
            Dim fs As FileStream = New FileStream(newFile, FileMode.Create, FileAccess.Write)
            Dim writer As PdfWriter = PdfWriter.GetInstance(document, fs)
            document.Open()

            ' the pdf content
            Dim cb As PdfContentByte = writer.DirectContent

            For i As Integer = 1 To reader.NumberOfPages
                document.SetPageSize(reader.GetPageSizeWithRotation(i))
                Dim page As PdfImportedPage = writer.GetImportedPage(reader, i)
                document.NewPage()
                ' create the New page And add it to the pdf

                If (FirstDoc) Then
                    cb.AddTemplate(page, 0, 0)
                End If
                ' select the font properties
                Dim bf As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, "Cp1251", BaseFont.NOT_EMBEDDED)
                cb.SetColorFill(BaseColor.GRAY)
                cb.FillStroke()
                cb.SetFontAndSize(bf, 10 + delta)

                Dim oX As Double
                Dim oY As Double
                'штамп
                If Convert.ToBoolean(Option_app.ShtampCreate) Then
                    Try
                        oX = Option_app.PicX
                        oY = Option_app.PicY
                        Dim logo As Image = iTextSharp.text.Image.GetInstance(Option_app.ImagePath, FileMode.Open)
                        logo.ScalePercent(70.0F + 5 * delta)
                        logo.RotationDegrees = CSng(Option_app.Image_Angle)
                        logo.SetAbsolutePosition(size.Right - oX + delta, oY + delta)
                        writer.DirectContent.AddImage(logo)
                    Catch ex As Exception
                        MsgBox("Ошибка при нанесении штампа. Проверьте ссылку на штамп!")
                        ListBox2.Items.Add(ex.Message)
                    End Try
                End If
                Dim TextOnPDF As String
                'пользователь
                If Convert.ToBoolean(Option_app.UserName_Sign) Then
                    oX = Option_app.UserNameX
                    oY = Option_app.UserNameY
                    cb.BeginText()
                    cb.SetFontAndSize(bf, 10 + delta)
                    cb.ShowTextAligned(0, S4Username, oX + delta, oY + delta, 0)
                    cb.EndText()
                End If

                'дата печати
                If Convert.ToBoolean(Option_app.PrintTime_Sign) Then
                    oX = Option_app.PrintTimeX
                    oY = Option_app.PrintTimeY
                    cb.BeginText()
                    TextOnPDF = Now.ToShortDateString & " " & Now.ToShortTimeString
                    cb.ShowTextAligned(0, TextOnPDF, oX + delta, oY + delta, 0)
                    cb.EndText()
                End If

                'Код ОТД
                If Convert.ToBoolean(Option_app.InvNum_Sign) Then
                    cb.BeginText()
                    cb.SetFontAndSize(bf, 15 + delta)
                    oX = Option_app.InvNumX
                    oY = Option_app.InvNumY
                    ' put the alignment And coordinates here
                    cb.ShowTextAligned(0, OTD_REGNUM, oX + delta, oY + delta, 90)
                    cb.EndText()
                End If

                'дата регистрации
                If Convert.ToBoolean(Option_app.DatePodp_Sign) Then
                    oX = Option_app.DatePodpX
                    oY = Option_app.DatePodpY
                    cb.BeginText()
                    cb.ShowTextAligned(0, OTD_reg, oX + delta, oY + delta, 90)
                    cb.EndText()
                End If

                If Not (FirstDoc) Then
                    cb.AddTemplate(page, 0, 0)
                End If
            Next
            Try
                ' close the streams And voilá the file should be changed )
                document.Close()
                fs.Close()
                writer.Close()
                reader.Close()
                If File.Exists(oldFile) Then
                    File.Delete(oldFile)
                    File.Move(newFile, oldFile)
                End If
                addInLB(oldFile)
                'ListBox1.Items.Add(oldFile)
            Catch ex As Exception
                MsgBox("Ошибка при сохранении '" & PDFfileName & "'.Возможно он открыт в другом приложении" & vbNewLine & ex.Message)
                ListBox2.Items.Add(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox("Windows не удается найти '" & PDFfileName & "'.Проверьте правильность написания пути и попробуйте еще раз" & vbNewLine & ex.Message)
            ListBox2.Items.Add(ex.Message)
        End Try

    End Sub

    Public Function RussWord(word As String)
        Dim rusword As String
        Dim space As String = "   "
        For i As Integer = 0 To word.Length - 1
            rusword = rusword & word.Substring(i, 1) & space
        Next
        Return rusword
    End Function
    Private Sub ПечатьToolStripButton_Click(sender As Object, e As EventArgs)
        'AxAcroPDF1.src = "C:\Users\aidarhanov.n.VEZA-SPB\Cloud Maill\VisualStudio\S4.pdf-printer\S4.pdf-printer\bin\Debug\0012.063.03.02.002 Ступица111.pdf"
        Dim printerDialog As PrintDialog = New PrintDialog
        printerDialog.AllowSomePages = True
        printerDialog.ShowHelp = False
        'printerDialog.PrinterSettings = settings
        printerDialog.AllowPrintToFile = True
        printerDialog.PrinterSettings.PrintToFile = True

        Dim result As DialogResult = printerDialog.ShowDialog
        If result = DialogResult.OK Then
            Dim printDoc = New PrintDocument()
            'printDoc.PrintPage = printDoc.PrintPage + printDoc_PrintPage
            printDoc.PrinterSettings = printerDialog.PrinterSettings
            printDoc.Print()
        End If
    End Sub

    Private Sub СправкаToolStripButton_Click(sender As Object, e As EventArgs)
        App_info.ShowDialog()
    End Sub

    Private Sub ListBox1_DragEnter(sender As Object, e As DragEventArgs) Handles ListBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub ListBox1_DragDrop(sender As Object, e As DragEventArgs) Handles ListBox1.DragDrop
        Dim file, fileformat As String
        For Each file In e.Data.GetData(DataFormats.FileDrop)
            fileformat = file.Substring(file.LastIndexOf(".") + 1)
            If UCase(fileformat) = "PDF" Then
                ListBox1.Items.Add(file)
                create_newpdf(file, "", "", False)
            End If
        Next
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        ListboxSelect_pdfload()
    End Sub
    Sub ListboxSelect_pdfload()
        Try
            If ListBox1.Items.Count > 0 Then
                Dim file As String = ListBox1.SelectedItem
                If AxAcroPDF1.src = "file://" & file Then Exit Sub
                AxAcroPDF1.src = file
                ItemsCountOfLB()
            Else
                AxAcroPDF1.LoadFile("DONTEXISTS.pdf")

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ОткрытьToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripMenuItem1.Click
        addInListBox()
    End Sub
    Sub addInListBox()
        Dim file As String = OpenFilePDF()
        If file IsNot Nothing Then
            ListBox1.Items.Add(file)
            create_newpdf(file, "", "", False)
        End If
    End Sub
    Public Function OpenFilePDF()
        Dim file As String
        Dim openFileDialog1 As New OpenFileDialog()


        'openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "PDF files (*.PDF)|*.PDF|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                file = (openFileDialog1.FileName)
            Catch Ex As Exception
                MessageBox.Show("Не удается открыть файл. Код ошибки: " & Ex.Message)
            End Try
        End If

        Return file
    End Function

    Private Sub ОчиститьСписокToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОчиститьСписокToolStripMenuItem.Click
        ListBox1.Items.Clear()
        AxAcroPDF1.LoadFile("DONTEXISTS.pdf")
        ItemsCountOfLB()
    End Sub
    Sub filedelOfCatalog(filename As String)
        Try
            If File.Exists(filename) Then
                File.Delete(filename)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub УдалитьВыделенноеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УдалитьВыделенноеToolStripMenuItem.Click
        If AxAcroPDF1.src = "file://" & ListBox1.SelectedItem Then
            AxAcroPDF1.LoadFile("DONTEXISTS.pdf")
        End If
        If CBool(Option_app.fileDel) Then filedelOfCatalog(ListBox1.SelectedItem)
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        ItemsCountOfLB()
    End Sub

    Private Sub ОткрытьФайлToolStripMenuItem_Click(sender As Object, e As EventArgs)
        addInListBox()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Option_app.ShowDialog()
    End Sub

    Private Sub СохранитьToolStripButton_Click(sender As Object, e As EventArgs)
        MessageBox.Show(System.Security.Principal.WindowsIdentity.GetCurrent().NameClaimType.ToString)
    End Sub

    Private Sub НастройкиToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles НастройкиToolStripMenuItem1.Click
        Option_app.ShowDialog()
    End Sub

    Private Sub ОПрограммеToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОПрограммеToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        info()
    End Sub
    Sub info()
        Process.Start("http://www.evernote.com/l/AjLtH20f7CZNKrtJCzwTCNoZmMFAxTXoxQQ/")
    End Sub

    Private Sub ДокументИзS4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДокументИзS4ToolStripMenuItem.Click
        doc_of_S4()
    End Sub

    Sub doc_of_S4()
        With ITS4App
            Dim DocID As Integer
            Dim sellitems As S4.TS4SelectedItems = .GetSelectedItems
            While sellitems.NextSelected <> 0
                DocID = .GetSelectedItems.ActiveDocID
                print_doc(DocID)
                sellitems.InvertCurrent()
            End While
        End With
    End Sub
    Sub print_doc(DocID As Integer)
        Try
            Dim VerDocID, Doctype As Integer
            Dim OTDREGNUM, OTD_reg, filename, print_filename As String
            With ITS4App
                .OpenDocument(DocID)
                filename = .GetFieldValue("filename")
                Doctype = .GetDocType
                If Doctype = 1 Then
                    print_filename = default_folder_parh & "\" & filename & ".pdf"
                Else
                    print_filename = default_folder_parh & "\" & filename
                End If


                If LCase(System.IO.Path.GetExtension(print_filename)) <> ".pdf" And LCase(System.IO.Path.GetExtension(print_filename)) <> ".tif" Then
                    MsgBox("Расширение файла " & filename & " не ' " & LCase(System.IO.Path.GetExtension(print_filename)) & "'")
                    ListBox2.Items.Add("Расширение файла " & filename & " не ' " & LCase(System.IO.Path.GetExtension(print_filename)) & "'")
                    Exit Sub
                End If
                VerDocID = .GetFieldValue("Version_ID")
                .OpenDocVersion(DocID, VerDocID)
                OTDREGNUM = .GetFieldValue_DocVersion("OTDREGNUM")
                OTD_reg = .GetFieldValue_DocVersion("OTD_reg")
                existfilekill(print_filename)
                .CopyToDir(default_folder_parh)
                If LCase(System.IO.Path.GetExtension(print_filename)) = ".tif" Then
                    create_newpdfwithTiff(print_filename, OTDREGNUM, OTD_reg)
                    'print_filename = print_filename.Substring(0, print_filename.LastIndexOf(".")) & ".pdf"
                Else
                    create_newpdf(print_filename, OTDREGNUM, OTD_reg, False)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            ListBox2.Items.Add(ex.Message)
        End Try
    End Sub
    Sub existfilekill(print_filename As String)
        If File.Exists(print_filename) Then
            File.Delete(print_filename)
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Try
            ITS4App = CreateObject("S4.TS4App")
            ITS4App.Login()
            S4Username = ITS4App.GetUserLoginName_ByUserID(ITS4App.GetUserID)
            ToolStripLabel1.Text = S4Username
        Catch ex As Exception

        End Try
        tempform = Me
        'Chek_licenc()
    End Sub

    Private Sub SpaseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        RussWord("ОБ ИЗМЕНЕНИИ")
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If ListBox1.Items.Count = 0 Then
            ContextMenuStrip1.Enabled = False
        Else
            ContextMenuStrip1.Enabled = True
        End If
    End Sub
    Sub CopyPDF(inputFile As String)
        Dim document As Document = New Document

        Dim writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(inputFile, FileMode.Create))
        document.Open()
        'Dim table As PdfPTable = New PdfPTable(2)
        Dim reader As PdfReader = New PdfReader(2)
        Dim n As Integer = reader.NumberOfPages
        Dim page As PdfImportedPage
        For i As Integer = 1 To n
            page = writer.GetImportedPage(reader, i)
        Next
        document.Close()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.Control And e.Shift And e.KeyCode.ToString = "L" Then
                licCFG()
            End If
            If e.KeyCode = Keys.W Then
                ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
            ElseIf e.KeyCode = Keys.S Then
                ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ВыгрузитьКДToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыгрузитьКДToolStripMenuItem.Click
        docum_of_Sostav()
    End Sub
    Sub docum_of_Sostav()
        Try
            'Dim SampleID As Integer = 1729 'параметр в настройку
            With ITS4App
                Dim progId As Integer
                .StartSelectDocs()
                .SelectDocsEx2(-5, 1)
                If .SelectedDocsCount = 0 Then
                    Exit Sub
                End If
                progId = .GetSelectedDocID(0)
                .EndSelectDocs()
                'cmd = str_ArdID & progId & separator & "Выбран объект"
                'report_in_LB_checkingSOSTAV(cmd)
                If progId <= 0 Then Exit Sub
                Try
                    print_doc(progId)
                Catch ex As Exception
                    MsgBox("Ошибка при печати выбранного документа" & vbNewLine & ex.Message)
                    ListBox2.Items.Add(ex.Message)
                End Try
                '.GetSelectedArticleID()
                .OpenArticleStructureExpanded(.GetArtID_ByDocID(progId))
                .asFirst()
                While .asEof = 0
                    Dim tmp_artID As Integer = .asGetArtID
                    Try
                        Dim tmp_DocID As Integer = .GetDocID_ByArtID(tmp_artID)
                        If tmp_DocID > 0 Then
                            print_doc(tmp_DocID)
                        End If
                    Catch ex As Exception
                        MsgBox("Ошибка при печати выбранного документа" & vbNewLine & ex.Message)
                        ListBox2.Items.Add(ex.Message)
                    End Try
                    .asNext()
                End While
            End With
            MsgBox("Выгрузка КД по выбранному объекту " & "Завершена")
        Catch ex As Exception
            MsgBox(ex.Message)
            ListBox2.Items.Add(ex.Message)
        End Try
    End Sub
    Public Sub CopyToDirProc(tmp_artID As Integer, Copy_directory As String)
        Try
            With ITS4App
                Dim tmp_Doc_ID As Integer = .GetDocID_ByArtID(tmp_artID)
                If tmp_Doc_ID > 0 Then
                    .OpenDocument(tmp_Doc_ID)
                    .CopyToDir(Copy_directory)
                    .CloseDocument()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub WhatsNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhatsNewToolStripMenuItem.Click
        Process.Start("http://www.evernote.com/l/AjLv2-jBdLhI0rpCZlDWGE0gfQ9E89wMWsg/")
    End Sub

    Private Sub ОчиститьЗаписьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОчиститьЗаписьToolStripMenuItem.Click
        ListBox2.Items.Clear()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListboxSelect_pdfload()
    End Sub
    Public Sub addInLB(addtext As String)
        If Not ListBox1.Items.Contains(addtext) Then
            ListBox1.Items.Add(addtext)
            ItemsCountOfLB()
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        doc_of_S4()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        docum_of_Sostav()
    End Sub

    Private Sub ОткрытьПапкуСЧертежамиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьПапкуСЧертежамиToolStripMenuItem.Click
        openSaveFolder()
    End Sub
    Sub openSaveFolder()
        Process.Start(default_folder_parh)
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        openSaveFolder()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        info()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        UpStepInLB()
    End Sub
    Sub UpStepInLB()
        Try
            ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
        Catch ex As Exception

        End Try
    End Sub
    Sub DownStepLB()
        Try
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        DownStepLB()
    End Sub

    Private Sub НаШагВверхToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НаШагВверхToolStripMenuItem.Click
        UpStepInLB()
    End Sub

    Private Sub НаШагВнизToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НаШагВнизToolStripMenuItem.Click
        DownStepLB()
    End Sub

    Private Sub ВНачалоСпискаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВНачалоСпискаToolStripMenuItem.Click
        stepVertex()
    End Sub
    Sub stepVertex()
        Try
            ListBox1.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub
    Sub stepbottom()
        Try
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ВКонецСпискаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВКонецСпискаToolStripMenuItem.Click
        stepbottom()
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        stepVertex()
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        stepbottom()
    End Sub

    Sub ItemsCountOfLB()
        ToolStripLabel2.Text = ListBox1.SelectedIndex + 1 & "/" & ListBox1.Items.Count
    End Sub

    Private Sub НавигацияToolStripMenuItem1_CheckedChanged(sender As Object, e As EventArgs) Handles НавигацияToolStripMenuItem1.CheckedChanged
        Try
            If НавигацияToolStripMenuItem1.Checked Then
                ToolStrip2.Enabled = True
            Else
                ToolStrip2.Enabled = False
            End If
        Catch ex As Exception

        End Try
        If НавигацияToolStripMenuItem1.Checked Then
            'ToolStrip2.Enabled = True
            ToolStrip2.Visible = True
        Else
            'ToolStrip2.Enabled = False
            ToolStrip2.Visible = False
        End If
    End Sub

    Private Sub ИнструментыToolStripMenuItem_CheckedChanged(sender As Object, e As EventArgs) Handles ИнструментыToolStripMenuItem.CheckedChanged
        Try
            If ИнструментыToolStripMenuItem.Checked Then
                'ToolStrip1.Enabled = True
                ToolStrip1.Visible = True
            Else
                'ToolStrip1.Enabled = False
                ToolStrip1.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub НавигацияToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles НавигацияToolStripMenuItem1.Click
        Try
            НавигацияToolStripMenuItem1.Checked = Not (НавигацияToolStripMenuItem1.Checked)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ИнструментыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ИнструментыToolStripMenuItem.Click
        Try
            ИнструментыToolStripMenuItem.Checked = Not (ИнструментыToolStripMenuItem.Checked)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ПечатьToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim pdffile As AxAcroPDFLib.AxAcroPDF = New AxAcroPDFLib.AxAcroPDF
        pdffile.Parent = Me
        pdffile.LoadFile(ListBox1.Items.Item(0))
        'pdffile.pr
        pdffile.printAll()


    End Sub
    Dim Razrab_S As String = "Разработал"
    Dim Prov_S As String = "Проверил"
    Dim Ncontr_S As String = "Н.контр."
    Dim Tcontr_S As String = "Т.контр."
    Dim Utv_S As String = "Утвердил"
    Dim Arch_S As String = "Архивариус"

    Dim UtvTD_RC As String = "2"
    Dim UtvKD_RC As String = "G"
    Dim NContr_RC As String = "4"
    Dim TContr_RC As String = "5"
    Dim Razrab_RC As String = "7"
    Dim ProvKD_RC As String = "="

    Dim Arch_RC As String = ")"
    Dim Glav_Tech_RC As String = ";"
    Dim GlavnSvar_RC As String = "<"

    Private Sub ПодписиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПодписиToolStripMenuItem.Click
        'Dim SGN As Object = SGN_INFO(InputBox("DocID"))
        CDS_test(InputBox("DocID"))
    End Sub
    Sub CDS_test(DocID As Integer)
        Dim data As Object
        Dim CDS = CreateObject("CDSAutomation.CDSAutoObject")
        With ITS4App
            CDS = .GetSignesInfo(DocID, 0, "G", 0)
            CDS.FieldByName("DESIGNATIO")
        End With
    End Sub
    Function SGN_INFO(Doc_ID As Integer) As Object
        Dim SGN_ARR_RANCODE() As String = {Razrab_S, Prov_S, Ncontr_S, Tcontr_S, Utv_S}
        Dim SGN_ARR(4, 2) As Object
        Try
            With ITS4App
                .OpenDocument(Doc_ID)
                Dim ActVers As Integer = .GetDocActualVersionID

                For j As Integer = 0 To UBound(SGN_ARR_RANCODE)
                    Dim tmp_SGN_RANCODE As String = SGN_ARR_RANCODE(j)
                    Dim USER_SIGN_NAME As String = .GetFieldValue(tmp_SGN_RANCODE)
                    If USER_SIGN_NAME <> "" Or USER_SIGN_NAME IsNot Nothing Then
                        Dim SIHN_DATE As String = SIGN_DATE(Doc_ID, USER_SIGN_NAME, tmp_SGN_RANCODE, ActVers)
                        SGN_ARR(j, 0) = tmp_SGN_RANCODE
                        SGN_ARR(j, 1) = USER_SIGN_NAME
                        SGN_ARR(j, 2) = SIHN_DATE
                    End If
                Next
                .CloseDocument()
                Return SGN_ARR
            End With
        Catch ex As Exception
            MsgBox("ОШИБКА в фунцкии SGN_INFO" & vbCr & ex.Message)
        End Try
    End Function
    Function SIGN_DATE(DocID As String, SignName As String, SIGN_LABEL As String, actualVers As String) As String
        Try
            With ITS4App
                Dim user_ID As String = GetUserIDBySignName(SignName)
                Dim SGN_AS() As String = Get_RANK_CODE_BY_SIGN_LABEL(DocID, SIGN_LABEL)
                For i As Integer = 0 To UBound(SGN_AS)
                    .OpenQuery("select * 
                        from signlist 
                        where docsgn_id = " & DocID &
                            "and usersgn_id = " & user_ID &
                            "and sign_as = '" & SGN_AS(i) &
                            "' and old = '0' 
                        and VERSION_ID = " & actualVers)
                    .QueryGoFirst()
                    Dim SGN_DATE As String = .QueryFieldByName("SIGN_DATE")
                    .CloseQuery()
                    If SGN_DATE IsNot Nothing Or SGN_DATE <> "" Then
                        Dim SIGN_DATEASDAte As Date = Convert.ToDateTime(SGN_DATE).ToShortDateString
                        Return SIGN_DATEASDAte
                    End If
                Next
            End With
        Catch ex As Exception
            MsgBox("ОШИБКА в фунцкии SIGN_DATE" & vbCr & ex.Message)
        End Try
    End Function
    Function Get_RANK_CODE_BY_SIGN_LABEL(DocID As String, SIGN_LABEL As String) As Array
        Try
            With ITS4App
                .OpenQuery("select * 
                        from Ranklist
                        where SIGN_LABEL= '" & SIGN_LABEL & "'")
                Dim RANK_CODE_LIST(.QueryRecordCount - 1) As String

                .QueryGoFirst()
                For i As Integer = 0 To .QueryRecordCount - 1
                    RANK_CODE_LIST(i) = .QueryFieldByName("RANK_CODE")
                    .QueryGoNext()
                Next
                .CloseQuery()
                Return RANK_CODE_LIST
            End With
        Catch ex As Exception
            MsgBox("ОШИБКА в фунцкии Get_RANK_CODE_BY_SIGN_LABEL" & vbCr & ex.Message)
        End Try
    End Function
    Function GetUserIDBySignName(SignName As String) As String
        With ITS4App
            .OpenQuery("select * 
                        from users
                        where signname = '" & SignName & "'")
            Dim UserID As String = .QueryFieldByName("User_ID")
            .CloseQuery()
            If UserID IsNot Nothing Or UserID <> "" Then
                Return UserID
            End If
        End With
    End Function
End Class
