Option Strict Off
Option Explicit On
Friend Class MainMenu
    Inherits System.Windows.Forms.Form

    Public ReadOnly latTemplate As String = "90º60.00'N"
    Public ReadOnly lonTemplate As String = "180º60.00'E"
    Public ReadOnly speedTemplate As String = "00.0kts"
    Public ReadOnly rangeTemplate As String = "00.000nm"
    Public ReadOnly rangeTemplateYds As String = "00000yds"
    Public ReadOnly rangeTemplateMtrs As String = "00000m"
    Public ReadOnly bearingTemplate As String = "360º"
    Public ReadOnly inclinationTemplate As String = "00.0ºE"
    Public ReadOnly timeTemplate As String = "000.0min"
    Public ReadOnly minutesTemplate As String = "00min"
    Public ReadOnly timeOfDayTemplate As String = "13:60:60.0AM"
    Public ReadOnly shortTimeOfDayTemplate As String = "13:60:60AM"
    Public ReadOnly timeOfDayTemplate24 As String = "24:60:60.0"
    Public ReadOnly shortTimeOfDayTemplate24 As String = "24:60:60"

    ' These are the shared variables between FormSRF SRF and FormAltSR SR methods and Meridian form
    Public FormSRFFlagSRFLocNASR As Boolean = False
    Public FormAltSRFlagSRFLocNASR As Boolean = False
    Public FormSRFFlagMD As Boolean = False
    Public FormAltSRFlagMD As Boolean = False
    Public FormSRFLat As Double = 0
    Public FormSRFHc As Double = 0
    Public FormSRFZN As Double = 0
    Public FormSRFLHA As Double = 0
    Public FormSRFTotDE As Double = 0
    Public FormAltSRLat As Double = 0
    Public FormAltSRHc As Double = 0
    Public FormAltSRZN As Double = 0
    Public FormAltSRLHA As Double = 0
    Public FormAltSRDec As Double = 0
    Public FormAltSRHtot As Double = 0



    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' initialize common shared references and variable here
        'SFormMeridianDiag = New FormMeridianDiagram()

        Exit Sub
    End Sub
    Private Sub cmd60DST_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmd60DST.Click
        Form60DST.Show()
        Form60DST.SetDesktopLocation(5,5) '
        Me.Show()

    End Sub

    Private Sub cmdAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAbout.Click
        frmAbout.Show()
        frmAbout.SetDesktopLocation(5,5) '
        Me.Show()

    End Sub

    Private Sub cmdArcTime_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdArcTime.Click
        FormArcTime.Show()
        FormArcTime.SetDesktopLocation(5,5) '
        Me.Show()
    End Sub

    Private Sub cmdCPA_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCPA.Click
        FormMoBoard.Show()
        FormMoBoard.SetDesktopLocation(5,5) '
        Me.Show()
    End Sub

    Private Sub cmdDistances_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDistances.Click
        FormDistances.Show()
        FormDistances.SetDesktopLocation(5,5) '
        Me.Show()
    End Sub
    Private Sub cmdLengthDeg_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLengthDeg.Click
        FormLength.Show()
        FormLength.SetDesktopLocation(5,5) '
    End Sub

    Private Sub cmdReduction_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReduction.Click
        FormSRF.Show()
        FormSRF.SetDesktopLocation(5,5) '
        Me.Show()
    End Sub
    Private Sub cmdPlanning_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPlanning.Click
        FormSightPlan.Show()
        FormSightPlan.SetDesktopLocation(5,5) '
        Me.Show()
    End Sub

    Private Sub cmdNoon_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNoon.Click
        FormNoonSight.Show()
        FormNoonSight.SetDesktopLocation(5,5) '
        Me.Show()
    End Sub
    'Private Sub cmdSelectPrinter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    frmSelectPrinter.Show()
    '    Me.Show()
    'End Sub
    Private Sub cmdSailings_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSailings.Click
        FormSailings.Show()
        FormSailings.SetDesktopLocation(5,5) '
        Me.Show()
    End Sub
    Private Sub cmdCTSSOA_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCTSSOA.Click
        FormCTSSOA.Show()
        FormCTSSOA.SetDesktopLocation(5,5) '
    End Sub
    Private Sub cmdTVMDC_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTVMDC.Click
        FormTVMDC.Show()
        FormTVMDC.SetDesktopLocation(5,5) '
        Me.Show()
    End Sub
    Private Sub cmdTwoBearings_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTwoBearings.Click
        FormTwoBearings.Show()
        FormTwoBearings.SetDesktopLocation(5,5) '
        Me.Show()
    End Sub
    Private Sub cmdYellow_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdYellow.Click
        FormIandC.Show()
        FormIandC.SetDesktopLocation(5,5) '
        Me.Show()
    End Sub

    Private Sub MainMenu_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        cleanup()
        'Me.Close()
        Exit Sub
    End Sub
    Private Sub SRMethod_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SRMethod.Click
        FormAltSR.Show()
        FormAltSR.SetDesktopLocation(5,5) '
        Me.Show()
    End Sub
    'Private Sub cmdAveraging_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAveraging.Click
    '    Form9.Show()
    '    Me.Show()
    'End Sub
    Private Sub cmdInterpolate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdInterpolate.Click
        FormNavMath.Show()
        FormNavMath.SetDesktopLocation(5,5) '
        Me.Show()
    End Sub
    Private Sub cmdTides_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTides.Click
        FormTides.Show()
        FormTides.SetDesktopLocation(5,5) '
        Me.Show()
    End Sub
    Private Sub cmdCurrents_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCurrents.Click
        FormCurrents.Show()
        FormCurrents.SetDesktopLocation(5,5) '
        Me.Show()
    End Sub
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        cleanup()
        Me.Close()
        Exit Sub
    End Sub

    Private Sub HelpV2Btn_Click(sender As Object, e As EventArgs) Handles HelpV2Btn.Click
        HelpV2.Show()
        HelpV2.SetDesktopLocation(5,5) '
        Me.Show()

    End Sub

    Private Sub btnSightLog_Click(sender As Object, e As EventArgs) Handles btnSightLog.Click
        SightLog.Show()
        SightLog.SetDesktopLocation(5,5) '
        Me.Show()
    End Sub

    Private Sub btnFavLocs_Click(sender As Object, e As EventArgs) Handles btnFavLocs.Click
        FavoriteLocations.Show()
        FavoriteLocations.SetDesktopLocation(5,5) '
        Me.Show()

    End Sub
    Private Sub cleanup()
        ' this sub moved from its own source code that was globally visible to thsi private sub only visible inside Menu. 
        ' When this Menu form closes, it will exec this sub to see if any other forms are still open and close each
        ' This sub should be exec'd if a user inappropriately uses the 'x' close button in the upper right corner instead of the Exit button

        If Application.OpenForms().OfType(Of FormSRF).Any Then
            FormSRF.Close()  'SRF1
        End If
        If Application.OpenForms().OfType(Of FormSightPlan).Any Then
            FormSightPlan.Close()  'Plan1
        End If
        If Application.OpenForms().OfType(Of Form60DST).Any Then
            Form60DST.Close()  '60DST
        End If
        If Application.OpenForms().OfType(Of frmAbout).Any Then
            frmAbout.Close()
        End If
        If Application.OpenForms().OfType(Of FormArcTime).Any Then
            FormArcTime.Close()  'ArcTime
        End If
        If Application.OpenForms().OfType(Of FormMoBoard).Any Then
            FormMoBoard.Close()  'CPA
        End If
        If Application.OpenForms().OfType(Of FormDistances).Any Then
            FormDistances.Close()  'Distances
        End If
        If Application.OpenForms().OfType(Of FormLength).Any Then
            FormLength.Close()  'Length of Deg
        End If
        If Application.OpenForms().OfType(Of FormNoonSight).Any Then
            FormNoonSight.Close()  'NoonSight
        End If
        If Application.OpenForms().OfType(Of FormSailings).Any Then
            FormSailings.Close()  'Sailings
        End If
        If Application.OpenForms().OfType(Of FormCTSSOA).Any Then
            FormCTSSOA.Close()   'CTS SOA
        End If
        If Application.OpenForms().OfType(Of FormTVMDC).Any Then
            FormTVMDC.Close()   'TVMDC 
        End If
        If Application.OpenForms().OfType(Of FormTwoBearings).Any Then
            FormTwoBearings.Close()   '2 Bearings
        End If
        If Application.OpenForms().OfType(Of FormIandC).Any Then
            FormIandC.Close()   'Yellow
        End If
        If Application.OpenForms().OfType(Of FormAltSR).Any Then
            FormAltSR.Close()  'SRMethods
        End If
        'If Application.OpenForms().OfType(Of Form9).Any Then
        'Form9.Close()  'Averaging
        'End If
        If Application.OpenForms().OfType(Of FormNavMath).Any Then
            FormNavMath.Close()   'Interpolation
        End If
        If Application.OpenForms().OfType(Of FormTides).Any Then
            FormTides.Close()   'Tides
        End If
        If Application.OpenForms().OfType(Of FormCurrents).Any Then
            FormCurrents.Close()   'Currents
        End If
        If Application.OpenForms().OfType(Of HelpV2).Any Then
            HelpV2.Close()
        End If
        If Application.OpenForms().OfType(Of FormMeridianDiagram).Any Then
            FormMeridianDiagram.Close()
        End If
        If Application.OpenForms().OfType(Of CLSForm).Any Then
            CLSForm.Close()
        End If
        If Application.OpenForms().OfType(Of CustomPlot).Any Then
            CustomPlot.Close()
        End If
        If Application.OpenForms().OfType(Of FormMeridianDiagram).Any Then ' Meridian Diagram
            CustomPlot.Close()
        End If
        If Application.OpenForms().OfType(Of SightLog).Any Then
            SightLog.QuickExit()
            SightLog.Close()
        End If
        If Application.OpenForms().OfType(Of FavoriteLocations).Any Then
            FavoriteLocations.QuickExit()
            FavoriteLocations.Close()
        End If
        If Application.OpenForms().OfType(Of DeckLogUpdate).Any Then
            DeckLogUpdate.QuickExit()
            DeckLogUpdate.Close()
        End If
        If Application.OpenForms().OfType(Of CSVUpdater).Any Then
            CSVUpdater.SaveDataGrid()
            CSVUpdater.Close()
        End If
        If Application.OpenForms().OfType(Of DevForm).Any Then
            DevForm.SaveDevDataGrid()
            DevForm.Close()
        End If
        If Application.OpenForms().OfType(Of SRFTimeDiagram).Any Then
            SRFTimeDiagram.Close()
        End If
        If Application.OpenForms().OfType(Of ZTInfo).Any Then
            SRFTimeDiagram.Close()
        End If
        If Application.OpenForms().OfType(Of TraverseTable).Any Then
            TraverseTable.Close()
        End If
        Exit Sub
    End Sub

    Private Sub btnDeckLog_Click(sender As Object, e As EventArgs) Handles btnDeckLog.Click
        DeckLogUpdate.Show()
        DeckLogUpdate.SetDesktopLocation(5,5) '
        Exit Sub
    End Sub

    Private Sub btnCVSFile_Click(sender As Object, e As EventArgs) Handles btnCVSFile.Click
        CSVUpdater.Show()
        CSVUpdater.SetDesktopLocation(5,5) '
        Exit Sub
    End Sub

    Private Sub btnDevForm_Click(sender As Object, e As EventArgs) Handles btnDevForm.Click
        DevForm.Show()
        DevForm.SetDesktopLocation(5,5) '
        Exit Sub
    End Sub

    Private Sub btnZoneTime_Click(sender As Object, e As EventArgs) Handles btnZoneTime.Click
        ZTInfo.Show()
        ZTInfo.SetDesktopLocation(5,5) '
        Exit Sub
    End Sub

    Private Sub btnTraverseTable_Click(sender As Object, e As EventArgs) Handles btnTraverseTable.Click
        TraverseTable.Show()
        TraverseTable.SetDesktopLocation(5,5) '
        Exit Sub
    End Sub
End Class