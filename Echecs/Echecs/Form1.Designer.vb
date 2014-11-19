<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AnimatedPbx1 = New Echecs.Classes.AnimatedPbx()
        CType(Me.AnimatedPbx1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnimatedPbx1
        '
        Me.AnimatedPbx1.Image = Nothing
        Me.AnimatedPbx1.Location = New System.Drawing.Point(92, 26)
        Me.AnimatedPbx1.Name = "AnimatedPbx1"
        Me.AnimatedPbx1.Size = New System.Drawing.Size(193, 230)
        Me.AnimatedPbx1.TabIndex = 0
        Me.AnimatedPbx1.TabStop = False
        Me.AnimatedPbx1.Text = "AnimatedPbx1"
        Me.AnimatedPbx1.TextAlign = System.Drawing.StringAlignment.Near
        Me.AnimatedPbx1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnimatedPbx1.TitleColor = System.Drawing.Color.Red
        Me.AnimatedPbx1.TitlePosition = Echecs.Classes.TitlePosition.Top
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 381)
        Me.Controls.Add(Me.AnimatedPbx1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AnimatedPbx1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AnimatedPbx1 As Echecs.Classes.AnimatedPbx

End Class
