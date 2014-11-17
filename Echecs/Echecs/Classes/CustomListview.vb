Namespace Classes

    <System.ComponentModel.DesignerCategory("DesignCategory.Code")>
    Public Class CustomListview
        Inherits ListView

        Private _highlightColor As Color = SystemColors.Highlight

        Public Sub New()
            OwnerDraw = True
        End Sub

        Public Property HighlightColor As Color
            Get
                Return _highlightColor
            End Get
            Set(value As Color)
                _highlightColor = value
                Invalidate()
            End Set
        End Property

        Protected Overrides Sub OnDrawItem(ByVal e As DrawListViewItemEventArgs)

            If (e.Item.Selected) Then
                e.Graphics.FillRectangle(New SolidBrush(HighlightColor), e.Bounds)
                TextRenderer.DrawText(e.Graphics, e.Item.Text, e.Item.Font, e.Bounds, Color.White, TextFormatFlags.Default)
            Else
                TextRenderer.DrawText(e.Graphics, e.Item.Text, e.Item.Font, e.Bounds, Color.Black, TextFormatFlags.Default)
            End If

            If (e.Item.Focused) Then e.DrawFocusRectangle()

            'MyBase.OnDrawItem(e)
        End Sub
    End Class

End Namespace