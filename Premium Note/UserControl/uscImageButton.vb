Public Class uscImageButton

    Shadows Event MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub uscImageButton_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.picBtn.Image = imgRegular
    End Sub


    Shadows Property Size() As Size
        Get
            Return Me.picBtn.Size
        End Get
        Set(ByVal value As Size)
            Me.picBtn.Size = value
            MyBase.Size = value
        End Set
    End Property


    Dim imgRegular As System.Drawing.Bitmap
    Property RegularImage() As System.Drawing.Bitmap
        Get
            Return imgRegular
        End Get
        Set(ByVal value As Drawing.Bitmap)
            imgRegular = value
            Me.picBtn.Image = value
        End Set
    End Property

    Dim imgHover As System.Drawing.Bitmap

    Property HoverImage() As System.Drawing.Bitmap
        Get
            Return imgHover
        End Get
        Set(ByVal value As Drawing.Bitmap)
            imgHover = value
        End Set
    End Property

    Dim imgPressed As System.Drawing.Bitmap
    Property PressedImage() As System.Drawing.Bitmap
        Get
            Return imgPressed
        End Get
        Set(ByVal value As Drawing.Bitmap)
            imgPressed = value
        End Set
    End Property


    Private Sub picBtn_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBtn.MouseClick
        RaiseEvent MouseClick(sender, e)
    End Sub

    Private Sub picBtn_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBtn.MouseDown
        picBtn.Image = Me.imgPressed
    End Sub
    Private Sub picBtn_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBtn.MouseEnter
        picBtn.Image = Me.imgHover
    End Sub

    Private Sub picBtn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBtn.MouseLeave
        picBtn.Image = Me.imgRegular
    End Sub





    Private Sub picBtn_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBtn.MouseUp
        picBtn.Image = Me.imgRegular
    End Sub

End Class
