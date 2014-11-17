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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("thrthrth")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("rthrth")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("rthrth")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("rthrth")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("rthrthrt")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("rthrthrth")
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("rthrthrth")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("rthrthrth")
        Me.CustomListview1 = New Echecs.Classes.CustomListview()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelAcceuil2 = New Echecs.Classes.AnimatedPbx()
        Me.PanelAcceuil3 = New Echecs.Classes.AnimatedPbx()
        Me.PanelAcceuil1 = New Echecs.Classes.AnimatedPbx()
        CType(Me.PanelAcceuil2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelAcceuil3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelAcceuil1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomListview1
        '
        Me.CustomListview1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.CustomListview1.FullRowSelect = True
        Me.CustomListview1.HighlightColor = System.Drawing.SystemColors.Highlight
        Me.CustomListview1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
        Me.CustomListview1.Location = New System.Drawing.Point(645, 50)
        Me.CustomListview1.Name = "CustomListview1"
        Me.CustomListview1.OwnerDraw = True
        Me.CustomListview1.Size = New System.Drawing.Size(362, 406)
        Me.CustomListview1.TabIndex = 1
        Me.CustomListview1.UseCompatibleStateImageBehavior = False
        Me.CustomListview1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Game name"
        Me.ColumnHeader1.Width = 124
        '
        'PanelAcceuil2
        '
        Me.PanelAcceuil2.Image = Global.Echecs.My.Resources.Resources.download
        Me.PanelAcceuil2.Location = New System.Drawing.Point(32, 256)
        Me.PanelAcceuil2.Name = "PanelAcceuil2"
        Me.PanelAcceuil2.Size = New System.Drawing.Size(300, 200)
        Me.PanelAcceuil2.TabIndex = 0
        Me.PanelAcceuil2.TabStop = False
        Me.PanelAcceuil2.Text = "Paramètres"
        Me.PanelAcceuil2.TextAlign = System.Drawing.StringAlignment.Near
        Me.PanelAcceuil2.TextFont = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAcceuil2.TitleColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelAcceuil2.TitlePosition = Echecs.Classes.TitlePosition.Bottom
        '
        'PanelAcceuil3
        '
        Me.PanelAcceuil3.Image = Global.Echecs.My.Resources.Resources.editedcar2
        Me.PanelAcceuil3.Location = New System.Drawing.Point(338, 50)
        Me.PanelAcceuil3.Name = "PanelAcceuil3"
        Me.PanelAcceuil3.Size = New System.Drawing.Size(300, 406)
        Me.PanelAcceuil3.TabIndex = 0
        Me.PanelAcceuil3.TabStop = False
        Me.PanelAcceuil3.Text = "Multi-joueur"
        Me.PanelAcceuil3.TextAlign = System.Drawing.StringAlignment.Far
        Me.PanelAcceuil3.TextFont = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAcceuil3.TitleColor = System.Drawing.Color.LimeGreen
        Me.PanelAcceuil3.TitlePosition = Echecs.Classes.TitlePosition.Top
        '
        'PanelAcceuil1
        '
        Me.PanelAcceuil1.Image = Global.Echecs.My.Resources.Resources.IMG_8704
        Me.PanelAcceuil1.Location = New System.Drawing.Point(32, 50)
        Me.PanelAcceuil1.Name = "PanelAcceuil1"
        Me.PanelAcceuil1.Size = New System.Drawing.Size(300, 200)
        Me.PanelAcceuil1.TabIndex = 0
        Me.PanelAcceuil1.TabStop = False
        Me.PanelAcceuil1.Text = "Solo"
        Me.PanelAcceuil1.TextAlign = System.Drawing.StringAlignment.Near
        Me.PanelAcceuil1.TextFont = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAcceuil1.TitleColor = System.Drawing.Color.Red
        Me.PanelAcceuil1.TitlePosition = Echecs.Classes.TitlePosition.Top
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 700)
        Me.Controls.Add(Me.CustomListview1)
        Me.Controls.Add(Me.PanelAcceuil2)
        Me.Controls.Add(Me.PanelAcceuil3)
        Me.Controls.Add(Me.PanelAcceuil1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PanelAcceuil2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelAcceuil3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelAcceuil1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelAcceuil1 As Echecs.Classes.AnimatedPbx
    Friend WithEvents PanelAcceuil2 As Echecs.Classes.AnimatedPbx
    Friend WithEvents PanelAcceuil3 As Echecs.Classes.AnimatedPbx
    Friend WithEvents CustomListview1 As Echecs.Classes.CustomListview
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader

End Class
