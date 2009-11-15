Option Strict On
Option Explicit On
Public Class clsAllNotes
    Public Notes() As clsNoteData


    Public Class clsNoteData
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


        Function getNo() As String
            Return Me.note_no
        End Function

    End Class

End Class