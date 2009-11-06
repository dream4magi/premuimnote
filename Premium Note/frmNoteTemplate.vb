Public Class frmNoteTemplate


    Dim noteData As clsNoteData

    'Public note_title As String
    'Public note_content As String

    'Public note_create_time As String
    'Public note_done_time As String


    'Public note_alerm_enable As String
    'Public note_alerm_time As String

    'Public note_piority As String
    'Public blnNoteDetailmode As String

    Private Sub changeNoteMode(ByVal blnDetailMode As Boolean)
        If blnDetailMode Then 'change to detail mode

        Else

        End If
    End Sub



    Property readNoteData() As clsNoteData
        Get
            Return noteData
        End Get
        Set(ByVal value As clsNoteData)
            noteData = value
        End Set
    End Property


    Property noteDetailMode() As Boolean
        Get
            If noteData.blnNoteDetailmode.ToLower.Equals("true") Then
                Return True
            Else
                Return False
            End If
        End Get
        Set(ByVal value As Boolean)

            noteData.blnNoteDetailmode = value.ToString
            changeNoteMode(value)
        End Set
    End Property

End Class