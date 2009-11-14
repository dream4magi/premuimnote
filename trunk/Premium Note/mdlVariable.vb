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

        Public X As String = CInt((My.Computer.Screen.PrimaryScreen.Bounds.Width - 200) / 2).ToString
        Public Y As String = CInt((My.Computer.Screen.PrimaryScreen.Bounds.Height - 200) / 2).ToString
        Public tabX As String = "0"
        Public tabY As String = "0"

        Function getNo() As String
            Return Me.note_no
        End Function

    End Class

End Class

Module mdlVariable

    Public NoteColor(4) As Color
    Public aryALL_NOTES As New List(Of clsAllNotes.clsNoteData)
    Public aryALL_NOTES_paper As New List(Of INotePaper)

    Public aryDONE_NOTES As New List(Of clsAllNotes.clsNoteData)
    Sub initialNoteColor()
        NoteColor(0) = System.Drawing.Color.FromArgb(255, 230, 62)
        NoteColor(1) = System.Drawing.Color.FromArgb(181, 228, 97)
        NoteColor(2) = System.Drawing.Color.FromArgb(251, 188, 188)
        NoteColor(3) = System.Drawing.Color.FromArgb(183, 234, 253)
        NoteColor(4) = System.Drawing.Color.FromArgb(233, 183, 253)
    End Sub
End Module
