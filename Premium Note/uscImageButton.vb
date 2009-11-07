Public Class uscImageButton
    Dim bmpRegularImage As System.Drawing.Bitmap
    Dim bmpHoverImage As System.Drawing.Bitmap
    Dim bmpPressedImage As System.Drawing.Bitmap
    Shadows Event MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)



    Property RegularImage() As System.Drawing.Bitmap
        Get
            Return bmpRegularImage
        End Get
        Set(ByVal value As System.Drawing.Bitmap)
            bmpRegularImage = value
        End Set
    End Property
    Property HoverImage() As System.Drawing.Bitmap
        Get
            Return bmpHoverImage
        End Get
        Set(ByVal value As System.Drawing.Bitmap)
            bmpHoverImage = value
        End Set
    End Property
    Property PressedImage() As System.Drawing.Bitmap
        Get
            Return bmpPressedImage
        End Get
        Set(ByVal value As System.Drawing.Bitmap)
            bmpPressedImage = value
        End Set
    End Property

    Overloads Property size() As Size
        Get
            Return picButton.Size
        End Get
        Set(ByVal value As Size)
            picButton.Size = value
        End Set
    End Property

    Private Sub uscImageButton_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        picButton.Image = bmpRegularImage
    End Sub

    Private Sub picButton_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picButton.MouseClick
        RaiseEvent MouseClick(sender, e)
    End Sub





    Private Sub picButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picButton.MouseDown
        picButton.Image = bmpPressedImage
    End Sub
    Private Sub picButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picButton.MouseEnter
        picButton.Image = bmpHoverImage
    End Sub
    Private Sub picButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picButton.MouseLeave
        picButton.Image = bmpRegularImage
    End Sub
    Private Sub picButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picButton.MouseUp
        picButton.Image = bmpRegularImage
    End Sub



End Class
