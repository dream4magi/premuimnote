Option Strict On
Option Explicit On
Public Class clsAllNotes
    Public Notes() As clsNoteData




End Class
Public Class clsNoteData

    Implements ICloneable

    Public Sub New(ByVal str_Note_No As String)
        note_no = str_Note_No
    End Sub

    Public note_no As String = ""

    Public note_title As String = ""
    Public note_content As String = ""

    Public note_create_time As String = Now().ToString("yyyy-MM-dd HH:mm")
    Public note_done_time As String = ""


    Public note_alerm_enable As String = "N"
    Public note_alerm_time As String = ""

    Public note_piority As String = ""
    Public blnNoteDetailmode As String = "Y"

    Public note_color As String = "0"

    Public note_TabAutoHide As String = "Y"

    Public X As String = CInt((My.Computer.Screen.PrimaryScreen.Bounds.Width - 200) / 2).ToString
    Public Y As String = CInt((My.Computer.Screen.PrimaryScreen.Bounds.Height - 200) / 2).ToString

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Dim CloneObj As New clsNoteData(Me.note_no)

        CloneObj.note_title = Me.note_title
        CloneObj.note_content = Me.note_content

        CloneObj.note_create_time = Me.note_create_time
        CloneObj.note_done_time = Me.note_done_time


        CloneObj.note_alerm_enable = Me.note_alerm_enable
        CloneObj.note_alerm_time = Me.note_alerm_time

        CloneObj.note_piority = Me.note_piority
        CloneObj.blnNoteDetailmode = Me.blnNoteDetailmode

        CloneObj.note_color = Me.note_color

        CloneObj.note_TabAutoHide = Me.note_TabAutoHide

        CloneObj.X = Me.X
        CloneObj.Y = Me.Y

        Return CloneObj
    End Function



 
End Class