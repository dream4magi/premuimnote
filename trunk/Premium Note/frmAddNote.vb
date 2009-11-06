Public Class frmAddNote

    Private Sub frmAddNote_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        chk_time_pic()
    End Sub

    Private Sub chkAlerm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlerm.CheckedChanged
        chk_time_pic()

    End Sub




    Sub chk_time_pic()
        Me.DateTimePicker1.Enabled = Me.chkAlerm.Checked
        Me.picAlerm.Visible = Me.chkAlerm.Checked
    End Sub

End Class