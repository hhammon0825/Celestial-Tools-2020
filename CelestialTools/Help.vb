Option Strict Off
Option Explicit On
Friend Class Form6
	Inherits System.Windows.Forms.Form

    Private Sub cmdHelpArcTime_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpArcTime.Click
        txtHelpArcTime.BringToFront()
    End Sub

    Private Sub cmdHelpAveraging_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpAveraging.Click
        txtHelpAveraging.BringToFront()
    End Sub
	
	Private Sub cmdHelpCurrents_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpCurrents.Click
        txtHelpCurrents.BringToFront()
    End Sub
	
	Private Sub cmdHelpFavorites_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpFavorites.Click
        txtHelpFavorites.BringToFront()
    End Sub
	
	Private Sub cmdHelpGeneral_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpGeneral.Click
        txtHelpGeneral.BringToFront()
    End Sub
	
	Private Sub cmdHelpLength_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpLength.Click
        txtHelpLength.BringToFront()
    End Sub
	
	Private Sub cmdHelpLoCNASR_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpLoCNASR.Click
        txtHelpLoCNASR.BringToFront()
    End Sub
	
	Private Sub cmdHelpNoon_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpNoon.Click
        txtHelpNoon.BringToFront()
    End Sub
	
	Private Sub cmdHelpPlan_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpPlan.Click
        txtHelpPlan.BringToFront()
    End Sub
	
	Private Sub cmdHelpSRF_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpSRF.Click
        txtHelpSRF.BringToFront()
    End Sub
	Private Sub cmdHelpSailings_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpSailings.Click
        txtHelpSailings.BringToFront()
    End Sub
	Private Sub cmdHelpCTS_SOA_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpCTS_SOA.Click
        txtHelpCTS_SOA.BringToFront()
    End Sub
	Private Sub cmdHelpDistances_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpDistances.Click
        txtHelpDistances.BringToFront()
    End Sub
	
	Private Sub cmdHelpInterpolate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpInterpolate.Click
        txtHelpInterpolate.BringToFront()
    End Sub
	Private Sub cmdHelp60DST_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelp60DST.Click
        txtHelp60DST.BringToFront()
    End Sub
	Private Sub cmdHelpTides_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpTides.Click
        txtHelpTides.BringToFront()
    End Sub
	Private Sub cmdHelpTVMDC_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpTVMDC.Click
        txtHelpTVMDC.BringToFront()
    End Sub
	
	Private Sub cmdHelpTwoBearings_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpTwoBearings.Click
        txtHelpTwoBearings.BringToFront()
    End Sub
	
	Private Sub cmdHelpYellow_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpYellow.Click
        txtHelpYellow.BringToFront()
    End Sub
	Private Sub cmdHelpMoBoard_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelpMoBoard.Click
        txtHelpMoBoard.BringToFront()
    End Sub

    Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
        'frmPrintHelp.Show()
    End Sub

    Private Sub Form6_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		cmdHelpGeneral_Click(cmdHelpGeneral, New System.EventArgs())
	End Sub
	
	Private Sub Form6_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cleanup()
    End Sub
End Class