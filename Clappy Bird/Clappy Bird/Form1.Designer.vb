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
        Me.components = New System.ComponentModel.Container()
        Me.Bird = New System.Windows.Forms.PictureBox()
        Me.topPipe = New System.Windows.Forms.PictureBox()
        Me.pipe = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Bird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.topPipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bird
        '
        Me.Bird.Image = Global.Clappy_Bird.My.Resources.Resources.birb
        Me.Bird.Location = New System.Drawing.Point(38, 94)
        Me.Bird.Name = "Bird"
        Me.Bird.Size = New System.Drawing.Size(75, 74)
        Me.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bird.TabIndex = 0
        Me.Bird.TabStop = False
        '
        'topPipe
        '
        Me.topPipe.Location = New System.Drawing.Point(488, -1)
        Me.topPipe.Name = "topPipe"
        Me.topPipe.Size = New System.Drawing.Size(198, 114)
        Me.topPipe.TabIndex = 1
        Me.topPipe.TabStop = False
        '
        'pipe
        '
        Me.pipe.Location = New System.Drawing.Point(501, 337)
        Me.pipe.Name = "pipe"
        Me.pipe.Size = New System.Drawing.Size(198, 114)
        Me.pipe.TabIndex = 2
        Me.pipe.TabStop = False
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pipe)
        Me.Controls.Add(Me.topPipe)
        Me.Controls.Add(Me.Bird)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Bird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.topPipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bird As PictureBox
    Friend WithEvents topPipe As PictureBox
    Friend WithEvents pipe As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
