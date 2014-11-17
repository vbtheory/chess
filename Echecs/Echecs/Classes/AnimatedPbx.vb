Imports System.ComponentModel
Imports System.Drawing.Imaging

Namespace Classes

    <System.ComponentModel.DesignerCategory("DesignCategory.Code")>
    Public Class AnimatedPbx
        Inherits PictureBox

        Dim _timer As Timer = New Timer()
        Dim _brightness As Single = 0.5
        Dim _image As Bitmap
        Private _state = MouseState.None
        Private _font = Font
        Private _textAlign As StringAlignment = StringAlignment.Near
        Private _titlePosition As TitlePosition = TitlePosition.Top
        Private _titleColor As Color = Color.Red

        Public Sub New()
            If Not System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then
                SetStyle(ControlStyles.OptimizedDoubleBuffer + ControlStyles.ResizeRedraw, True)
                SetStyle(ControlStyles.ContainerControl, False)
                _timer.Interval = 30
                AddHandler _timer.Tick, AddressOf Animate
                _timer.Start()
            End If
        End Sub

        Private Sub Animate(ByVal sender As Object, ByVal e As EventArgs)
            Dim target As Single

            If (State = MouseState.Down) Then target = 1
            If (State = MouseState.Inside) Then target = 0.9
            If (State = MouseState.None) Then target = 0.75

            If (_brightness = target) Then Return
            If (_brightness < target) Then _brightness += 0.05
            If (_brightness > target) Then _brightness -= 0.05

            Invalidate()
        End Sub

        Public Shadows Property Image() As Bitmap
            Get
                Return _image
            End Get
            Set(value As Bitmap)
                _image = value
                Invalidate()
            End Set
        End Property

        Public Property TextFont() As Font
            Get
                Return _font
            End Get
            Set(ByVal value As Font)
                _font = value
                Invalidate()
            End Set
        End Property

        <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Overrides Property Text() As String
            Get
                Return MyBase.Text
            End Get
            Set(ByVal value As String)
                MyBase.Text = value
                Invalidate()
            End Set
        End Property

        Private Property State As MouseState
            Get
                Return _state
            End Get
            Set(value As MouseState)
                _state = value
            End Set
        End Property

        Public Property TextAlign As StringAlignment
            Get
                Return _textAlign
            End Get
            Set(value As StringAlignment)
                _textAlign = value
                Invalidate()
            End Set
        End Property

        Public Property TitlePosition As TitlePosition
            Get
                Return _titlePosition
            End Get
            Set(value As TitlePosition)
                _titlePosition = value
                Invalidate()
            End Set
        End Property

        Public Property TitleColor As Color
            Get
                Return _titleColor
            End Get
            Set(value As Color)
                _titleColor = value
                Invalidate()
            End Set
        End Property

        Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
            MyBase.OnMouseEnter(e)
            State = MouseState.Inside
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            State = MouseState.None
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            If (e.Button = MouseButtons.Left) Then State = MouseState.Down
        End Sub

        Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
            MyBase.OnMouseUp(e)
            If (e.Button = MouseButtons.Left) Then State = MouseState.Inside
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)

            Dim sf As New StringFormat
            Dim r = New Rectangle(0, 0, Width, TextFont.Height + 3)

            If (TitlePosition = TitlePosition.Bottom) Then r.Y = Height - (TextFont.Height + 3)
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = TextAlign

            If (Not IsNothing(_image)) Then DrawImageWithBrightness(e.Graphics, _image, e.ClipRectangle, _brightness)
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(150, TitleColor)), r)
            e.Graphics.DrawString(MyBase.Text, TextFont, Brushes.White, r, sf)
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.White, ButtonBorderStyle.Solid)
            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(e.ClipRectangle.X + 1, e.ClipRectangle.Y + 1, e.ClipRectangle.Width - 3, e.ClipRectangle.Height - 3))
        End Sub

        Sub DrawImageWithBrightness(g As Graphics, img As Bitmap, rectangle As Rectangle, opacity As Single)

            Dim matrix As ColorMatrix = New ColorMatrix()

            matrix.Matrix33 = opacity

            Dim ia As ImageAttributes = New ImageAttributes()

            ia.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap)

            g.DrawImage(img, New Rectangle((rectangle.Width - img.Width) / 2, (rectangle.Height - img.Height) / 2, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia)
        End Sub

    End Class

    Enum MouseState
        Down
        Inside
        None
    End Enum

    Public Enum TitlePosition
        Top
        Bottom
    End Enum

End Namespace