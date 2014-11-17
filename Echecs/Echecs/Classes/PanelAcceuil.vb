Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.Windows.Forms.VisualStyles

Namespace Classes

    Public Class PanelAcceuil
        Inherits Panel

        Dim _timer As Timer = New Timer()
        Dim _brightness As Single = -0.15
        Dim _image As Bitmap
        Private _state = MouseState.None

        Public Sub New()
            DoubleBuffered = True
            _timer.Interval = 30
            AddHandler _timer.Tick, AddressOf Animate
            _timer.Start()
        End Sub

        Private Sub Animate(ByVal sender As Object, ByVal e As EventArgs)
            Dim target As Single

            If (State = MouseState.Inside) Then target = 0
            If (State = MouseState.Down) Then target = -0.1
            If (State = MouseState.None) Then target = -0.15

            If (_brightness = target) Then Return
            If (_brightness < target) Then _brightness += 0.025
            If (_brightness > target) Then _brightness -= 0.025

            Invalidate()
        End Sub
        
        Public Property Image() As Bitmap
            Get
                Return _image
            End Get
            Set(value As Bitmap)
                _image = value
                Invalidate()
            End Set
        End Property

        <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
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

            If (Not IsNothing(_image)) Then DrawImageWithBrightness(e.Graphics, _image, e.ClipRectangle, _brightness)
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(150, Color.Red)), 0, 0, Width, Font.Height + 3)
            e.Graphics.DrawString(MyBase.Text, Font, Brushes.White, New RectangleF(0, 0, Width, Font.Height + 3), StringFormat.GenericDefault)
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.White, ButtonBorderStyle.Solid)
            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(e.ClipRectangle.X + 1, e.ClipRectangle.Y + 1, e.ClipRectangle.Width - 3, e.ClipRectangle.Height - 3))

        End Sub
        Sub DrawImageWithBrightness(g As Graphics, img As Bitmap, rectangle As Rectangle, brightness As Single)
            Dim colorMatrixVal As Single()() = { _
               New Single() {1, 0, 0, 0, 0}, _
               New Single() {0, 1, 0, 0, 0}, _
               New Single() {0, 0, 1, 0, 0}, _
               New Single() {0, 0, 0, 1, 0}, _
               New Single() {brightness, brightness, brightness, 0, 1}}

            Dim colorMatrix As New ColorMatrix(colorMatrixVal)
            Dim ia As New ImageAttributes

            ia.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap)

            g.DrawImage(img, rectangle, 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia)
        End Sub

    End Class

    Enum MouseState
        Down
        Inside
        None
    End Enum

End Namespace