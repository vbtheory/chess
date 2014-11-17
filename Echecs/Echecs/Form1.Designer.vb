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
        Me.PanelAcceuil2 = New Echecs.Classes.PanelAcceuil()
        Me.PanelAcceuil3 = New Echecs.Classes.PanelAcceuil()
        Me.PanelAcceuil1 = New Echecs.Classes.PanelAcceuil()
        Me.SuspendLayout()
        '
        'PanelAcceuil2
        '
        Me.PanelAcceuil2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAcceuil2.Image = Global.Echecs.My.Resources.Resources.Screenshot_2014_10_05_22_12_24
        Me.PanelAcceuil2.Location = New System.Drawing.Point(32, 256)
        Me.PanelAcceuil2.Name = "PanelAcceuil2"
        Me.PanelAcceuil2.Size = New System.Drawing.Size(200, 200)
        Me.PanelAcceuil2.TabIndex = 0
        Me.PanelAcceuil2.Text = "Paramètres"
        '
        'PanelAcceuil3
        '
        Me.PanelAcceuil3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAcceuil3.Image = Global.Echecs.My.Resources.Resources.Screenshot_2014_10_05_22_12_24
        Me.PanelAcceuil3.Location = New System.Drawing.Point(238, 50)
        Me.PanelAcceuil3.Name = "PanelAcceuil3"
        Me.PanelAcceuil3.Size = New System.Drawing.Size(406, 406)
        Me.PanelAcceuil3.TabIndex = 0
        Me.PanelAcceuil3.Text = "Multi-joueur"
        '
        'PanelAcceuil1
        '
        Me.PanelAcceuil1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAcceuil1.Image = Global.Echecs.My.Resources.Resources.Screenshot_2014_10_05_22_12_24
        Me.PanelAcceuil1.Location = New System.Drawing.Point(32, 50)
        Me.PanelAcceuil1.Name = "PanelAcceuil1"
        Me.PanelAcceuil1.Size = New System.Drawing.Size(200, 200)
        Me.PanelAcceuil1.TabIndex = 0
        Me.PanelAcceuil1.Text = "Solo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 506)
        Me.Controls.Add(Me.PanelAcceuil2)
        Me.Controls.Add(Me.PanelAcceuil3)
        Me.Controls.Add(Me.PanelAcceuil1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelAcceuil1 As Echecs.Classes.PanelAcceuil
    Friend WithEvents PanelAcceuil2 As Echecs.Classes.PanelAcceuil
    Friend WithEvents PanelAcceuil3 As Echecs.Classes.PanelAcceuil

End Class
