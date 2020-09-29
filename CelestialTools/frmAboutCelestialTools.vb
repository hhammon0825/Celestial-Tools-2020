Option Strict Off
Option Explicit On
Friend Class frmAbout
    Inherits System.Windows.Forms.Form

    Private Sub cmdCredits_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        frmCredits.Show()
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        Me.Close()
    End Sub

    Private Sub frmAbout_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        ' The project version information is set in Visual Studio 2019 by Automatic Version Tool VSIX loaded from the Microsoft VS Tools GetTools option
        ' This VSIX tool should be loaded in your version of Visual Studio 2017 or 2019 and be set to update all project and file version info with MM - DD - YYYY - UTC HHMM
        lblVersion.Text = "Celestial Tools Version " & My.Application.Info.Version.Major.ToString("00") & " - " & ' Month of update
        My.Application.Info.Version.Minor.ToString("00") & " - " & ' Day of the Month of update
        My.Application.Info.Version.Build.ToString("0000") & " - " & ' Year of update
        My.Application.Info.Version.Revision.ToString("0000") & vbNewLine & ' UTC time HHMM of update
        ".NET Version:" & Environment.Version.ToString()

        lblTitle.Text = My.Application.Info.Title
    End Sub

    Private Sub frmAbout_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Cleanup()
    End Sub
End Class