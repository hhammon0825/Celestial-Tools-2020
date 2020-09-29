Option Strict Off
Option Explicit On
Imports System.Text.RegularExpressions
Imports System.Windows
Imports System.Windows.Input

Module Print_Renamed
    Private WithEvents PrtDoc As PrintDocument
    Private WithEvents PrtDocTxt As PrintDocument
    Private PrtFileName As String = "./PrtScn.jpg"
    Private printFont As Font
    Private streamToPrint As System.IO.StreamReader
    Private PrintDialog1 As PrintDialog
    Private StreamSize As Integer = 0
    Public Sub PrintScreen(ByVal FileName As String)
        PrintDialog1 = New PrintDialog()
        PrintDialog1.UseEXDialog = True
        PrintDialog1.AllowPrintToFile = False
        PrintDialog1.AllowCurrentPage = False
        PrintDialog1.AllowSelection = False
        PrintDialog1.AllowSomePages = False
        PrtDoc = New PrintDocument()
        AddHandler PrtDoc.PrintPage, AddressOf PrtDoc_PrintPage

        Dim capture As System.Drawing.Bitmap
        Dim graph As Graphics
        capture = Image.FromFile(FileName)
        graph = Graphics.FromImage(capture)
        If My.Computer.FileSystem.FileExists(PrtFileName) Then
            My.Computer.FileSystem.DeleteFile(PrtFileName)
        End If
        capture.Save(PrtFileName)
        PrtDoc.DocumentName = PrtFileName
        PrintDialog1.Document = PrtDoc
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrtDoc.Print()
        End If
        capture.Dispose()
        PrintDialog1.Dispose()
        PrtDoc.Dispose()
        Exit Sub
    End Sub
    Public Sub PrintScreen(ByVal ScrBounds As Rect)
        PrintDialog1 = New PrintDialog()
        PrintDialog1.UseEXDialog = True
        PrintDialog1.AllowPrintToFile = False
        PrintDialog1.AllowCurrentPage = False
        PrintDialog1.AllowSelection = False
        PrintDialog1.AllowSomePages = False
        PrtDoc = New PrintDocument()
        AddHandler PrtDoc.PrintPage, AddressOf PrtDoc_PrintPage

        Dim area As Rect = ScrBounds
        Dim capture As System.Drawing.Bitmap
        Dim graph As Graphics
        'area = ScrBounds
        capture = New System.Drawing.Bitmap(area.Width, area.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(capture)
        graph.CopyFromScreen(area.X, area.Y, 0, 0, New Drawing.Size(area.Width, area.Height), CopyPixelOperation.SourceCopy)
        If My.Computer.FileSystem.FileExists(PrtFileName) Then
            My.Computer.FileSystem.DeleteFile(PrtFileName)
        End If
        capture.Save(PrtFileName)
        PrtDoc.DocumentName = PrtFileName
        PrintDialog1.Document = PrtDoc
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrtDoc.Print()
        End If
        capture.Dispose()
        PrintDialog1.Dispose()
        PrtDoc.Dispose()
        Exit Sub
    End Sub
    Public Sub PrintScreen(ByVal ScrBounds As Rectangle)
        PrintDialog1 = New PrintDialog()
        PrintDialog1.UseEXDialog = True
        PrintDialog1.AllowPrintToFile = False
        PrintDialog1.AllowCurrentPage = False
        PrintDialog1.AllowSelection = False
        PrintDialog1.AllowSomePages = False
        PrtDoc = New PrintDocument()
        AddHandler PrtDoc.PrintPage, AddressOf PrtDoc_PrintPage

        'Dim area As Rectangle
        Dim capture As System.Drawing.Bitmap
        Dim graph As Graphics
        'area = ScrBounds
        capture = New System.Drawing.Bitmap(ScrBounds.Width, ScrBounds.Height) ' System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(capture)
        graph.Clip = New Region(ScrBounds)
        graph.CopyFromScreen(ScrBounds.X, ScrBounds.Y, 0, 0, ScrBounds.Size) ' CopyPixelOperation.SourceCopy)

        If My.Computer.FileSystem.FileExists(PrtFileName) Then
            My.Computer.FileSystem.DeleteFile(PrtFileName)
        End If
        capture.Save(PrtFileName)
        PrtDoc.DocumentName = PrtFileName
        PrintDialog1.Document = PrtDoc
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrtDoc.Print()
        End If
        graph.Dispose()
        capture.Dispose()
        PrintDialog1.Dispose()
        PrtDoc.Dispose()
        Exit Sub
    End Sub
    Private Sub PrtDoc_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrtDoc.PrintPage

        Dim img As Image = Image.FromFile(PrtFileName)
        e.Graphics.DrawImage(img, 0, 0)
        img.Dispose()
        Exit Sub
    End Sub

    Public Sub printTxtFile1(FName As String)
        PrintDialog1 = New PrintDialog()
        PrintDialog1.UseEXDialog = True
        PrintDialog1.AllowPrintToFile = False
        PrintDialog1.AllowCurrentPage = False
        PrintDialog1.AllowSelection = False
        PrintDialog1.AllowSomePages = False

        printFont = New Font("Arial", 10)
        Dim pd As New PrintDocument()
        AddHandler pd.PrintPage, AddressOf pd_PrintPage
        pd.DocumentName = FName
        PrintDialog1.Document = pd

        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            Try
                streamToPrint = New IO.StreamReader(FName)
                Try
                    'printFont = New Font("Arial", 10)
                    'Dim pd As New PrintDocument()
                    'AddHandler pd.PrintPage, AddressOf pd_PrintPage
                    pd.Print()
                Finally
                    streamToPrint.Close()
                End Try
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        PrintDialog1.Dispose()
        pd.Dispose()

        Exit Sub
    End Sub

    ' The PrintPage event is raised for each page to be printed.
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim count As Integer = 0
        Dim leftMargin As Single = ev.MarginBounds.Left
        Dim topMargin As Single = ev.MarginBounds.Top
        Dim line As String = Nothing

        ' Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics)

        ' Print each line of the file.
        While count < linesPerPage
            line = streamToPrint.ReadLine()
            If line Is Nothing Then
                Exit While
            End If
            yPos = topMargin + count * printFont.GetHeight(ev.Graphics)
            ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, New StringFormat())
            count += 1
        End While

        ' If more lines exist, print another page.
        If (line IsNot Nothing) Then
            ev.HasMorePages = True
        Else
            ev.HasMorePages = False
        End If
    End Sub

End Module