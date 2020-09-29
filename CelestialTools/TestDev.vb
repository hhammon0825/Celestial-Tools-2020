Public Class TestDev
    Private Sub btnCompassDev_Click(sender As Object, e As EventArgs) Handles btnCompassDev.Click
        txtCompassDev.Clear()
        Dim RtnRec As DevForm.DeviationRec = DevForm.DevInterpolateCompass(Convert.ToInt32(UpDwnCompass.Value))
        txtCompassDev.Text = "Compass:" & RtnRec.TblCompass.ToString("000") & Chr(176) & " Magnetic:" & RtnRec.TblMagnetic.ToString("000") &
            Chr(176) & " Dev:" & RtnRec.TblDev.ToString("#0") & RtnRec.TblDevEW
        Exit Sub
    End Sub

    Private Sub btnMagDev_Click(sender As Object, e As EventArgs) Handles btnMagDev.Click
        txtMagDev.Clear()
        Dim RtnRec As DevForm.DeviationRec = DevForm.DevInterpolateMagnetic(Convert.ToInt32(UpDwnMag.Value))
        txtMagDev.Text = "Compass:" & RtnRec.TblCompass.ToString("000") & Chr(176) & " Magnetic:" & RtnRec.TblMagnetic.ToString("000") &
            Chr(176) & " Dev:" & RtnRec.TblDev.ToString("#0") & RtnRec.TblDevEW
        Exit Sub
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Exit Sub
    End Sub
End Class