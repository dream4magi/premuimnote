Public Class Form1

    Private Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long) As Long

    Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long, ByVal dwNewLong As Long) As Long

    Private Declare Function SetLayeredWindowAttributes Lib "user32" (ByVal hwnd As Long, ByVal crKey As Long, ByVal bAlpha As Byte, ByVal dwFlags As Long) As Long


    Private Const WS_EX_LAYERED = &H80000

    Private Const GWL_EXSTYLE = (-20)

    Private Const LWA_ALPHA = &H2

    Private Const LWA_COLORKEY = &H1








    Dim hwnd As Int32 = Me.Handle.ToInt32


    Private WithEvents tmr As New Timer

    Private shiftX As Integer
    Private shiftY As Integer

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim rtn As Long

        rtn = GetWindowLong(hwnd, GWL_EXSTYLE)

        rtn = rtn Or WS_EX_LAYERED

        SetWindowLong(hwnd, GWL_EXSTYLE, rtn)

        SetLayeredWindowAttributes(hwnd, 0, 100, LWA_ALPHA)

    End Sub

    Private Sub frmNoteTemplate_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        shiftX = e.X
        shiftY = e.Y
        fageIn = False
        tmr.Start()
    End Sub
    Private Sub frmNoteTemplate_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Top = Me.Top + e.Y - shiftY
            Me.Left = Me.Left + e.X - shiftX
        End If
    End Sub
    Private Sub frmNoteTemplate_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        fageIn = True
        tmr.Start()
    End Sub

    Dim fageIn As Boolean
    Private Sub tmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmr.Tick
        If fageIn Then
            Me.Opacity += 0.1
            If Me.Opacity >= 1 Then tmr.Stop()
        Else
            Me.Opacity -= 0.1
            If Me.Opacity <= 0.5 Then tmr.Stop()
        End If
    End Sub
End Class