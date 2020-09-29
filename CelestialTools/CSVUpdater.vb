Public Class CSVUpdater
    Public FName As String = "./IDStore.csv"
    Dim ReadError As Boolean = False
    Dim FileLoading As Boolean = False
    Dim SLOpenFName As String = ""
    Dim tablename As String = "Export"
    Dim DataSet1 As DataSet

    Private Sub FormSRF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataSet1 = New DataSet()
        Me.Show()
        Me.Refresh()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        SaveDataGrid()
        Me.Close()
    End Sub
    Public Sub SaveDataGrid()
        Dim textstr As New System.Text.StringBuilder()
        For x As Integer = 0 To DataGridView1.Rows.Count - 1
            If IsNothing(DataGridView1.Rows(x).Cells(0).Value) = False Then
                For v As Integer = 0 To DataGridView1.Columns.Count - 1
                    'extracting cell value from 0 to 9 and add it on list
                    If v > 0 Then
                        textstr.Append(",")
                    End If
                    Dim tempstr As String = DataGridView1.Rows(x).Cells(v).Value.ToString()
                    tempstr = tempstr.Replace(",", "") ' remove any commas input into any field so csv file is not corrupted
                    textstr.Append(tempstr)
                Next
            End If
            'adding new line to text
            textstr.AppendLine()
        Next
        IO.File.WriteAllText(FName, textstr.ToString())

        Exit Sub
    End Sub

    Private Sub btnExitNoSave_Click(sender As Object, e As EventArgs) Handles btnExitNoSave.Click
        Me.Close()
        Exit Sub
    End Sub

    Private Sub btnOpenCSV_Click(sender As Object, e As EventArgs) Handles btnOpenCSV.Click
        Dim myStream As System.IO.StreamReader = Nothing
        Dim openFileDialog1 As New OpenFileDialog()

        If DataSet1.DataSetName = tablename Then
            DataSet1.Dispose()
            DataSet1 = New DataSet()
            DataGridView1.DataSource = vbNull
        End If
        DataSet1.Tables.Add(tablename)
        DataSet1.DataSetName = tablename
        DataGridView1.DataSource = DataSet1

        openFileDialog1.InitialDirectory = "./"
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv"
        openFileDialog1.Title = "Open CSV Text File"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If openFileDialog1.FileName = vbNullString Then
                Exit Sub
            End If
            ReadError = False
            FileLoading = True
            Dim ReadNum As Integer = 0
            Try
                myStream = New System.IO.StreamReader(openFileDialog1.FileName)
                If (myStream IsNot Nothing) Then
                    SLOpenFName = openFileDialog1.FileName
                    lblOpenFN.Visible = True
                    txtOpenFN.Visible = True
                    txtOpenFN.Text = SLOpenFName
                    Dim allData As String = myStream.ReadToEnd()
                    Dim rows As String() = allData.Split(vbCrLf) '("\r".ToCharArray())
                    Dim incr1 As Integer = 0
                    For Each r As String In rows
                        r = r.Trim(vbLf).Trim
                        If ReadNum = 0 Then
                            r = r.Trim(vbLf).Trim
                            Dim items As String() = r.Split(",")
                            For ctr As Integer = 0 To UBound(items)
                                DataSet1.Tables(tablename).Columns.Add(items(ctr))
                            Next
                        Else
                            r = r.Trim(vbLf).Trim
                            Dim items1 As String() = r.Split(",")
                            If items1(0) <> vbNullString And items1(0) <> Nothing Then
                                DataSet1.Tables(tablename).Rows.Add(items1)
                            End If

                        End If
                        ReadNum += 1
                        incr1 += 1
                    Next
                    myStream.Close()
                    btnSaveFile.Visible = True
                    btnExit.Visible = True
                End If

                myStream.Dispose()
                DataGridView1.DataSource = DataSet1.Tables(0).DefaultView
                DataGridView1.Refresh()
                FileLoading = False
                Me.Refresh()

            Catch Ex As Exception
                ErrorMsgBox("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        Else
            btnSaveFile.Visible = False
            btnExit.Visible = False

        End If

    End Sub
    Private Sub ErrorMsgBox(ByVal ErrMsg As String)
        System.Windows.Forms.MessageBox.Show(ErrMsg, "Error",
                                                System.Windows.Forms.MessageBoxButtons.OK,
                                                System.Windows.Forms.MessageBoxIcon.Error,
                                                System.Windows.Forms.MessageBoxDefaultButton.Button1,
                                                System.Windows.Forms.MessageBoxOptions.DefaultDesktopOnly)
        Exit Sub
    End Sub

    Private Sub btnSaveFile_Click(sender As Object, e As EventArgs) Handles btnSaveFile.Click
        SaveDataGrid()
        Exit Sub
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnInfoForm_Click(sender As Object, e As EventArgs) Handles btnInfoForm.Click
        CSVUpdaterInfo.Show()
        Exit Sub
    End Sub
End Class
