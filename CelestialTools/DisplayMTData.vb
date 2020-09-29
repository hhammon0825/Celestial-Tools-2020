Public Class DisplayMTData
    Private Sub DisplayMTData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FName As String = "./Graphics/MeridianTransitData.csv"
        Dim tablename As String = "Export2"

        Dim SR As System.IO.StreamReader = New System.IO.StreamReader(FName)
        Dim allData As String = SR.ReadToEnd()
        Dim rows As String() = allData.Split(vbCrLf) '("\r".ToCharArray())
        Dim incr1 As Integer = 0
        For Each r As String In rows
            If incr1 > 0 Then
                Dim items As String() = r.Split(",")
                If items(0) <> vbLf Then
                    Dim DT As Date = Convert.ToDateTime(items(2))

                    items(0) = CnvtToDeg(items(0).ToString)
                    items(1) = CnvtToDeg(items(1).ToString)
                    items(3) = CnvtTime(items(3).ToString)
                    items(4) = CnvtEQT(items(4).ToString)
                    items(5) = CnvtDec(items(5).ToString)
                    'items(6) = CnvtHo(items(6).ToString)
                    DataSet2.Tables(tablename).Rows.Add(items)

                End If
            End If
            incr1 += 1
        Next
        'DataGridView1.DataSource = DataSet2.Tables(0).DefaultView
        DataGridView1.Refresh()
        SR.Close()
        SR.Dispose()

        Me.Refresh()
        'DisplayAnalema()
        Exit Sub
    End Sub
    Private Function CnvtToDeg(ByVal StrIn) As String
        Dim NSEW As String = StrIn.ToString.Substring(StrIn.ToString.Length - 1, 1)
        Dim Str2 As String = StrIn.ToString.Substring(0, StrIn.ToString.Length - 1) ' remove N/S on Lat and E/W on Long as last character
        Dim Tmp As Double = Convert.ToDouble(Str2)
        Dim TmpDeg As Integer = Int(Tmp)
        Dim TmpMin As Double = (Tmp - TmpDeg) * 60
        Return TmpDeg.ToString("##0") & Chr(176) & " " & TmpMin.ToString("#0.0") & "'" & NSEW.ToString
    End Function
    Private Function CnvtEQT(ByVal StrIn) As String
        Dim EqtSpeed As String = ""
        If StrIn.ToString.Substring(0, 1) = "-" Then
            EqtSpeed = " Slow"
        Else
            EqtSpeed = " Fast"
        End If
        Dim Str2 As String = StrIn.ToString.TrimStart("-")
        Dim Tmp As Double = Convert.ToDouble(Str2)
        Dim TmpDeg As Integer = Int(Tmp)
        Dim TmpMin As Double = (Tmp - TmpDeg) * 60
        Return TmpDeg.ToString("00") & ":" & TmpMin.ToString("00") & EqtSpeed
    End Function
    Private Function CnvtDec(ByVal StrIn) As String
        Dim NSEW As String = ""
        If StrIn.ToString.Substring(0, 1) = "-" Then
            NSEW = " S"
        Else
            NSEW = " N"
        End If
        Dim Str2 As String = StrIn.ToString.TrimStart("-")
        Dim Tmp As Double = Convert.ToDouble(Str2)
        Dim TmpDeg As Integer = Int(Tmp)
        Dim TmpMin As Double = (Tmp - TmpDeg) * 60
        Return TmpDeg.ToString("##0") & Chr(176) & " " & TmpMin.ToString("#0.0") & "'" & NSEW.ToString
    End Function
    Private Function CnvtHo(ByVal StrIn) As String
        Dim Str2 As String = StrIn.ToString
        Dim Tmp As Double = Convert.ToDouble(Str2)
        Dim TmpDeg As Integer = Int(Tmp)
        Dim TmpMin As Double = (Tmp - TmpDeg) * 60
        Return TmpDeg.ToString("##0") & Chr(176) & " " & TmpMin.ToString("#0.0") & "'"
    End Function
    Private Function CnvtTime(ByVal StrIn) As String
        Return StrIn.ToString.Substring(0, 2) & ":" & StrIn.ToString.Substring(2, 2) & ":" & StrIn.ToString.Substring(4, 2)
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class