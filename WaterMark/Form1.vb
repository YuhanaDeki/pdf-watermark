Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.Pdf.Parsing
Imports System.Drawing


Public Class Form1


    Public Sub Test()
        Try


            Dim itemAdd As Integer = cb_itemNumber.Text

            For i As Integer = 1 To itemAdd
                'Load the document
                Dim loadedDocument As New PdfLoadedDocument(Label1.Text)
                'Set font size
                Dim fontSize As Integer = cb_fontSize.Text
                'Set title
                Dim title As String = txt_title.Text
                'Set opacity
                Dim title_opacity As Double = cb_opacity.Text
                'Set angle
                Dim angle As Double = txt_angle.Text

                'Set the font
                Dim font As New PdfTrueTypeFont(New Font("TH SarabunPSK", fontSize), True)

                For Each page In loadedDocument.Pages
                    'Get the loaded page
                    Dim loadedPage As PdfLoadedPage = TryCast(page, PdfLoadedPage)

                    Dim title_x As Single = txt_title_x.Text
                    Dim title_y As Single = txt_title_y.Text

                    Dim item_x As Single = txt_item_x.Text
                    Dim item_y As Single = txt_item_y.Text

                    'Create graphics 
                    Dim graphics As PdfGraphics = loadedPage.Graphics
                    Dim state As PdfGraphicsState = graphics.Save()

                    graphics.SetTransparency(title_opacity)
                    graphics.RotateTransform(angle)
                    'Draw watermark text
                    'New PointF(-150, 450)
                    graphics.DrawString(title & " " & Convert.ToInt32(i) & " " & txt_from.Text & " " & itemAdd & " " & TextBox5.Text, font, PdfPens.Red, PdfBrushes.Red, New PointF(title_x, title_y))
                    '      graphics.DrawString("", font, PdfPens.Red, PdfBrushes.Red, New PointF(item_x, item_y))

                    graphics.Restore()
                Next
                'Save and close the document
                loadedDocument.Save(lb_fileName.Text & Convert.ToInt32(i) & ".pdf")
                loadedDocument.Close(True)
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Test()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim result As DialogResult = OpenFileDialog1.ShowDialog()
            Dim pathName As String
            Dim fileName As String

            If result = DialogResult.OK Then
                'Path location file PDF
                pathName = OpenFileDialog1.FileName
                fileName = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
                Label1.Text = pathName
                lb_fileName.Text = fileName.Remove((fileName.Length - 4), 4)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
